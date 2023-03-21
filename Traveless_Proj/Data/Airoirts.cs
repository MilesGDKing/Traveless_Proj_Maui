using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless_Proj.Data
{
    public class Airports
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
    }

    public static class AirportFinder
    {
        public static List<Airports> GetAirports()
        {
            var airports = new List<Airports>();
            var filePath = "C:\\Users\\hesed\\OneDrive\\Desktop\\Traveless_Proj\\Traveless_Proj\\Resources\\Files\\airports.csv";
            var lines = System.IO.File.ReadAllLines(filePath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string airportCode = parts[0];
                string airportName = parts[1];

                airports.Add(new Airports { AirportCode = airportCode, AirportName = airportName });
            }

            return airports;
        }
    }
}