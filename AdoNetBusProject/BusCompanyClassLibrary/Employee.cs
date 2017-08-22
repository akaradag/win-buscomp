using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
    public class Employee
    {
        public int? ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        public int RoleID { get; set; }

        public int CityID { get; set; }

        public int GenderID { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public bool IsAvaliable { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + "- Görevi: " + RoleID;
        }

    }
}
