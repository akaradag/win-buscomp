using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
    public class TripDetails
    {
        public int TripID { get; set; }
        public int RouteID { get; set; }
        public int HourID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PredictedTime { get; set; }
        public Trip Trip { get; set; }
        public Route Route { get; set; }
    }
}
