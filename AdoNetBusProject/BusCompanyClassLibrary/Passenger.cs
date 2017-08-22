using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
    public class Passenger
    {
        public int? ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal SocialNumber { get; set; }

        public int GenderID { get; set; }

        public string Phone { get; set; }
    }
}
