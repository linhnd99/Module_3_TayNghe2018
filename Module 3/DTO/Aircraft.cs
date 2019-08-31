using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class Aircraft
    {
        private string id;
        private string name;
        private string makeModel;
        private int totalSeats;
        private int economySeats;
        private int businessSeats;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string MakeModel { get => makeModel; set => makeModel = value; }
        public int TotalSeats { get => totalSeats; set => totalSeats = value; }
        public int EconomySeats { get => economySeats; set => economySeats = value; }
        public int BusinessSeats { get => businessSeats; set => businessSeats = value; }
    }
}
