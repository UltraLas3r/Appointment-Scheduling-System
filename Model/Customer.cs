using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
    public class Customer
    {
        public int IDCount = 9;

        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string CustCity { get; set; }
        public string CustCountry { get; set; }
        public int PhoneNumber { get; set; }

    }



}
