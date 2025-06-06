using System;
using System.Collections.Generic;

namespace ConsoleApp
{
  public static class DatabaseViewer
  {
    public static void ViewDatabase(List<Dictionary<string, string>> database)
    {
      foreach (var record in database)
      {
        foreach (var kvp in record)
        {
          Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();
      }
    }
  }
}
