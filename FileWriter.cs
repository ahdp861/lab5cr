using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{
  public static class FileWriter
  {
    public static void WriteToTextFile(List<Dictionary<string, string>> database)
    {
      using (StreamWriter writer = new StreamWriter("output.txt"))
      {
        foreach (var record in database)
        {
          foreach (var kvp in record)
          {
            writer.WriteLine($"{kvp.Key}: {kvp.Value}");
          }
          writer.WriteLine();
        }
      }
    }
  }
}
