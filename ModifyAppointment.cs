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
        private int _customerId;
        private string _location;
        private string _type;

        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public ModifyAppointment(int appointmentId, string title, string location, string type, DateTime start, int customerId)
        {
            InitializeComponent();




            _customerId = customerId;
             _appointmentId = appointmentId;
            _location = location;
            _type = type;


            txt_Title.Text = title;

            
            
            AddLocationsToComboBox();
            AddCustomerID();
            AddTypesToComboBox();
            DT_ScheduleAppointment.Value = start;

            this.ActiveControl = txt_Title;

        }

        private void AddCustomerID()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string queryForCustID = "SELECT customerId from customer";
            //"SELECT customerId from appointment where appointmentId = @appointmentId ";
            MySqlCommand cmd = new MySqlCommand(queryForCustID, conn);
            //cmd.Parameters.AddWithValue("@appointmentId", _appointmentId);
            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string customerID = reader["customerId"].ToString();
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
                cb_CustomerID.SelectedItem = _customerId.ToString();
                conn.Close();
            }
        }

        //private void AddLocation()
        //{
        //    MySqlConnection conn = new MySqlConnection(connString);

        //    string queryForLocation = "SELECT location from appointment where customerId = @customerId";
        //    "SELECT customerId from appointment where appointmentId = @appointmentId ";

        //    MySqlCommand cmd = new MySqlCommand(queryForLocation, conn);

        //    try
        //    {
        //        conn.Open();

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            cmd.Parameters.AddWithValue("@addressId", queryForLocation);
        //            Object location = cmd.ExecuteScalar();

        //            string locationTochange = location.ToString();
        //        }

        //        reader.Close();

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }

        //    finally
        //    {
        //        conn.Close();
        //    }
        //}





        private void AddTypesToComboBox()
        {
            string[] types = { "Lunch Meeting", "Scrum", "Synch Up" };
            cb_Choices.Items.AddRange(types);
            cb_Choices.SelectedItem = _type.ToString();
        }

        private void AddLocationsToComboBox()
        {
            string[] locations = { "Cafteria", "Boardroom A", "Lobby", "Boardroom B", "War Room" };
            cb_Location.Items.AddRange(locations);
            cb_Location.SelectedItem = _location.ToString();
        }

        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {

            string modifiedTitle = txt_Title.Text;
            string contact = "not needed";
            string selectedUser = cb_CustomerID.SelectedItem.ToString();
            string selectedType = cb_Choices.SelectedItem.ToString();
            string selectedLocation = cb_Location.SelectedItem.ToString();
            
            
            DateTime newStartDateTime = TimeZoneInfo.ConvertTimeToUtc(DT_ScheduleAppointment.Value);
            DateTime newEndDatetime = TimeZoneInfo.ConvertTimeToUtc(newStartDateTime.AddMinutes(30));

            DateTime utcStartDate = TimeZoneInfo.ConvertTimeToUtc(newStartDateTime);
            DateTime utcEndDate = TimeZoneInfo.ConvertTimeToUtc(newEndDatetime);

            //update record
            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            bool appointmentExists = CheckIfAppointmentExists(utcStartDate, utcEndDate, selectedUser);

            if (appointmentExists != true)
            {
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
                    insertAppointmentToTable.Parameters.AddWithValue("@customerId", selectedUser);
                    insertAppointmentToTable.Parameters.AddWithValue("@title", modifiedTitle);
                    insertAppointmentToTable.Parameters.AddWithValue("@location", selectedLocation);
                    insertAppointmentToTable.Parameters.AddWithValue("@contact", contact);
                    insertAppointmentToTable.Parameters.AddWithValue("@type", selectedType);
                    insertAppointmentToTable.Parameters.AddWithValue("@newstartTime", newStartDateTime);
                    insertAppointmentToTable.Parameters.AddWithValue("@NewendTime", newEndDatetime);
                    insertAppointmentToTable.Parameters.AddWithValue("@appointmentId", _appointmentId);
                    insertAppointmentToTable.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    return;
                }

                finally
                {
                    MainHomePage mainHomePage = new MainHomePage();
                    mainHomePage.Show();
                    this.Hide();
                }
            }
        }

        public bool CheckIfAppointmentExists(DateTime startOfAppointment, DateTime endOfAppointment, string selectedUser)
        {
            bool AppointmentExistence = false;

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                // Open the database connection
                connection.Open();
               
                // Create a MySqlCommand to execute the SQL query
                string query = "SELECT * FROM appointment WHERE start >= @start - INTERVAL 30 MINUTE " +
                               "AND start <= @start + INTERVAL 30 MINUTE " +
                               "AND end >= @end - INTERVAL 30 MINUTE " +
                               "AND end <= @end + INTERVAL 30 MINUTE " +
                               "AND customerId = @customerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Set the parameter values for start and end
                    command.Parameters.AddWithValue("@start", startOfAppointment);
                    command.Parameters.AddWithValue("@end", endOfAppointment);
                    command.Parameters.AddWithValue("@customerId", selectedUser);


                    // Execute the SQL query
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if any rows are returned
                        if (reader.HasRows)
                        {
                            // An appointment with the same start and end time already exists
                            MessageBox.Show("Unable to schedule an appointment during this time. There are no available consultants.", "Error");
                            AppointmentExistence = true;
                        }
                        else
                        {
                            AppointmentExistence = false;
                        }
                    }
                }
            }

            return AppointmentExistence;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                this.Hide();

                MainHomePage mainhomepage = new MainHomePage();
                mainhomepage.Show();
            }

            else
            {
                return;
            }
        }
    }
}
