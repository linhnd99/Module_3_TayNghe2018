using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.DTO
{
    class User
    {
        private string id;
        private string roleID;
        private string officeID;
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private string birthdate;
        private Boolean active;

        public string Id { get => id; set => id = value; }
        public string RoleID { get => roleID; set => roleID = value; }
        public string OfficeID { get => officeID; set => officeID = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public bool Active { get => active; set => active = value; }
    }
}
