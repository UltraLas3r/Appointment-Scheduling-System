using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiber_Software2_c969Project.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public string AppointmentTitle { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public class MyAppointment : Appointment
        {
            public MyAppointment()
            {

            }

            public MyAppointment(int appointmentId, string appointmentTitle, string Type, DateTime start, DateTime end)
            {
                AppointmentID = appointmentId;
                AppointmentTitle = appointmentTitle;
                Start = start;
                End = end;
            }
        }
    }
}
