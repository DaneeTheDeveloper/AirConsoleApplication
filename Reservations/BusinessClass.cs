using System;
using System.Collections.Generic;
using ConsoleTableExt;
namespace AirConsoleApplication.Reservations
{
   public class BusinessClass
   {
     public static void BusinessClassReservation()
        {
          var tableData = new List<List<object>>
          {
            new List<object>{ "Sakura Yamamoto", "Support Engineer", "London", 46},
            new List<object>{ "Serge Baldwin", "Data Coordinator", "San Francisco", 28, "something else" },
            new List<object>{ "Shad Decker", "Regional Director", "Edinburgh"},
          };
        
           ConsoleTableBuilder
            .From(tableData)
            .ExportAndWriteLine();


        }
    }
}