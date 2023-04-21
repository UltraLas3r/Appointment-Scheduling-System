using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
    public abstract class Customer<T>
    {
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustCountry { get; set; }
        public int PhoneNumber { get; set; }

        public Customer(string custFirstName, string custLastName, string custAddress, string custCity, string custCountry, int phoneNumber)
        {
            CustFirstName = custFirstName;
            CustLastName = custLastName;
            CustAddress = custAddress;
            CustCity = custCity;
            CustCountry = custCountry;
            PhoneNumber = phoneNumber;
        }
    }

    



}
