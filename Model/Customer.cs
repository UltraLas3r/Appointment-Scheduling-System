using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }

        
    }

    public class MyCustomer : Customer
    {
        
        public MyCustomer(string name, string address, string addressTwo, string city, string country, string phoneNumber, string postalCode)
        {
            Name = name;
            Address = address;
            AddressTwo = addressTwo;
            City = city;
            Country = country;
            PhoneNumber = phoneNumber;
            PostalCode = postalCode;
        }
    }
}
