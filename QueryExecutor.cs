using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  public static class QueryExecutor
  {
    public static void ExecuteQueries(List<Dictionary<string, string>> database)
    {
      var query1 = database.Where(record => record.ContainsKey("Category") && record["Category"] == "Radio-controlled toys 12+")
        .Sum(record => int.Parse(record["Package Quantity"]) * int.Parse(record["Price per Package"]));
      Console.WriteLine($"Total cost of children's goods from the category «Radio-controlled toys 12+»: {query1}");
    }
  }
}
