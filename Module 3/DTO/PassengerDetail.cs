using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class PassengerDetail
    {
        private string ticketID;
        private string userID;
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private string passportNumber;
        private string passportCountryID;
        private string phone;

        public string TicketID { get => ticketID; set => ticketID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string PassportNumber { get => passportNumber; set => passportNumber = value; }
        public string PassportCountryID { get => passportCountryID; set => passportCountryID = value; }
        public string Phone { get => phone; set => phone = value; }

        public PassengerDetail(string ticketid, string userid, string firstname, string lastname, DateTime birthdate, string passportnumber, string passportcountryid, string phone)
        {
            this.ticketID = ticketid;
            this.userID = userid;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.passportCountryID = passportcountryid;
            this.passportNumber = passportnumber;
            this.phone = phone;
        }
        public PassengerDetail()
        {

        }
    }
}
