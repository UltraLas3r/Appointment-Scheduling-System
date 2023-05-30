using mschreiber_Software2_c969Project.Model;
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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

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

            DGV_Customers.MultiSelect = false;
            dgv_AppointmentGrid.MultiSelect = false;


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
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Convert UTC datetime values to local time
                    foreach (DataRow row in dataTable.Rows)
                    {
                        DateTime startUtc = (DateTime)row["start"];
                        DateTime endUtc = (DateTime)row["end"];

                        DateTime startLocal = startUtc.ToLocalTime();
                        DateTime endLocal = endUtc.ToLocalTime();

                        row["start"] = startLocal;
                        row["end"] = endLocal;
                    }

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

            if (dgv_AppointmentGrid.RowCount == 0)
            {
                lbl_NoMatch.Visible = true;
            }

            if (string.IsNullOrEmpty(txt_AppointmentSearch.Text))
            {
                MessageBox.Show("No match found, please enter a valid search term");
                return;
            }

            else if (searchContent.Length > 0)
            {
                bool cellContainsSearchTerm = false;

                foreach (DataGridViewRow row in dgv_AppointmentGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchContent))
                        {
                            cellContainsSearchTerm = true;
                            cell.Selected = true;
                            break;
                        }
                    }
                }

                if (cellContainsSearchTerm == false)
                {

                    lbl_NoMatch.Visible = true;
                    return;
                }

                lbl_NoMatch.Visible = false;
                dgv_AppointmentGrid.Rows.Cast<DataGridViewRow>()
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .Where(cell => cell.Value != null && cell.Value.ToString().Contains(searchContent))
                .ToList()
                .ForEach(cell => cell.Selected = true);
                //The use of lambdas in this expression simplify the code from a
                //clumsy foreach loop to an elegant if-else statement. 
                //This code is easily read and much simpler in structure.
            }

        }

        private void AppointmentSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && DGV_Customers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Customers.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["CustomerId"].Value;
                //string customerName = selectedRow.Cells["customer"].Value.ToString();
                int addressId = (int)selectedRow.Cells["addressId"].Value;

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
            int countryIdToRemove = Convert.ToInt32(countryId.ToString());
            isReadyToRemove = true;

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

            if (customerRemoved == true)
            {
                string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId";

                MySqlCommand SecondDeleteCommand = new MySqlCommand(deleteAddressQuery, conn);

                SecondDeleteCommand.Parameters.AddWithValue("@addressId", addressIdToRemove);
                SecondDeleteCommand.ExecuteNonQuery();
                addressRemoved = true;
            }

            if (addressRemoved == true)
            {
                
                //delete city
                string deleteCityQuery = "DELETE FROM city WHERE cityId = @cityID ";

                MySqlCommand DeleteCityCommand = new MySqlCommand(deleteCityQuery, conn);

                DeleteCityCommand.Parameters.AddWithValue("@cityID", CityIdToRemove);
                DeleteCityCommand.ExecuteNonQuery();
                cityRemoved = true;
            }

            if (customerRemoved == true)
            {
                //delete country input
                string deleteCountryQuery = "DELETE FROM country WHERE countryId = @countryID ";

                MySqlCommand DeleteCountryCommand = new MySqlCommand(deleteCountryQuery, conn);

                DeleteCountryCommand.Parameters.AddWithValue("@countryID", countryIdToRemove);
                DeleteCountryCommand .ExecuteNonQuery();
                
            }

            if (appointmentsRemoved == true)
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
            //TODO verify this is working properly
            string query = "SELECT title, location, type, start, end FROM appointment WHERE start >= curdate() AND start <= curdate() + INTERVAL 7 DAY;";

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

            //TODO Verify that this funcionality is working correctly
            string query = "SELECT title, description, location, type, start, end FROM appointment WHERE start <= DATE_ADD(CURDATE(), INTERVAL 30 DAY);" ;

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
            DGV_Customers.ClearSelection();
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

        public class MyAppointment : Appointment
        {


        }

        private void GenerateMonthlyReport(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string MonthlyReportQuery = "SELECT appointmentId, title, location, type, start, end FROM appointment WHERE start BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 30 DAY);";

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(MonthlyReportQuery, conn))
                
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    List<Appointment> appointmentList = new List<Appointment>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Appointment appointment = new MyAppointment();

                        appointment.AppointmentID = (int)row["appointmentId"];
                        appointment.AppointmentTitle = row["title"].ToString();
                        appointment.Start = (DateTime)row["start"];
                        appointment.End= (DateTime)row["end"];

                        appointmentList.Add(appointment);
                    }

                    // Clear existing label text
                    lbl_1.Text = "";
                    lbl_2.Text = "";
                    lbl_3.Text = "";
                    lbl_4.Text = "";
                    lbl_CustName.Text = "";
                    lbl_CustAddress.Text = "";
                    lbl_CustPhoneNumber.Text = "";

                    foreach (Appointment appointment in appointmentList)
                    {
                        lbl_1.Text += "ID NUM: " + appointment.AppointmentID + "\n";
                        lbl_2.Text += "TITLE: "+ appointment.AppointmentTitle + "\n";
                        lbl_3.Text += "START: " + appointment.Start + "\n";
                        lbl_4.Text += "END: " + appointment.End;
                    }
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
            string ConsultantReport = "SELECT user.userid, user.username, appointment.title, appointment.start, appointment.end FROM appointment INNER JOIN user WHERE user.userid = appointment.userid;";

            DGV_Customers.Visible = true;

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

        public class MyCustomer : Customer
        {
           

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

                    List<Customer> customerList = new List<Customer>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Customer customer = new MyCustomer();
                        
                        customer.Name = row["customerName"].ToString();
                        customer.Address = row["address"].ToString();
                        customer.PhoneNumber = row["phone"].ToString();

                        customerList.Add(customer);
                    }

                    // Clear existing label text and hide DGV
                    lbl_CustName.Text = "";
                    lbl_CustAddress.Text = "";
                    lbl_CustPhoneNumber.Text = "";
                    lbl_1.Text = "";
                    lbl_2.Text = "";
                    lbl_3.Text = "";
                    lbl_4.Text = "";
                    DGV_Customers.Visible = false;

                    foreach (Customer customer in customerList)
                    {
                        lbl_CustName.Text += "NAME: " + customer.Name + "\n";
                        lbl_CustAddress.Text += "ADDRESS: " + customer.Address + "\n";
                        lbl_CustPhoneNumber.Text += "PHONE: " + customer.PhoneNumber + "\n";
                    }

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

        private void btn_CustSearch_Click(object sender, EventArgs e)
        {
            
            string custSearch = tb_CustSearch.Text.Trim();

            if (DGV_Customers.SelectedRows.Count == 0)
            {
                label3.Visible = true;
            }

            if (string.IsNullOrEmpty(tb_CustSearch.Text))
            {
                MessageBox.Show("No match found, please enter a valid search term");
                return;
            }

            else if (custSearch.Length > 0)
            {
                bool cellContainsSearchTerm = false;
                
                foreach (DataGridViewRow row in DGV_Customers.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(custSearch))
                        {
                            cellContainsSearchTerm = true;
                            cell.Selected = true;
                            break;
                        }
                    }
                }

                if (cellContainsSearchTerm == false)
                {

                    label3.Visible = true;
                    return;

                }

                label3.Visible = false;
                DGV_Customers.Rows.Cast<DataGridViewRow>()
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .Where(cell => cell.Value != null && cell.Value.ToString().Contains(custSearch))
                .ToList()
                .ForEach(cell => cell.Selected = true);
                //The use of lambdas in this expression simplify the code from a
                //clumsy foreach loop to an elegant if-else statement. 
                //This code is easily read and much simpler in structure.
            }
        }

        private void tb_CustSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pressing Enter key, so programmatically click the search button
                btn_CustSearch.PerformClick();
                e.Handled = true; // Handle the key press event to prevent the beep sound
            }
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
        private void MainHomePageExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
