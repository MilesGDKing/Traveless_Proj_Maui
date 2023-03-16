using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless_Proj.Data
{
    public class Flights
    {
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string DayOfWeek { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Time { get; set; }
        public string Cost { get; set; }
        public string Seats { get; set; }
        
    }

    public static class FlightFinder
    {
        public static object OriginAirport { get; private set; }
        public static object DestinationAirport { get; private set; }

        public static Flights FindFlight(string Flightcode, string Airline, string DayOfWeek, string Time, string Cost)
        {
            var filePath = "C:\\Users\\mdolp\\OneDrive\\Desktop\\Traveless_Proj\\Traveless_Proj\\Resources\\Files\\flights.csv";
            var flights = File.ReadAllLines(filePath)
                .Select(line =>
                {
                    var strings = line.Split(',');
                    return new Flights
                    {
                        FlightCode = strings[0],
                        Airline = strings[1],
                        DayOfWeek = strings[4],
                        Origin = strings[2],
                        Destination = strings[3],
                        Cost = strings[7],
                        Time = strings[5],
                        Seats= strings[6],

                    };
                });

            var flight = flights.FirstOrDefault();
              
            return flight;
        }
    }

}
