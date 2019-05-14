using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    class Problem2
    {
        public static void BiggestCountry(string connectionString)
        {
            string simpleQuery = @"SELECT TOP 30 [CountryName], 
                              [Population]
                              FROM [Geography].[dbo].[Countries]
                              WHERE [ContinentCode] = 'EU'
                              ORDER BY [Population] DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("Country Name | Population");
                var countries = table.AsEnumerable().ToList();
                foreach (var c in countries)
                {
                    Console.WriteLine("{0}, {1}", c["CountryName"].ToString(), c["Population"]);
                }
            }
        }
    }
}
