using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string AddressID { get; set; }
        public int CityID { get; set; }
        public bool active { get; set; }
        public string CreatedBy { get; set; }

    }
}
