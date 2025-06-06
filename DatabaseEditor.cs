using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  public static class DatabaseEditor
  {
    public static void DeleteElement(List<Dictionary<string, string>> database, string key)
    {
      database.RemoveAll(record => record.ContainsKey("ID") && record["ID"] == key);
    }

    public static void EditElement(List<Dictionary<string, string>> database, string editKey)
    {
      var record = database.FirstOrDefault(r => r.ContainsKey("ID") && r["ID"] == editKey);
      if (record != null)
      {
        foreach (var kvp in record)
        {
          Console.Write($"{kvp.Key} ({kvp.Value}): ");
          string newValue = Console.ReadLine();
          if (!string.IsNullOrEmpty(newValue))
          {
            record[kvp.Key] = newValue;
          }
        }
      }
      else
      {
        Console.WriteLine("Element not found.");
      }
    }

    public static void AddElement(List<Dictionary<string, string>> database)
    {
      var newRecord = new Dictionary<string, string>();
      Console.Write("Enter ID: ");
      newRecord["ID"] = Console.ReadLine();
      Console.Write("Enter Store: ");
      newRecord["Store"] = Console.ReadLine();
      Console.Write("Enter District: ");
      newRecord["District"] = Console.ReadLine();
      Console.Write("Enter Address: ");
      newRecord["Address"] = Console.ReadLine();
      Console.Write("Enter Article: ");
      newRecord["Article"] = Console.ReadLine();
      Console.Write("Enter Name: ");
      newRecord["Name"] = Console.ReadLine();
      Console.Write("Enter Package Quantity: ");
      newRecord["Package Quantity"] = Console.ReadLine();
      Console.Write("Enter Customer Card Presence: ");
      newRecord["Customer Card Presence"] = Console.ReadLine();
      Console.Write("Enter Category ID: ");
      newRecord["Category ID"] = Console.ReadLine();
      Console.Write("Enter Unit of Measure: ");
      newRecord["Unit of Measure"] = Console.ReadLine();
      Console.Write("Enter Quantity in Package: ");
      newRecord["Quantity in Package"] = Console.ReadLine();
      Console.Write("Enter Price per Package: ");
      newRecord["Price per Package"] = Console.ReadLine();

      database.Add(newRecord);
    }
  }
}
