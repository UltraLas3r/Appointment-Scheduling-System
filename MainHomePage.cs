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

        }

        public void FirstAppointmentView()
        {
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
            //if there is an appointment that exists within 15 minutes of the user's
            //computer time, display a warning popup that has the appointment info
            ////take data from the database and display in dgv
            MySqlConnection conn = new MySqlConnection(connString);

            string getAppointment = "SELECT title, location, type, start, end FROM appointment"; 
            MySqlCommand cmd = new MySqlCommand(getAppointment, conn);

            //finally, create a copy of the datatable form MySQL to put into the DGV
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);

            DataTable AppointmentsMainGrid = new DataTable();
            adpt.Fill(AppointmentsMainGrid);

           
            //point datagridview to the data source
            dgv_AppointmentGrid.DataSource = appointmentList;
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
            createNewAppointment.Location = new Point(btn_AddNewAppointment.Right, btn_AddNewAppointment.Top);
            
        }
        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {
            ModifyAppointment modifyAppointment = new ModifyAppointment();       
            modifyAppointment.Show();
            modifyAppointment.Location = new Point(btn_ModifyAppointment.Right, btn_ModifyAppointment.Top);
        }

      

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.Show();
        }
    
        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            //Remove entry from the appointment DGV
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

            string query = "SELECT title, location, type, start, end FROM appointment WHERE start < UTC_TIMESTAMP()-30";

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

            string query = "SELECT * FROM customer";

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
        private void MainHomePageExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ChangeColorofButtons()
        {
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_AddCustomer);
            hoverColorChanger.Attach(btn_UpdateCustomer);
            hoverColorChanger.Attach(btn_AddNewAppointment);
            hoverColorChanger.Attach(btn_DeleteAppointment);
            hoverColorChanger.Attach(btn_ModifyAppointment);
            hoverColorChanger.Attach(btn_Exit);
        }

      
    }
}
