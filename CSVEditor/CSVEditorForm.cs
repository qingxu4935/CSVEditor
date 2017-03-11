using CSVEditor.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace CSVEditor
{
	public partial class CSVEditorForm : Form
	{
		public CSVEditorForm()
		{
			InitializeComponent();
			cb.DataSource = _rules.Keys.ToList();
		}

		private void btnSelectCSV_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog
			{
				Title = Resources.SelectACSVFile,
				Filter = "CSV Files (*.csv)|*.csv"
			};
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				csvFile = new CSVFile(fileDialog.FileName);

				listView.Columns.Add("列", 200, HorizontalAlignment.Left);
				foreach (var s in csvFile.ColumnNames.Select((x, i) => i + "-" + x))
				{
					var item = listView.Items.Add(s);
					item.SubItems.Add(s);
				}
				var dt = csvFile.ToDataTable();
				gridCSV.DataSource = dt;
				gridOld.DataSource = dt.Copy();
			}
		}

		private void btnBulkUpdate_Click(object sender, EventArgs e)
		{
			var vauleAfter = textBoxAfter.Text;
			Execute(cellValue => vauleAfter);
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			var oldText = txtOld.Text;
			if (!string.IsNullOrEmpty(oldText))
			{
				var newText = txtNew.Text;
				Execute(cellValue => cellValue.Replace(oldText, newText));
			}
		}

		private void btnHead_Click(object sender, EventArgs e)
		{
			var headText = txtHead.Text;
			if (!string.IsNullOrEmpty(headText))
			{
				Execute(cellValue => headText + cellValue);
			}
		}

		private void btnTail_Click(object sender, EventArgs e)
		{
			var tailText = txtTail.Text;
			if (!string.IsNullOrEmpty(tailText))
			{
				Execute(cellValue => cellValue + tailText);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (csvFile == null)
			{
				MessageBox.Show(Resources.SelectACSVFile);
				return;
			}

			string bakCsvPath;
			var newLines =
				gridCSV.Rows.Cast<DataGridViewRow>()
					.Select(x => string.Join("\t", x.Cells.Cast<DataGridViewCell>().Select(y => y.Value.ToString())));
			csvFile.Save(newLines, out bakCsvPath);

			MessageBox.Show($"保存成功，请查看新文件{csvFile.CsvPath}, 备份{bakCsvPath},谢谢！");
		}

		private void cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtCondition.Text = string.Empty;
			txtCondition.Visible = _arrs.Contains(cb.Text);
		}

		private void btnSelectExcel_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog
			{
				Title = Resources.SelectACSVFile,
				Filter = "Excel Files|*.xls;*.xlsx"
			};
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				gridExcel.DataSource = ExcelHelper.ExcelToDataTable(fileDialog.FileName, "", true);
			}
		}

		private void btnUpdateByExcel_Click(object sender, EventArgs e)
		{
			if (gridExcel.Rows.Count == 0)
			{
				MessageBox.Show(Resources.SelectAnExcelFile);
				return;
			}

			if (gridCSV.Rows.Count == 0)
			{
				MessageBox.Show(Resources.SelectACSVFile);
				return;
			}

			foreach (DataGridViewRow excelRow in gridExcel.Rows)
			{
				var productName = excelRow.Cells["宝贝名称"].Value.ToString();
				if (string.IsNullOrEmpty(productName))
				{
					continue;
				}

				var productFromCSV = gridCSV.Rows.Cast<DataGridViewRow>().SingleOrDefault(x => GetColumnValueInCSVRow(x, "0-宝贝名称") == productName);
				if (productFromCSV != null)
				{
					//0-宝贝名称
					var productTitle = excelRow.Cells["标题"].Value.ToString();
					SetColumnValueInCSVRow(productFromCSV, "0-宝贝名称", productTitle);

					//33-商家编码
					var productSellCode = excelRow.Cells["商家编码"].Value.ToString();
					SetColumnValueInCSVRow(productFromCSV, "33-商家编码", productSellCode);

					//32-用户输入名-值对
					//var productBrand = excelRow.Cells["品牌"].Value.ToString();
					//var productCategory = excelRow.Cells["品种基词"].Value.ToString();
					//var productCategoryHead = productCategory.Length > 2
					//	? productCategory.Substring(0, 2)
					//	: productCategory.PadLeft(2, '*');
					//SetColumnValueInCSVRow(productFromCSV, "32-用户输入名-值对", productBrand + ";型号;" + productCategoryHead + GetUniqueModelNumber() + "," + productCategoryHead + GetUniqueCargoNumber());

					//39-账户名称
					SetColumnValueInCSVRow(productFromCSV, "39-账户名称", "");

					//7-宝贝价格 || 30-销售属性组合
					var productDeltaStr = excelRow.Cells["增价"].Value.ToString();
					decimal productDelta;
					if (!decimal.TryParse(productDeltaStr, out productDelta))
					{
						productDelta = 0M;
					}
					if (productDelta != 0M)
					{
						// 7-宝贝价格
						var oldProductPriceStr = GetColumnValueInCSVRow(productFromCSV, "7-宝贝价格");
						decimal oldProductPrice;
						if (!decimal.TryParse(oldProductPriceStr, out oldProductPrice))
						{
							oldProductPrice = 0M;
						}
						SetColumnValueInCSVRow(productFromCSV, "7-宝贝价格", (oldProductPrice + productDelta).ToString(CultureInfo.InvariantCulture));
						// 30-销售属性组合
						var oldProductAttributeCombinesStr = GetColumnValueInCSVRow(productFromCSV, "30-销售属性组合");
						if (!string.IsNullOrEmpty(oldProductAttributeCombinesStr))
						{
							var newProductAttributeCombines = GetNewProductAttributeCombines(oldProductAttributeCombinesStr, productDelta);

							SetColumnValueInCSVRow(productFromCSV, "30-销售属性组合", string.Join(";", newProductAttributeCombines));
						}
					}
				}
			}
			MessageBox.Show(Resources.OperationIsSucessful);
		}

		private void btnDeleteValidImg_Click(object sender, EventArgs e)
		{
			if (gridCSV.Rows.Count == 0)
			{
				MessageBox.Show(Resources.SelectACSVFile);
				return;
			}

			foreach (DataGridViewRow excelRow in gridCSV.Rows)
			{
				var productDescription = GetColumnValueInCSVRow(excelRow, "20-宝贝描述");
				if (!string.IsNullOrEmpty(productDescription))
				{
					SetColumnValueInCSVRow(excelRow, "20-宝贝描述", GetNewProductDescription(productDescription));
				}
				
			}
			MessageBox.Show(Resources.OperationIsSucessful);
		}

		string GetNewProductDescription(string productDescription)
		{
			var doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(productDescription);
			var imgNodesToDelete = new List<HtmlNode>();
			foreach (var node in doc.DocumentNode.SelectNodes("//img[@src]"))
			{
				if (node.Name.ToLower() == "img")
				{
					var src = node.GetAttributeValue("src", "");
					if (!string.IsNullOrEmpty(src) && src.Length >= 8)
					{
						var srcPath = src.Substring(8);
						if (!File.Exists(srcPath))
						{
							imgNodesToDelete.Add(node);
						}
					}
				}
			}

			foreach (var node in imgNodesToDelete)
			{
				node?.Remove();
			}
			return Regex.Replace(doc.DocumentNode.OuterHtml, @"\s{2,}", "");
		}

		private static string[] GetNewProductAttributeCombines(string oldProductAttributeCombinesStr, decimal productDelta)
		{
			var oldProductAttributeCombines = oldProductAttributeCombinesStr.Split(';');
			var newProductAttributeCombines = new string[oldProductAttributeCombines.Length];
			for (var i = 0; i < oldProductAttributeCombines.Length; i++)
			{
				var oldProductAttributeCombine = oldProductAttributeCombines[i];
				newProductAttributeCombines[i] = oldProductAttributeCombine;
				if (!string.IsNullOrEmpty(oldProductAttributeCombine) && oldProductAttributeCombine.Contains("::"))
				{
					var arr = oldProductAttributeCombine.Split(new[] { "::" }, StringSplitOptions.None);
					if (!string.IsNullOrEmpty(arr[0])
						&& arr[0].Contains(":"))
					{
						var brr = arr[0].Split(':');
						if (brr.Length == 2)
						{
							decimal price;
							if (!decimal.TryParse(brr[0], out price))
							{
								price = 0M;
							}
							newProductAttributeCombines[i] = (price + productDelta).ToString(CultureInfo.InvariantCulture) + ":" + brr[1] + "::" + arr[1];
						}
					}
				}
			}
			return newProductAttributeCombines;
		}

		//private List<string> ExistingModelNumbers
		//{
		//	get
		//	{
		//		var result = new List<string>();
		//		foreach (DataGridViewRow row in gridCSV.Rows)
		//		{
		//			var keyValue = GetColumnValueInCSVRow(row, "32-用户输入名-值对");
		//			if (!string.IsNullOrEmpty(keyValue)
		//				&& keyValue.Count(x => x == ';') == 2
		//				&& keyValue.Count(x => x == ',') == 1)
		//			{
		//				var arr = keyValue.Split(new[] { ';' }, 3);
		//				if (arr[1] == "型号"
		//					&& !string.IsNullOrEmpty(arr[2])
		//					&& arr[2].Length > 1
		//					&& arr[2].Contains(','))
		//				{
		//					var brr = arr[2].Split(new[] { ',' }, 2);
		//					if (!string.IsNullOrEmpty(brr[0]) && brr[0].Length == 7)
		//					{
		//						result.Add(brr[0].Substring(2));
		//					}
		//				}
		//			}
		//		}
		//		return result;
		//	}
		//}

		//private string GetUniqueModelNumber()
		//{
		//	var a = random.Next(0, 25);
		//	var b = random.Next(0, 25);
		//	var c = random.Next(0, 999);

		//	var number = characters[a].ToString() + characters[b].ToString() + c.ToString().PadLeft(3, '0');
		//	return !ExistingModelNumbers.Contains(number) ? number : GetUniqueModelNumber();
		//}

		//private List<string> ExistingCargoNumbers
		//{
		//	get
		//	{
		//		var result = new List<string>();
		//		foreach (DataGridViewRow row in gridCSV.Rows)
		//		{
		//			var keyValue = GetColumnValueInCSVRow(row, "32-用户输入名-值对");
		//			if (!string.IsNullOrEmpty(keyValue)
		//				&& keyValue.Count(x => x == ';') == 2
		//				&& keyValue.Count(x => x == ',') == 1)
		//			{
		//				var arr = keyValue.Split(new[] { ';' }, 3);
		//				if (arr[1] == "型号"
		//					&& !string.IsNullOrEmpty(arr[2])
		//					&& arr[2].Length > 1
		//					&& arr[2].Contains(','))
		//				{
		//					var brr = arr[2].Split(new[] { ',' }, 2);
		//					if (!string.IsNullOrEmpty(brr[1]) && brr[1].Length == 10)
		//					{
		//						result.Add(brr[1].Substring(2));
		//					}
		//				}
		//			}
		//		}
		//		return result;
		//	}
		//}

		//private string GetUniqueCargoNumber()
		//{
		//	var a = random.Next(0, 25);
		//	var b = random.Next(0, 25);
		//	var c = random.Next(0, 25);
		//	var d = random.Next(0, 99999);

		//	var number = characters[a].ToString() + characters[b].ToString() + characters[c].ToString() + d.ToString().PadLeft(5, '0');
		//	return !ExistingCargoNumbers.Contains(number) ? number : GetUniqueCargoNumber();
		//}

		private void Execute(Func<string, string> getValue)
		{
			var selectedColumnNames = listView.Items.Cast<ListViewItem>().Where(x => x.Checked).Select(x => x.Text).ToList();

			if (!selectedColumnNames.Any())
			{
				MessageBox.Show(Resources.SelectCSVColumnNames);
				return;
			}

			var ruleName = cb.Text;
			if (string.IsNullOrEmpty(ruleName))
			{
				MessageBox.Show(Resources.SelectFilterRule);
				return;
			}

			var conditionText = txtCondition.Text;
			foreach (DataGridViewRow row in gridCSV.Rows)
			{
				foreach (var selectedColumnName in selectedColumnNames)
				{
					var cellValue = GetColumnValueInCSVRow(row, selectedColumnName);
					if (MatchRule(cellValue, ruleName, conditionText, row.Index))
					{
						var newColumnValue = getValue.Invoke(cellValue);
						SetColumnValueInCSVRow(row, selectedColumnName, newColumnValue);
					}
				}
			}
			MessageBox.Show(Resources.OperationIsSucessful);
		}

		private static void SetColumnValueInCSVRow(DataGridViewRow row, string collumnName, string columnValue)
		{
			var cell = row.Cells[collumnName];
			var currentCellValue = cell.Value.ToString();

			var isDoublequotesAround = currentCellValue.StartsWith("\"") && currentCellValue.EndsWith("\"");
			cell.Value = isDoublequotesAround ? "\"" + columnValue.Replace("\"", "\"\"") + "\"" : columnValue;
		}

		private static string GetColumnValueInCSVRow(DataGridViewRow row, string collumnName)
		{
			var cell = row.Cells[collumnName];
			var cellValue = cell.Value.ToString();
			var isDoublequotesAround = cellValue.StartsWith("\"") && cellValue.EndsWith("\"");
			if (isDoublequotesAround)
			{
				cellValue = cellValue.Trim('\"').Replace("\"\"","\"");
			}
			return cellValue;
		}

		private bool MatchRule(string oldValue, string ruleName, string condition, int index)
		{
			var func = _rules[ruleName];
			return func.Invoke(oldValue, condition, index);
		}

		private readonly Dictionary<string, Func<string, string, int, bool>> _rules = new Dictionary<string, Func<string, string, int, bool>>
		{
			{"任意",(oldValue,condition,index)=>true},
			{"空白",(oldValue,condition,index)=>string.IsNullOrEmpty(oldValue)},
			{"全数字",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.All(char.IsDigit)},
			{"以数字开头",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&char.IsDigit(oldValue.First())},
			{"包含数字",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.Any(char.IsDigit)},
			{"以数字结尾", (oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&char.IsDigit(oldValue.Last())},
			{"全字母",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.All(x=>x>=63&&x<=126)},
			{"以字母开头",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.First()>=63&&oldValue.First()<=126},
			{"包含字母",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.Any(x=>x>=63&&x<=126)},
			{"以字母结尾",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&oldValue.Last()>=63&&oldValue.Last()<=126},
			{"字母数字混合",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&AlphaNumericRegex.IsMatch(oldValue)},
			{"偶数行",(oldValue,condition,index)=>index%2==0},
			{"奇数行",(oldValue,condition,index)=>index%2!=0},
			{"以什么为开头",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&!string.IsNullOrEmpty(condition)&&oldValue.StartsWith(condition)},
			{"包含什么",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&!string.IsNullOrEmpty(condition)&&oldValue.Contains(condition)},
			{"以什么为结尾",(oldValue,condition,index)=>!string.IsNullOrEmpty(oldValue)&&!string.IsNullOrEmpty(condition)&&oldValue.EndsWith(condition)}
		};

		readonly List<string> _arrs = new List<string>
		{
			"以什么为开头",
			"包含什么",
			"以什么为结尾"
		};

		const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private static Random random = new Random();

		private static readonly Regex AlphaNumericRegex = new Regex(@"^[a-zA-Z0-9]*$");
		private CSVFile csvFile;
	}
}
