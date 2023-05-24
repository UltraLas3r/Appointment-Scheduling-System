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
    public partial class UpdateCustomer : Form
    {
        private int _customerId;
        private int _addressId;

        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public UpdateCustomer(int customerId, string customerName, int addressId, string address, string phoneNumber)
        {
            InitializeComponent();
            _addressId = addressId;
            _customerId = customerId;
            txt_CustFullName.Text = customerName;
            txt_Address.Text = address;
            txt_PhoneNumber.Text = phoneNumber;

            this.ActiveControl = txt_CustFullName;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Hide();
                MainHomePage mainHomePage = new MainHomePage();
                mainHomePage.Show();

            }

            else
            {
                return;
            }
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            string modifiedCustomerName = txt_CustFullName.Text;
            string modifiedAddress = txt_Address.Text;
            string modifiedPhoneNumber = txt_PhoneNumber.Text;

            //update records in the DB
            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            try
            {
                //sql update statement for address 
                string updateAddress =
                    @"UPDATE address
                    SET address = @newAddress,
                        phone = @newPhone
                    WHERE 
                        addressId = @newAddressId;";

                MySqlCommand updateAddressTable = new MySqlCommand(updateAddress, conn);
                    updateAddressTable.Parameters.AddWithValue("@newAddress", modifiedAddress);
                    updateAddressTable.Parameters.AddWithValue("@newPhone", modifiedPhoneNumber);
                    updateAddressTable.Parameters.AddWithValue("@newAddressId", _addressId);
                updateAddressTable.ExecuteNonQuery();

                //sql update statement for customer 
                string updateCustomer =
                    @"UPDATE customer
                    SET customerName = @newName
                    WHERE 
                        addressId = @newAddressId;";
                MySqlCommand updateCustomerTable = new MySqlCommand(updateCustomer, conn);
                updateCustomerTable.Parameters.AddWithValue("@newName", modifiedCustomerName);
                updateCustomerTable.Parameters.AddWithValue("@newAddressId", _addressId);
                updateCustomerTable.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            finally
            {
                if (IsValidPhoneNumber(modifiedPhoneNumber))
                {
                    MainHomePage mainHomePage = new MainHomePage();
                    mainHomePage.Show();
                    this.Hide();
                }
                else
                {
                    lbl_PhoneNumberValidation.Visible = true;
                    this.ActiveControl = txt_PhoneNumber;
                }
            }
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{3}-\d{3}-\d{4}$"; 
            bool isMatch = Regex.IsMatch(phoneNumber, pattern);

            return isMatch;
        }



    }
}
