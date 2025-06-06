using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace ConsoleApp
{
  public static class ExcelReader
  {
    public static List<Dictionary<string, string>> ReadExcelFile(string filePath)
    {
      var database = new List<Dictionary<string, string>>();
      var package = new ExcelPackage(new FileInfo(filePath));
      var worksheet = package.Workbook.Worksheets[0];

      for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
      {
        var record = new Dictionary<string, string>();
        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
        {
          string key = worksheet.Cells[1, col].Value.ToString();
          string value = worksheet.Cells[row, col].Value?.ToString();
          record[key] = value;
        }
        database.Add(record);
      }

      return database;
    }
  }
}
