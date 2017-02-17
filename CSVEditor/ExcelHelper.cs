using System;
using System.Data;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace CSVEditor
{
	public static class ExcelHelper
	{
		public static DataTable ExcelToDataTable(string fileName, string sheetName, bool isFirstRowColumn)
		{
			var result = new DataTable();
			IWorkbook workbook = null;
			IFormulaEvaluator evaluator = null;
			using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				if (fileName.EndsWith(".xlsx", StringComparison.Ordinal))
				{
					workbook = new XSSFWorkbook(fs);
					evaluator= new XSSFFormulaEvaluator(workbook);
				}
				else if (fileName.EndsWith(".xls", StringComparison.Ordinal))
				{
					workbook = new HSSFWorkbook(fs);
					evaluator = new HSSFFormulaEvaluator(workbook);
				}
			}
			if (workbook == null) return result;

			var sheet = GetSheet(workbook, sheetName);
			if (sheet == null) return result;

			var firstRow = sheet.GetRow(0);
			var columnCount = firstRow.LastCellNum;
			var rowCount = sheet.LastRowNum;

			if (isFirstRowColumn)
			{
				for (var i = firstRow.FirstCellNum; i < columnCount; ++i)
				{
					var cell = firstRow.GetCell(i);
					var cellValue = cell?.StringCellValue;
					if (cellValue != null)
					{
						var column = new DataColumn(cellValue);
						result.Columns.Add(column);
					}
				}
			}

			var startRow = isFirstRowColumn ? sheet.FirstRowNum + 1 : sheet.FirstRowNum;
			for (var i = startRow; i <= rowCount; ++i)
			{
				var row = sheet.GetRow(i);
				if (row == null) continue;

				var dataRow = result.NewRow();
				for (var j = row.FirstCellNum; j < columnCount; ++j)
				{
					var cell = row.GetCell(j);
					if (cell != null)
					{
						dataRow[j] = cell.CellType == CellType.Formula
							? evaluator.Evaluate(cell).FormatAsString().Trim('\"')
							: cell.ToString();
					}
				}
				result.Rows.Add(dataRow);
			}

			return result;
		}

		private static ISheet GetSheet(IWorkbook workbook, string sheetName)
		{
			ISheet sheet;
			if (string.IsNullOrEmpty(sheetName))
			{
				sheet = workbook.GetSheet(sheetName) ?? workbook.GetSheetAt(0);
			}
			else
			{
				sheet = workbook.GetSheetAt(0);
			}
			return sheet;
		}
	}
}