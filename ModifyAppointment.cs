using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class ModifyAppointment : Form
    {

        public ModifyAppointment()
        {
            InitializeComponent();
            
           
        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            txt_PhoneNumber.Text = "ex: 555 555 5555";
        }
        private void txt_PhoneNumber_GotFocus(object sender, EventArgs e)
        {
            if (txt_PhoneNumber.Text == "ex: 555 555 5555")
            {
                txt_PhoneNumber.Text = "";
                txt_PhoneNumber.ForeColor = SystemColors.WindowText;
            }
        }

      

        private void btn_SaveAppointment_Click(object sender, EventArgs e)
        {
            DateTime inputDate = DT_ScheduleAppointment.Value;
            DateTime utcDate = TimeZoneInfo.ConvertTimeToUtc(inputDate);

            DateTime endDate = TimeZoneInfo.ConvertTimeToUtc(DT_ScheduleAppointment.Value.AddMinutes(30));




            if (true)
            {
                CheckForValidPhoneNumber();
            }

            else
            {

            }
        }

        public void CheckForValidPhoneNumber()
        {
            string phoneNumber = txt_PhoneNumber.Text.Trim();
            string pattern = @"^\d{10}$"; // Regular expression pattern for a 10-digit phone number

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                lbl_PhoneNumberValidation.Text = "Please enter a valid 10-digit phone number.";
                lbl_PhoneNumberValidation.Visible = true;
            }
            else
            {
                // Phone number is valid. Do something here.
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                this.Hide();
            }

            else
            {
                return;
            }
        }
    }
}
