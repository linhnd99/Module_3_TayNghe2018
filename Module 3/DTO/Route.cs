using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Route
    {
        private string id;
        private string departureAirportID;
        private string arrivalAirportID;
        private double distance;
        private string flightTime;

        public string Id { get => id; set => id = value; }
        public string DepartureAirportID { get => departureAirportID; set => departureAirportID = value; }
        public string ArrivalAirportID { get => arrivalAirportID; set => arrivalAirportID = value; }
        public double Distance { get => distance; set => distance = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
    }
}
