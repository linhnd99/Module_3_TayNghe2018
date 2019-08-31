using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Schedule
    {
        private string id;
        private string date;
        private string time;
        private string aircraftID;
        private string routeID;
        private int flightNumber;
        private double economyPrice;
        private bool confirmed;

        public string Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string AircraftID { get => aircraftID; set => aircraftID = value; }
        public string RouteID { get => routeID; set => routeID = value; }
        public int FlightNumber { get => flightNumber; set => flightNumber = value; }
        public double EconomyPrice { get => economyPrice; set => economyPrice = value; }
        public bool Confirmed { get => confirmed; set => confirmed = value; }

        public Schedule(string id, string date, string time, string aircraftid, string routeid, int flightnumber, double economyprice, bool comfirmed)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            this.aircraftID = aircraftid;
            this.routeID = routeid;
            this.flightNumber = flightnumber;
            this.economyPrice = economyprice;
            this.confirmed = confirmed;
        }
    }
}
