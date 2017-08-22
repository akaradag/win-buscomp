using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
   public class Bus
    {
        public int? ID { get; set; }
        public int ModelID { get; set; }
        public int TypeID { get; set; }
        public int SeatCount { get; set; }
        public bool IsAvaliable { get; set; }
    }
}
