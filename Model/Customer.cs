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
        public int CustomerIDCount = 0;

        int CustomerID { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustCountry { get; set; }
        public int PhoneNumber { get; set; }

        public BindingList<Appointment> CustomerAndAppointment = new BindingList<Appointment>();


        //public int GetCustomerID()
        //{
        //    CustomerIDCount++;
        //    CustomerID = CustomerIDCount;

        //    //add new customerID to sql db?
            
        //}

        //public Customer(int customerId, string custFirstName, string custLastName, string custAddress, string custCity, string custCountry, int phoneNumber)
        //{
        //    CustomerID = customerId;
        //    CustFirstName = custFirstName;
        //    CustLastName = custLastName;
        //    CustAddress = custAddress;
        //    CustCity = custCity;
        //    CustCountry = custCountry;
        //    PhoneNumber = phoneNumber;
        //}
    }

    



}
