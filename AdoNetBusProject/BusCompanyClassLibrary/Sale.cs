using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCompanyClassLibrary
{
    public class Sale
    {
        public int? ID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentID { get; set; }
    }
}
