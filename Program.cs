using System;
using System.Collections.Generic;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = "LR5-var1.xlsx";
      List<Dictionary<string, string>> database = ExcelReader.ReadExcelFile(filePath);

      while (true)
      {
        Console.WriteLine("1. View Database");
        Console.WriteLine("2. Delete Element (by key)");
        Console.WriteLine("3. Edit Element (by key)");
        Console.WriteLine("4. Add Element");
        Console.WriteLine("5. Execute Queries");
        Console.WriteLine("6. Write to Text File");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an action: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            DatabaseViewer.ViewDatabase(database);
            break;
          case "2":
            Console.Write("Enter key to delete: ");
            string deleteKey = Console.ReadLine();
            DatabaseEditor.DeleteElement(database, deleteKey);
            break;
          case "3":
            Console.Write("Enter key to edit: ");
            string editKey = Console.ReadLine();
            DatabaseEditor.EditElement(database, editKey);
            break;
          case "4":
            DatabaseEditor.AddElement(database);
            break;
          case "5":
            QueryExecutor.ExecuteQueries(database);
            break;
          case "6":
            FileWriter.WriteToTextFile(database);
            break;
          case "7":
            return;
          default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
        }
      }
    }
  }
}
