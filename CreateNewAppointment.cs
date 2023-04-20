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

namespace mschreiber_Software2_c969Project
{
    public partial class CreateNewAppointment : Form
    {
        public CreateNewAppointment()
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
            //initialize an array of strings to gather textbox values
            string[] newAppoinmentData = new string[6];

            newAppoinmentData[0] = txt_CustFirstName.Text;
            newAppoinmentData[1] = txt_CustLastName.Text;
            newAppoinmentData[2] = txt_Address.Text;
            newAppoinmentData[3] = txt_City.Text;
            newAppoinmentData[4] = txt_Country.Text;
            newAppoinmentData[5] = txt_PhoneNumber.Text;

            // Initialize a connection string to connect to my MySQL database
            string connectionString = "server=localhost;user id=root;database=mydatabase;password=mypassword";

            // Initialize a MySqlConnection object with the connection string;
            //  I NEED TO MAKE AN SQL CONNECTION???
            //get connection string

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Open the database connection
                conn.Open();

                // Initialize a MySqlCommand object to execute a SQL query
                MySqlCommand command = conn.CreateCommand();
                //I NEED TO CHANGE THE INSERT INTO STATEMENT TO MATCH MY TABLE
                command.CommandText = "INSERT INTO customers (first_name, last_name, email_address) VALUES (@firstName, @lastName, @email)";
                command.Parameters.AddWithValue("@firstName", newAppoinmentData[0]);
                command.Parameters.AddWithValue("@lastName", newAppoinmentData[1]);
                command.Parameters.AddWithValue("@address", newAppoinmentData[2]);
                command.Parameters.AddWithValue("@city", newAppoinmentData[3]);
                command.Parameters.AddWithValue("@country", newAppoinmentData[4]);
                command.Parameters.AddWithValue("@phone", newAppoinmentData[5]);

                // Execute the SQL query
                command.ExecuteNonQuery();

                // Close the database connection
                conn.Close();
            }
        }
    }
}
