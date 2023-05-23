﻿using mschreiber_Software2_c969Project.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class MainHomePage : Form
    {
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public MainHomePage()
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            
            InitializeComponent();
            ChangeColorofButtons();
            DGV_CustomerContentLoad();
            MainAppointmentView();
            

            string userLocation = CultureInfo.CurrentCulture.DisplayName;
            DateTime currentDateTime = DateTime.Now;
 
          
            this.ActiveControl = txt_AppointmentSearch;
        }

        public void RefreshCustomerDataGrid()
        {
            DGV_Customers.Update();
            DGV_Customers.Refresh();
        }

        public void MainAppointmentView()
        {
            
            string getAppointment = "SELECT appointmentID, title, location, type, start, end FROM appointment";
            MySqlConnection conn = new MySqlConnection(connString);

            using (MySqlCommand cmd = new MySqlCommand(getAppointment, conn))
            {
                //Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_AppointmentGrid.DataSource = dataTable;
                }
            }
        }

        

        private void ViewAppointmentsButton_Click(object sender, EventArgs e)
        {
           //this will change the DGV based on the radio button selection
        }

        private void CreateNewAppointment_Click(object sender, EventArgs e)
        {
          
            AddNewAppointment createNewAppointment = new AddNewAppointment();
            createNewAppointment.Show();
            this.Hide();
            
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
           

            if (!DGV_Customers.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected. Please select an item to modify.");
                return;
            }

            else
            {
                DataGridViewRow selectedRow = DGV_Customers.SelectedRows[0];

                int customerId = (int)selectedRow.Cells["CustomerId"].Value;
                string customerName = selectedRow.Cells["CustomerName"].Value.ToString();

                //in address table
                int addressId = (int)selectedRow.Cells["addressId"].Value;
                string address = selectedRow.Cells["address"].Value.ToString();
                string phoneNumber = selectedRow.Cells["phone"].Value.ToString();

                UpdateCustomer updateCustomer = new UpdateCustomer(customerId, customerName, addressId, address, phoneNumber);
                updateCustomer.Show();
                this.Hide();
            }    

        }

        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {
            if (!dgv_AppointmentGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected. Please select an item to modify.");
                return;
            }

            else
            {
                DataGridViewRow selectedRow = dgv_AppointmentGrid.SelectedRows[0];

                int appointmentId = (int)selectedRow.Cells["appointmentId"].Value;
                string title = selectedRow.Cells["title"].Value.ToString();
                string location = selectedRow.Cells["location"].Value.ToString();
                string type = selectedRow.Cells["type"].Value.ToString();
                DateTime start = (DateTime)selectedRow.Cells["start"].Value;
                //DateTime end = (DateTime)selectedRow.Cells["end"].Value;
               

                ModifyAppointment modifyAppointment = new ModifyAppointment(appointmentId, title, location, type, start);
                modifyAppointment.Show();
                this.Hide();
            } 
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.Show();
            this.Hide();
        }

        private void btn_SearchAppointments_Click(object sender, EventArgs e)
        {

            string searchContent = txt_AppointmentSearch.Text.Trim();
            if (string.IsNullOrEmpty(txt_AppointmentSearch.Text))
            {
                MessageBox.Show("Enter a valid search term");
                return;
            }
            else
            {
                    dgv_AppointmentGrid.Rows.Cast<DataGridViewRow>()
                    .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                    .Where(cell => cell.Value != null && cell.Value.ToString().Contains(searchContent))
                    .ToList()
                    .ForEach(cell => cell.Selected = true);
            }
            //The use of lambdas in this expression simplify the code from a
            //clumsy foreach loop to an elegant if-else statement. 
            //This code is easily read and much simpler in structure.
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pressing Enter key, so programmatically click the search button
                btn_Search.PerformClick();
                e.Handled = true; // Handle the key press event to prevent the beep sound
            }
        }




        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            //Remove entry from the appointment DGV
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && dgv_AppointmentGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_AppointmentGrid.SelectedRows[0];
                string appointmentID = selectedRow.Cells["appointmentId"].Value.ToString();

                //remove the row from the DGV
                dgv_AppointmentGrid.Rows.Remove(selectedRow);

                //delete the entry from the database
                DeleteAppointment(appointmentID);
            }
        }

        private void DeleteAppointment(string appointmentID)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string deleteQuery = "DELETE FROM appointment WHERE appointmentID = @appointmentID";
            conn.Open();

            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn);

            deleteCommand.Parameters.AddWithValue("@appointmentID", appointmentID);
            deleteCommand.ExecuteNonQuery();
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            //TODO - this needs to work CORRECTLY... currently only deleteing the DGV entry. this needs to go and remove the right stuff from the DB
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && DGV_Customers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Customers.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["CustomerId"].Value;
                //string customerName = selectedRow.Cells["customer"].Value.ToString();
                int addressId = (int)selectedRow.Cells["addressId"].Value;
                //countryID


                //remove the row from the DGV
                DGV_Customers.Rows.Remove(selectedRow);

                //remove the associated information from the database
                DeleteAllCustomerInformation(customerId, addressId);
            }
        }

        private void DeleteAllCustomerInformation(int customerId, int addressId)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            bool isReadyToRemove = false;
            bool appointmentsRemoved = false;
            int customerIdToRemove = customerId;
            int addressIdToRemove = addressId;
            
            bool cityRemoved= false;
            bool addressRemoved = false;
            bool customerRemoved = false;

            //GET CITYID
            string GetTheCityId = "SELECT cityID FROM address WHERE addressID = @addressId;";
            MySqlCommand cmd = new MySqlCommand(GetTheCityId, conn);
            cmd.Parameters.AddWithValue("@addressId", addressIdToRemove);
            Object cityId = cmd.ExecuteScalar();

            int CityIdToRemove = Convert.ToInt32(cityId.ToString());

            //GET COUNTRYID
            string GetCountryID = "SELECT countryId from city where cityId = @cityIdToRemove;";
            
            MySqlCommand GetcountryIdCmd = new MySqlCommand(GetCountryID, conn);
            
            GetcountryIdCmd.Parameters.AddWithValue("@cityIdToRemove", CityIdToRemove);

            Object countryId = GetcountryIdCmd.ExecuteScalar();
            int CountryIdToRemove = Convert.ToInt32(countryId.ToString());

            //DELETE COUNTRY FIRST

            //string countryToRemove = "DELETE FROM country WHERE countryId = @countryId "; //cityId = cityToRemove

            //MySqlCommand FirstDeleteCommand = new MySqlCommand(countryToRemove, conn);

            //FirstDeleteCommand.Parameters.AddWithValue("@countryId", CountryIdToRemove);
            //FirstDeleteCommand.ExecuteNonQuery();

            isReadyToRemove = true;

            //NEW CODE HERE!!

            if (isReadyToRemove == true)
            {
                string deleteAppointmentQuery = "DELETE FROM appointment WHERE customerId = @custId";

                MySqlCommand SecondDeleteCommand = new MySqlCommand(deleteAppointmentQuery, conn);

                SecondDeleteCommand.Parameters.AddWithValue("@custId", customerIdToRemove);
                SecondDeleteCommand.ExecuteNonQuery();
                appointmentsRemoved = true;

            }

         

            if (appointmentsRemoved == true)
            {
                string deleteCustomerQuery = "DELETE FROM customer WHERE CustomerId = @customerId";

                MySqlCommand DeleteCustomerCommand = new MySqlCommand(deleteCustomerQuery, conn);

                DeleteCustomerCommand.Parameters.AddWithValue("@customerId", customerIdToRemove);
                DeleteCustomerCommand.ExecuteNonQuery();
                customerRemoved = true;
            }

            if (customerRemoved = true)
            {
                string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId";

                MySqlCommand SecondDeleteCommand = new MySqlCommand(deleteAddressQuery, conn);

                SecondDeleteCommand.Parameters.AddWithValue("@addressId", addressIdToRemove);
                SecondDeleteCommand.ExecuteNonQuery();
                addressRemoved = true;

            }

            else if (appointmentsRemoved == true)
            {
                MessageBox.Show("The customer " + customerIdToRemove + " has been removed and all records scrubbed from the database");
                conn.Close();
            }

        }

        private void rb_ViewAll_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT appointmentID, title, location, type, start, end FROM appointment";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                //Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_AppointmentGrid.DataSource = dataTable;
                }
            }
        }
        private void ViewThisWeekRadioButton(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT title, location, type, start, end FROM appointment WHERE start BETWEEN DATE_sub(CURDATE(), INTERVAL 7 DAY) AND CURDATE()";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                //Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_AppointmentGrid.DataSource = dataTable;
                }
            }
        }
        private void ViewThisMonthRadioButton(object sender, EventArgs e)
        {     
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT title, description, location, type, start, end FROM appointment WHERE start >= DATE_SUB(NOW(), INTERVAL 30 DAY);";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                //Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_AppointmentGrid.DataSource = dataTable;
                }
            }
        }
        public void DGV_CustomerContentLoad()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            //string query = "SELECT customer.customerId, customer.customerName, appointment.title, appointment.description, appointment.type, appointment.start, appointment.end FROM appointment INNER JOIN customer ON customer.customerId = appointment.customerID";
            string queryForCustomerOnly = "SELECT customer.CustomerId, customer.CustomerName, address.addressId, address.address, address.phone From address INNER JOIN customer on Customer.addressId = address.addressID;";

            using (MySqlCommand cmd = new MySqlCommand(queryForCustomerOnly, conn))
            {
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGV_Customers.DataSource = dataTable;
                }
            }
        }
      
        private void btn_GetCustomerInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT customer.customerId, customer.customerName, appointment.title, appointment.description, appointment.type, appointment.start, appointment.end FROM appointment INNER JOIN customer ON customer.customerId = appointment.customerID";
            
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGV_Customers.DataSource = dataTable;
                }
            }
        }

        private void btn_AllCustomers_Click(object sender, EventArgs e)
        {
            DGV_CustomerContentLoad();
        }

        private void GenerateMonthlyReport(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string MonthlyReportQuery = "SELECT title, location, type, start, end FROM appointment WHERE start BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 30 DAY);";

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(MonthlyReportQuery, conn))
                
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_Reports.DataSource = dataTable;
                }
                
            }

            catch
            {
                MessageBox.Show("Error: Restart Program");
            }

            finally
            {
                conn.Close();
            }
        }

        private void GenerateConsultantReport(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string ConsultantReport = "SELECT * FROM user";

             try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(ConsultantReport, conn))
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_Reports.DataSource = dataTable;
                }
            }

            catch
            {
                MessageBox.Show("Error: Restart Program");
            }

            finally
            {
                conn.Close();
            }
        }

        private void GenerateCustomerList(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            
            string CustomerInformationReport = 
                "SELECT customer.customerName, address.address, address.phone FROM customer INNER JOIN address WHERE customer.addressID = address.addressID;";

            try
            { 
                using (MySqlCommand cmd = new MySqlCommand(CustomerInformationReport, conn))
                
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_Reports.DataSource = dataTable;
                }  
            }
            catch
            {
                MessageBox.Show("Error: Restart Program");
            }

            finally
            {
                conn.Close();
            }
        }

        private void MainHomePageExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ChangeColorofButtons()
        {
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_AddCustomer);
            hoverColorChanger.Attach(btn_ModifyCustomer);
            hoverColorChanger.Attach(btn_AddNewAppointment);
            hoverColorChanger.Attach(btn_DeleteAppointment);
            hoverColorChanger.Attach(btn_ModifyAppointment);
            hoverColorChanger.Attach(btn_Exit);
        }
    }
}
