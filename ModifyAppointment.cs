using MySql.Data.MySqlClient;
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
        private int _appointmentId;

        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public ModifyAppointment(int appointmentId, string title, string location, string type, DateTime start)
        {
            InitializeComponent();

            _appointmentId = appointmentId;

            txt_Title.Text = title;
            AddLocationsToComboBox();
            AddCustomerID();
            AddTypesToComboBox();
            DT_ScheduleAppointment.Value = start;

        }

        private void AddCustomerID()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string queryForCustID = "SELECT customerID from customer";

            MySqlCommand cmd = new MySqlCommand(queryForCustID, conn);

            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string customerID = reader["CustomerID"].ToString();
                    cb_CustomerID.Items.Add(customerID);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void AddTypesToComboBox()
        {
            string[] types = { "Lunch Meeting", "Scrum", "Synch Up" };
            cb_Choices.Items.AddRange(types);
        }

        private void AddLocationsToComboBox()
        {
            string[] locations = { "Cafteria", "Boardroom A", "Lobby", "Boardroom B", "War Room" };
            cb_Location.Items.AddRange(locations);
        }

        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {




            
            string modifiedTitle = txt_Title.Text;
            string contact = "not needed";
            string selectedUser= cb_CustomerID.SelectedItem.ToString();
            string selectedType = cb_Choices.SelectedItem.ToString();
            string selectedLocation = cb_Location.SelectedItem.ToString();

            //I need to correctly convert these 
            DateTime newStartDateTime = TimeZoneInfo.ConvertTimeToUtc(DT_ScheduleAppointment.Value);
            DateTime newEndDatetime = TimeZoneInfo.ConvertTimeToUtc(newStartDateTime.AddMinutes(30));

            //best way to handle appointmentID?


            //update the database record 
            //update where appointmentId = 'appointmentIdPlaceholder' 
            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                //Create new Appointment          
                string updateAppointment = 
                    @"UPDATE appointment 
                    SET customerId = @customerId, 
                        title = @title, 
                        location = @location, 
                        contact = @contact, 
                        type = @type, 
                        start = @newStartTime, 
                        end = @newEndTime 
                    WHERE appointmentId = @appointmentId";

                MySqlCommand insertAppointmentToTable = new MySqlCommand(updateAppointment, connection);
                insertAppointmentToTable.Parameters.AddWithValue("@customerID", selectedUser);
                insertAppointmentToTable.Parameters.AddWithValue("@title", modifiedTitle);
                insertAppointmentToTable.Parameters.AddWithValue("@location", selectedLocation);
                insertAppointmentToTable.Parameters.AddWithValue("@contact", contact);
                insertAppointmentToTable.Parameters.AddWithValue("@type", selectedType);
                insertAppointmentToTable.Parameters.AddWithValue("@newstartTime", newStartDateTime);
                insertAppointmentToTable.Parameters.AddWithValue("@NewendTime", newEndDatetime);
                insertAppointmentToTable.Parameters.AddWithValue("@appointmentId", _appointmentId);
                insertAppointmentToTable.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }

            finally
            {
                MainHomePage mainHomePage = new MainHomePage();

                mainHomePage.RefreshCustomerDataGrid();
                mainHomePage.Show();
                this.Hide();
            }


        }

        
        public void CheckForValidPhoneNumber()
        {
            //todo DELETE THIS OR USE IT FOR MODIFY CUSTOMER
            //string phoneNumber = txt_PhoneNumber.Text.Trim();
            //string pattern = @"^\d{10}$"; // Regular expression pattern for a 10-digit phone number

            //if (!Regex.IsMatch(phoneNumber, pattern))
            //{
            //    lbl_PhoneNumberValidation.Text = "Please enter a valid 10-digit phone number.";
            //    lbl_PhoneNumberValidation.Visible = true;
            //}
            //else
            //{
            //    // Phone number is valid. Do something here.
            //}

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
