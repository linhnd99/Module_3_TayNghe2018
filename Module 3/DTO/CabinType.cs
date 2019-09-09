using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class CabinType
    {
        private string id;
        private string name;

        public CabinType(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
