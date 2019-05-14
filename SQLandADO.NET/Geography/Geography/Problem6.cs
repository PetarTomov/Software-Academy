using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Geography
{
    class Problem6
    {
        public static void PeaksWMountainCountryContinent(string connectionString)
        {
            string simpleQuery = @"SELECT [PeakName], 
                                [MountainRange],
                                [CountryName],
                                [ContinentName]
                                FROM [Geography].[dbo].[Peaks] INNER JOIN [Geography].[dbo].[Mountains]
                                ON [Geography].[dbo].[Peaks].[MountainId] = [Geography].[dbo].[Mountains].[Id]
                                INNER JOIN [Geography].[dbo].[MountainsCountries]
                                ON [Geography].[dbo].[MountainsCountries].[MountainId] = [Geography].[dbo].[Mountains].[Id]
                                INNER JOIN [Geography].[dbo].[Countries]
                                ON [Geography].[dbo].[Countries].[CountryCode] = [Geography].[dbo].[MountainsCountries].[CountryCode]
                                INNER JOIN [Geography].[dbo].[Continents]
                                ON [Geography].[dbo].[Continents].[ContinentCode] = [Geography].[dbo].[Countries].[ContinentCode]
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

                Console.WriteLine("Peak Name | Mountain | Country Name | Continent Name");
                var peaks = table.AsEnumerable().ToList();
                foreach (var p in peaks)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", p["PeakName"].ToString(), 
                        p["MountainRange"].ToString(), p["CountryName"].ToString(), p["ContinentName"]);
                }
            }
        }
    }
}
