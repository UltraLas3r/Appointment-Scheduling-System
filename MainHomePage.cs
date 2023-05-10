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

namespace mschreiber_Software2_c969Project
{
    public partial class MainHomePage : Form
    {
        
        DataTable appointmentList = new DataTable();
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public MainHomePage()
        {
            InitializeComponent();
            ChangeColorofButtons();
            CheckForUpcoming();
            DGV_CustomerContentLoad();
            FirstAppointmentView();
          

            //get localization data
            string userLocation = CultureInfo.CurrentCulture.DisplayName;
            //get the current date and time 
            DateTime currentDateTime = DateTime.Now;
          

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            this.ActiveControl = txt_AppointmentSearch;

        }

        public void RefreshCustomerDataGrid()
        {
            DGV_Customers.Update();
            DGV_Customers.Refresh();
        }

        public void FirstAppointmentView()
        {
            //todo this isnt loading right?
            string getAppointment = "SELECT title, location, type, start, end FROM appointment";

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



        private void MainHomePage_Load(object sender, EventArgs e)
        {
            //todo possibly turn this into a try/catch 
            bool upcomingMeeting = false;

            if (upcomingMeeting == true)
            {
                UpcomingAlert upcoming = new UpcomingAlert();
                upcoming.Show();
            }

            else
            {
                return;
            }

            //if there is an appointment that exists within 15 minutes of the user's
            //computer time, display a warning popup that has the appointment info
            MySqlConnection conn = new MySqlConnection(connString);
            string getAppointment = "SELECT * FROM appointment WHERE start BETWEEN NOW() AND DATE_ADD(NOW(), INTERVAL 15 MINUTE);"; 
            MySqlCommand cmd = new MySqlCommand(getAppointment, conn);

        }

        private void CheckForUpcoming()
        {
            //check for upcoming appointments in the database, if they exist within 15 minutes of the current time
            // open the UpcomingAlert window

        }
        private void ViewAppointmentsButton_Click(object sender, EventArgs e)
        {
           //this will change the DGV based on the radio button selection
        }

        private void CreateNewAppointment_Click(object sender, EventArgs e)
        {
            //open the createnewappointment screen
            AddNewAppointment createNewAppointment = new AddNewAppointment();
            createNewAppointment.Show();
            this.Hide();
            
        }
        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {
            ModifyAppointment modifyAppointment = new ModifyAppointment();


            if (!dgv_AppointmentGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected. Please select an item to modify.");
                return;
            }

            else
            {
                var tempAppointment = (Appointment)dgv_AppointmentGrid.CurrentRow.DataBoundItem;

                //modifyAppointment modifyAppointment = new modifyAppointment(tempAppointment, appointmentID);
                //modifyAppointment.Show();

                this.Visible = false;
            } 
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.Show();
            this.Hide();
        }
    
        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
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

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            //Remove entry from the appointment DGV
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv_AppointmentGrid.SelectedRows)
                {
                    dgv_AppointmentGrid.Rows.RemoveAt(row.Index);
                }
            }
        }
        private void rb_ViewAll_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT title, location, type, start, end FROM appointment";

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
            string queryForCustomerOnly = "SELECT customer.CustomerName, address.address, address.phone From address INNER JOIN customer on Customer.addressId = address.addressID;";

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

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DGV_Customers.SelectedRows)
                {
                    DGV_Customers.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btn_ref_Click(object sender, EventArgs e)
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
    }
}
