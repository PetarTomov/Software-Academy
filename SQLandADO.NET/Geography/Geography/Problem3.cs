using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    class Problem3
    {
        public static void CountriesAndCurrency(string connectionString)
        {
            string simpleQuery = @"SELECT [CountryName], 
                                [CountryCode],
                                CASE [CurrencyCode]
                                    WHEN 'EUR' THEN 'Euro'
                                    ELSE 'Not Euro'
                                END AS [Currency] 
                                FROM [Geography].[dbo].[Countries]
                                ORDER BY [CountryName]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("Country Name | Country Code | Currency");
                var countries = table.AsEnumerable().ToList();
                foreach (var c in countries)
                {
                    Console.WriteLine("{0}, {1}, {2}", c["CountryName"].ToString(), c["CountryCode"].ToString(), c["Currency"].ToString());
                }
            }
        }
    }
}
