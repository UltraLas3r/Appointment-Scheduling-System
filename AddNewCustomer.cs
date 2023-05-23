using mschreiber_Software2_c969Project.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mschreiber_Software2_c969Project
{
    public partial class AddNewCustomer : Form
    {

        public AddNewCustomer()
        {
            InitializeComponent();
            ChangeColorofButtons();

            this.ActiveControl = txt_CustomerName;
        }

       
        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_Cancel);
            hoverColorChanger.Attach(btn_SaveCustomer);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
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

        private void btn_SaveNewCustomer_Click(object sender, EventArgs e)
        {
           
            string name = txt_CustomerName.Text;
            string address = txt_Address.Text;
            string addressTwo = "null";
            string city = txt_City.Text;
            string country = txt_Country.Text;
            string newPhoneNumber = txt_PhoneNumber.Text.ToString();
            string postalCode = txt_PostalCode.Text.ToString();

            if (name.Length > 0 && address.Length > 0 && city.Length > 0 && newPhoneNumber.Length > 0)
            {
                try
                {
                    

                    string message = "\nPlease Verify that the following information is accurate: "
                        + "\nName: " + name
                        + "\nAddress: " + address
                        + "\nCity: " + city
                        + "\nCountry: " + country
                        + "\nPhone Number: " + newPhoneNumber;

                    //have user verify the customer information is accurate
                    DialogResult result = MessageBox.Show(message, "Verify Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    try
                    {
                        if (result == DialogResult.Yes)
                        {

                            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
                            MySqlConnection connection = new MySqlConnection(connectionString);

                            connection.Open();

                            //Create query for country           
                            string insertCountry = "INSERT INTO country VALUES (null, @country, NOW(), 'user', NOW(), 'user')";

                            MySqlCommand insertCountryToTable = new MySqlCommand(insertCountry, connection);
                            insertCountryToTable.Parameters.AddWithValue("@country", country);
                            insertCountryToTable.ExecuteNonQuery();

                            //Create query for city
                            int countryID = (int)insertCountryToTable.LastInsertedId;
                            string insertCity = "INSERT INTO city VALUES (null, @city, @countryID, NOW(), 'user', NOW(), 'user')";

                            MySqlCommand insertCityToTable = new MySqlCommand(insertCity, connection);
                            insertCityToTable.Parameters.AddWithValue("@city", city);
                            insertCityToTable.Parameters.AddWithValue("@countryID", countryID);
                            insertCityToTable.ExecuteNonQuery();

                            //Create query for address
                            int cityID = (int)insertCityToTable.LastInsertedId;
                            string insertAddress = "INSERT INTO address VALUES (null, @address, @addressTwo, @cityID, @postal, @phone, NOW(), 'user', NOW(), 'user')";

                            MySqlCommand insertAddressToTable = new MySqlCommand(insertAddress, connection);
                            insertAddressToTable.Parameters.AddWithValue("@address", address);
                            insertAddressToTable.Parameters.AddWithValue("@addressTwo", addressTwo);
                            insertAddressToTable.Parameters.AddWithValue("@phone", newPhoneNumber);
                            insertAddressToTable.Parameters.AddWithValue("@postal", postalCode);
                            insertAddressToTable.Parameters.AddWithValue("@cityID", cityID);
                            insertAddressToTable.ExecuteNonQuery();

                            ////Create query for adding customer

                            int addressID = (int)insertAddressToTable.LastInsertedId;
                            string insertCustomer = "INSERT INTO customer VALUES (null, @name, @addressId, '1', NOW(), 'user', NOW(), 'user')";

                            MySqlCommand insertCustomerToTable = new MySqlCommand(insertCustomer, connection);
                            insertCustomerToTable.Parameters.AddWithValue("@name", name);
                            insertCustomerToTable.Parameters.AddWithValue("@addressId", addressID);
                            insertCustomerToTable.ExecuteNonQuery();

                            connection.Close();
                            this.Hide();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                            
                    }


                    if (IsValidPhoneNumber(newPhoneNumber))
                    {
                        //refresh the datagrid
                        MainHomePage mainHomePage = new MainHomePage();
                        mainHomePage.RefreshCustomerDataGrid();
                        mainHomePage.Show();
                    } 
                }

                catch
                {
                    return;
                }
            }
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            
            string pattern = @"^\d{3}-\d{3}-\d{4}$";

            // Use Regex.IsMatch to check if the phoneNumber matches the pattern
            bool isMatch = Regex.IsMatch(phoneNumber, pattern);

            return isMatch;
        }

    }
}
