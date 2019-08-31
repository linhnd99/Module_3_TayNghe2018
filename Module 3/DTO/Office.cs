using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Office
    {
        private string id;
        private string countryID;
        private string title;
        private string phone;
        private string contact;

        public string Id { get => id; set => id = value; }
        public string CountryID { get => countryID; set => countryID = value; }
        public string Title { get => title; set => title = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Contact { get => contact; set => contact = value; }
    }
}
