using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Geography
{
    class Problem5
    {
        public static void PeaksAndMountains(string connectionString)
        {
            string simpleQuery = @"SELECT [PeakName], 
                                [MountainRange],
                                [Elevation]
                                FROM [Geography].[dbo].[Peaks] INNER JOIN [Geography].[dbo].[Mountains]
                                ON [Geography].[dbo].[Peaks].[MountainId] = [Geography].[dbo].[Mountains].[Id]
                                ORDER BY [Elevation] DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("Peak Name | Mountain | Elevation");
                var peaks = table.AsEnumerable().ToList();
                foreach (var p in peaks)
                {
                    Console.WriteLine("{0}, {1}, {2}", p["PeakName"].ToString(), p["MountainRange"].ToString(), p["Elevation"].ToString());
                }
            }
        }
    }
}
