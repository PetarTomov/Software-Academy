using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    class Problem7
    {
        public static void RiversPassing(string connectionString)
        {
            string simpleQuery = @"SELECT [RiverName], 
                                COUNT([RiverId]) AS 'Countries Count'
                                FROM [Geography].[dbo].[Rivers] INNER JOIN [Geography].[dbo].[CountriesRivers]
                                ON [Geography].[dbo].[Rivers].[Id] = [Geography].[dbo].[CountriesRivers].[RiverId]
                                GROUP BY [RiverName]
                                HAVING (COUNT([RiverId])) >= 3
                                ORDER BY [RiverName]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(simpleQuery, connection);
                DataTable table = new DataTable();
                connection.Open();

                using (var rs = command.ExecuteReader())
                {
                    table.Load(rs);
                }

                Console.WriteLine("River | Countries Count ");
                var rivers = table.AsEnumerable().ToList();
                foreach (var r in rivers)
                {
                    Console.WriteLine("{0}, {1}", r["RiverName"].ToString(), r["Countries Count"].ToString());
                }
            }
        }
    }
}
