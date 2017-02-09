using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSVEditor
{
	public partial class CSVEditorForm : System.Windows.Forms.Form
	{
		public CSVEditorForm()
		{
			InitializeComponent();
			cb.DataSource = _rules.Keys.ToList();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog
			{
				Title = "请选择文件",
				Filter = "CSV Files (*.csv)|*.csv"
			};
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				_csvPath = fileDialog.FileName;
				_csvLines = File.ReadAllLines(_csvPath);
				var columnNames = _csvLines[2].Split('\t');

				var table = new DataTable();
				for (var index = 0; index < columnNames.Length; index++)
				{
					var columnName = columnNames[index];
					table.Columns.Add(index + "-" + columnName, typeof(string));
				}

				foreach (var line in _csvLines.Skip(3))
				{
					var columnValues = line.Split('\t');
					var row = table.NewRow();
					for (var i = 0; i < columnValues.Length; i++)
					{
						row[i] = columnValues[i];
					}
					table.Rows.Add(row);
				}

				listView.Columns.Add("列", 200, HorizontalAlignment.Left);
				foreach (var s in columnNames.Select((x, i) => i + "-" + x))
				{
					var item = listView.Items.Add(s);
					item.SubItems.Add(s);
				}
				grid.DataSource = table;
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
			if (string.IsNullOrEmpty(_csvPath))
			{
				MessageBox.Show("请选择CSV");
				return;
			}
			var count = 1;
			var fileNameOnly = Path.GetFileNameWithoutExtension(_csvPath);
			var extension = Path.GetExtension(_csvPath);
			var path = Path.GetDirectoryName(_csvPath);
			var newFullPath = _csvPath;

			while (File.Exists(newFullPath))
			{
				var tempFileName = $"{fileNameOnly}({count++})";
				newFullPath = Path.Combine(path, tempFileName + extension);
			}
			var newLines = new List<string>();
			newLines.AddRange(_csvLines.Take(3));
			newLines.AddRange(grid.Rows.Cast<DataGridViewRow>().Select(x => string.Join("\t", x.Cells.Cast<DataGridViewCell>().Select(y => y.Value.ToString()))));

			File.WriteAllLines(newFullPath, newLines, Encoding.Unicode);
			MessageBox.Show("保存成功，请查看" + newFullPath + ", 谢谢！");
		}

		private void Execute(Func<string, string> getValue)
		{
			var selectedColumnNames = listView.Items.Cast<ListViewItem>().Where(x => x.Checked).Select(x => x.Text).ToList();

			if (!selectedColumnNames.Any())
			{
				MessageBox.Show("请选择列");
				return;
			}
			var ruleName = cb.Text;
			if (string.IsNullOrEmpty(ruleName))
			{
				MessageBox.Show("请选择规则");
				return;
			}

			var conditionText = txtCondition.Text;
			foreach (DataGridViewRow row in grid.Rows)
			{
				foreach (var selectedColumnName in selectedColumnNames)
				{
					var cell = row.Cells[selectedColumnName];
					var cellValue = cell.Value.ToString();
					var isDoublequotesAround = cellValue.StartsWith("\"") && cellValue.EndsWith("\"");
					if (isDoublequotesAround)
					{
						cellValue = cellValue.Trim('\"');
					}
					if (MatchRule(cellValue, ruleName, conditionText, row.Index))
					{
						var value = getValue.Invoke(cellValue);
						cell.Value = isDoublequotesAround ? "\"" + value + "\"" : value;
					}
				}
			}
			MessageBox.Show("操作成功！！！");
		}

		private bool MatchRule(string oldValue, string ruleName, string condition, int index)
		{
			var func = _rules[ruleName];
			return func.Invoke(oldValue, condition, index);
		}

		private void cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtCondition.Text = string.Empty;
			txtCondition.Visible = _arrs.Contains(cb.Text);
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

		private static readonly Regex AlphaNumericRegex = new Regex(@"^[a-zA-Z0-9]*$");
		private string _csvPath;
		private string[] _csvLines;
	}
}
