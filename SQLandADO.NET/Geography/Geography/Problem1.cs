using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    public static class Problem1
    {
        public static void AllMountainPeaks(string connectionString)
        {
            string simpleQuery = @"SELECT [PeakName]
                              FROM [Geography].[dbo].[Peaks]
                              ORDER BY [PeakName]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("PeakName");
                var peaks = table.AsEnumerable().ToList();
                foreach (var p in peaks)
                {
                    Console.WriteLine(p["PeakName"].ToString());
                }
            }
        }
    }
}
