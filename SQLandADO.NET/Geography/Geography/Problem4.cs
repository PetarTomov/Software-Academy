using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    class Problem4
    {
        public static void ThreeAsInCountryName(string connectionString)
        {
            string simpleQuery = @"SELECT [CountryName], 
                                [IsoCode]
                                FROM [Geography].[dbo].[Countries]
                                WHERE LEN([CountryName]) - LEN(REPLACE([CountryName], 'A', '')) >= 3 
                                ORDER BY [IsoCode]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("Country Name | ISO Code");
                var countries = table.AsEnumerable().ToList();
                foreach (var c in countries)
                {
                    Console.WriteLine("{0}, {1}", c["CountryName"].ToString(), c["IsoCode"].ToString());
                }
            }
        }
    }
}
