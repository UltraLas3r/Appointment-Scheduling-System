using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
    public abstract class Appointment
    {
        public string Appt_FirstName { get; set; }
        public string Appt_LastName { get; set; }
        public string Appt_Address { get; set; }
        public string Appt_City { get; set; }
        public string Appt_Country { get; set; }
        public int Appt_PhoneNumber { get; set; }

        public BindingList<Appointment> Appointments = new BindingList<Appointment>();

        public Appointment(string appt_FirstName, string appt_LastName, string appt_Address, string appt_City, string appt_Country, int phoneNumber)
        {
            Appt_FirstName = appt_FirstName;
            Appt_LastName = appt_LastName;
            Appt_Address = appt_Address;
            Appt_City = appt_City;
            Appt_Country = appt_Country;
            Appt_PhoneNumber = phoneNumber;
        }

        //public void ScheduleAppointment();
        public abstract void RescheduleAppointment();
        public abstract void Cancel();
    }


}

