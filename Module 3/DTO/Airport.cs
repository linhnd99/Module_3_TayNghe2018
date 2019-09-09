using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Airport
    {
        private string id;
        private string countryID;
        private string iATACode;
        private string name;

        public Airport(string id, string countryid, string iatacode, string name)
        {
            this.id = id;
            this.countryID = countryid;
            this.iATACode = iatacode;
            this.name = name;
        }

        public string Id { get => id; set => id = value; }
        public string CountryID { get => countryID; set => countryID = value; }
        public string IATACode { get => iATACode; set => iATACode = value; }
        public string Name { get => name; set => name = value; }
    }
}
