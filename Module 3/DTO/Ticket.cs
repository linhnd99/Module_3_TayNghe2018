using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Ticket
    {
        private string id;
        private string userID;
        private string scheduleID;
        private string cabinTypeID;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string passportNumber;
        private string passportCountryID;
        private string bookingReference;
        private Boolean confirmed;

        public string Id { get => id; set => id = value; }
        public string UserID { get => userID; set => userID = value; }
        public string ScheduleID { get => scheduleID; set => scheduleID = value; }
        public string CabinTypeID { get => cabinTypeID; set => cabinTypeID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string PassportNumber { get => passportNumber; set => passportNumber = value; }
        public string PassportCountryID { get => passportCountryID; set => passportCountryID = value; }
        public string BookingReference { get => bookingReference; set => bookingReference = value; }
        public bool Confirmed { get => confirmed; set => confirmed = value; }
    }
}
