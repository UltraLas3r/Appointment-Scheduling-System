using System;
using mschreiber_Software2_c969Project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using mschreiber_Software2_c969Project.Model;
using System.Text.RegularExpressions;

namespace mschreiber_Software2_c969Project
{
    public partial class AddNewAppointment : Form
    {
        string connString = "server=localhost;user id=root;database=mydatabase;password=mypassword";
        public AddNewAppointment()
        {
            InitializeComponent();
            ChangeColorofButtons();
        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_SaveAppointment);
            hoverColorChanger.Attach(btn_Cancel);
        }

            private void CancelButtonClick(object sender, EventArgs e)
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

        private void SaveNewAppointment(object sender, EventArgs e)
        {
            CheckForValidPhoneNumber();

            CheckForValidAppointmentDateTime();

        
            
        }

        private void CheckForValidAppointmentDateTime()
        {
            DateTime localDateTime = DateTime.Parse(txt_Date.Text + " " + txt_Time.Text);
            DateTime utcDateTime = localDateTime.ToUniversalTime();

            //need to change sql to query the right table
            string insertQuery = "INSERT INTO appointments (appointmentDateTime) VALUES (@appointmentDateTime)";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@appointmentDateTime", utcDateTime);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment created successfully.");
                }
                else
                {
                    MessageBox.Show("Appointment creation failed.");
                }
            }


        }

        public void CheckForValidPhoneNumber()
        {
            string phoneNumber = txt_Time.Text.Trim();
            string pattern = @"^\d{10}$"; // Regular expression pattern for a 10-digit phone number

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                //lbl_PhoneNumberValidation.Text = "Please enter a valid 10-digit phone number.";
                //lbl_PhoneNumberValidation.Visible = true;
            }
            else
            {
                // Phone number is valid. Do something here.
            }

        }
    }
}
