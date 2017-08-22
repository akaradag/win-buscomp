using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
    public class Ticket
    {
        public int? ID { get; set; }
        public int PassengerID { get; set; }
        public int EmployeeID { get; set; }
        public int SeatNumber { get; set; }
        public int TripID { get; set; }
        public decimal Price { get; set; }
        public int StartCityID { get; set; }
        public int EndCityID { get; set; }
    }
}
