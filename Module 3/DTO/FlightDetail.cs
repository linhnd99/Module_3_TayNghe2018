using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class FlightDetail
    {
        private string from;
        private string to;
        private DateTime date;
        private DateTime time;
        private string flightNumber;
        private double cabinPrice;
        private int numberOfStops;
        private string cabinType;
        private List<int> arrFlightNumber;
        private List<string> scheduleID;
        public FlightDetail()
        {
            ArrFlightNumber = new List<int>();
            scheduleID = new List<string>();
        }
        public FlightDetail(string from, string to, DateTime date, DateTime time, string flightnumber, double cabinprice, string cabintype, int numberofstop, List<string> scheduleid)
        {
            this.from = from;
            this.to = to;
            this.date = date;
            this.time = time;
            this.flightNumber = flightnumber;
            this.cabinPrice = cabinprice;
            this.numberOfStops = numberofstop;
            this.arrFlightNumber = new List<int>();
            this.cabinType = cabintype;
            this.ScheduleID = scheduleid;
        }

        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Time { get => time; set => time = value; }
        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public double CabinPrice { get => cabinPrice; set => cabinPrice = value; }
        public int NumberOfStops { get => numberOfStops; set => numberOfStops = value; }
        public List<int> ArrFlightNumber { get => arrFlightNumber; set => arrFlightNumber = value; }
        public string CabinType { get => cabinType; set => cabinType = value; }
        public List<string> ScheduleID { get => scheduleID; set => scheduleID = value; }

        public string FlightNumberToString()
        {
            string res = "";
            foreach (int x in arrFlightNumber)
            {
                res = res + x.ToString() + " - ";
            }
            if (res.Length > 3) res = res.Remove(res.Length - 3, 3);
            else
            {
                this.flightNumber = "";
                return "";
            }
            this.flightNumber = res;
            return res;
        }
        public int ComputeNumberStops()
        {
            this.numberOfStops = arrFlightNumber.Count;
            return this.numberOfStops;
        }
    }
}
