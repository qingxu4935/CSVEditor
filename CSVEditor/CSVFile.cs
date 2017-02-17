using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVEditor
{
	public class CSVFile
	{
		public CSVFile(string filename)
		{
			CsvPath = filename;
			CsvLines = File.ReadAllLines(CsvPath);
			ColumnNames = CsvLines[2].Split('\t');
		}
		
		public DataTable ToDataTable()
		{
			var table = new DataTable();

			for (var index = 0; index < ColumnNames.Length; index++)
			{
				var columnName = ColumnNames[index];
				table.Columns.Add(index + "-" + columnName, typeof(string));
			}

			foreach (var line in CsvLines.Skip(3))
			{
				var columnValues = line.Split('\t');
				var row = table.NewRow();
				for (var i = 0; i < columnValues.Length; i++)
				{
					row[i] = columnValues[i];
				}
				table.Rows.Add(row);
			}
			return table;
		}

		public void Save(IEnumerable<string> newLines, out string bakCSVPath)
		{
			bakCSVPath = GetBakCSVPath(CsvPath);
			File.Move(CsvPath, bakCSVPath);

			var content = new List<string>();
			content.AddRange(CsvLines.Take(3));
			content.AddRange(newLines);
			File.WriteAllLines(CsvPath, content, Encoding.Unicode);
		}

		private static string GetBakCSVPath(string csvPath)
		{
			var count = 1;
			var fileNameOnly = Path.GetFileNameWithoutExtension(csvPath)+"bak";
			var extension = Path.GetExtension(csvPath);
			var path = Path.GetDirectoryName(csvPath);
			Debug.Assert(path != null, "path != null");
			var newFullPath = Path.Combine(path, fileNameOnly + extension);
			while (File.Exists(newFullPath))
			{
				var tempFileName = $"{fileNameOnly}({count++})";
				Debug.Assert(path != null, "path != null");
				newFullPath = Path.Combine(path, tempFileName + extension);
			}
			return newFullPath;
		}

		public string CsvPath { get; }
		public string[] CsvLines { get; }
		public string[] ColumnNames { get; }
	}
}