using mschreiber_Software2_c969Project.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class AddNewCustomer : Form
    {
        Customer customer = new Customer();
        bool CheckForInput = false;

        public AddNewCustomer()
        {
            //I AM HAVING ISSUES WITH THE CUSTOMER ID. I CANT AUTO INCREMENT IN THE DB SO WHAT SHOULD I DO?
            //int customerID = customer.GetCustomerID();
            InitializeComponent();
            ChangeColorofButtons();

           // lbl_custID.Text = customer.ToString();
        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_Cancel);
            hoverColorChanger.Attach(btn_SaveAppointment);
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

        private void btn_SaveAppointment_Click(object sender, EventArgs e)
        {
       
            if (txt_CustFirstName.Text.Length >= 1)
            {
                CheckForInput = true;
                int customerID;
                string firstName = txt_CustFirstName.Text;
                string lastName = txt_CustLastName.Text;
                string address =  txt_Address.Text;
                string city = txt_City.Text;
                string country = txt_Country.Text;
                string phoneNumber = txt_PhoneNumber.Text.ToString();

                string message = "\nPlease Verify that the following information is accurate: "
                    + "\nName: " + firstName + " " + lastName 
                    + "\nAddress: " + address 
                    + "\nCity: " + city 
                    + "\nCountry: " + country 
                    + "\nPhone Number: " + phoneNumber;

                DialogResult result = MessageBox.Show (message, "Verify Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (result == DialogResult.Yes)
                {
                    string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string sql = "INSERT INTO customer (customerName) VALUES (@name)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                   // command.Parameters.Add("@customerId", (MySqlDbType)customerID);
                    command.Parameters.AddWithValue("@name", txt_CustFirstName.Text.Trim() + txt_CustLastName.Text.Trim());

                    //address information needs to go into the address table
                    //command.Parameters.AddWithValue("@address", txt_CustLastName.Text);
                    //command.Parameters.AddWithValue("@address", txt_Address.Text);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Customer saved successfully.");
                    this.Hide();
                }

                else
                {
                    return;
                }
            }
        }

        private void AddNewCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
