using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Geography
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1.AllMountainPeaks(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem2.BiggestCountry(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem3.CountriesAndCurrency(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem4.ThreeAsInCountryName(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem5.PeaksAndMountains(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem6.PeaksWMountainCountryContinent(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            //Problem7.RiversPassing(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            Console.ReadKey();
        }
    }
}
