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
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        
        public AddNewAppointment()
        {
            InitializeComponent();
            ChangeColorofButtons();
            LoadCustomerComboBox();
            
            string[] choices = { "Lunch Meeting", "Scrum", "Synch Up" };
            cb_Choices.Items.AddRange(choices);

            string[] locations = { "Cafteria", "Boardroom A", "Lobby", "Boardroom B", "War Room" };
            cb_Location.Items.AddRange(locations);

            this.ActiveControl = txt_Title;
        }

        private void LoadCustomerComboBox()
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

        private void SaveNewAppointment(object sender, EventArgs e)
        { 
            string contact = "not needed";
            string title = txt_Title.Text;
            string selectedChoice = cb_Choices.SelectedItem.ToString();
            string selectedLocation = cb_Location.SelectedItem.ToString();
            string selectedCustomerId = cb_CustomerID.SelectedItem.ToString();
            
            DateTime inputDate = DT_ScheduleAppointment.Value;
            DateTime utcStartDate = TimeZoneInfo.ConvertTimeToUtc(inputDate);

            DateTime utcEndDate = TimeZoneInfo.ConvertTimeToUtc(DT_ScheduleAppointment.Value.AddMinutes(30));

            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //get customerID
            string GetCustomerId = "SELECT customerId FROM customer WHERE customerId = @custID;";
            MySqlCommand cmd = new MySqlCommand(GetCustomerId, connection);
            cmd.Parameters.AddWithValue("@custID", selectedCustomerId);
            Object custId = cmd.ExecuteScalar();
            
            try
            {
                //Create new Appointment          
                string insertAppointment = "INSERT INTO appointment VALUES(null, @customerID, '1', @title, description, @location, @contact, @type, url, @startTime, @endTime, NOW(), 'user', NOW(), 'user')";

                MySqlCommand insertAppointmentToTable = new MySqlCommand(insertAppointment, connection);
                insertAppointmentToTable.Parameters.AddWithValue("@customerID", custId);
                insertAppointmentToTable.Parameters.AddWithValue("@title", title);
                insertAppointmentToTable.Parameters.AddWithValue("@location", selectedLocation);
                insertAppointmentToTable.Parameters.AddWithValue("@contact", contact);
                insertAppointmentToTable.Parameters.AddWithValue("@type", selectedChoice);
                insertAppointmentToTable.Parameters.AddWithValue("@startTime", utcStartDate);
                insertAppointmentToTable.Parameters.AddWithValue("@endTime", utcEndDate);
                insertAppointmentToTable.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
        public DateTime ConvertToUtc(string inputDate)
        {
            DateTime date = DateTime.Parse(inputDate);
            DateTime utcDate = date.ToUniversalTime();
            return utcDate;
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
                MainHomePage mainHomePage = new MainHomePage();
                this.Hide();

                mainHomePage.Show();
            }

            else
            {
                return;
            }
        }

        
    }
}
