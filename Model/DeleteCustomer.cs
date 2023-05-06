using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mschreiber_Software2_c969Project.Model
{
    public partial class DeleteCustomer : Form
    {

        //string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
        //MySqlConnection connection = new MySqlConnection(connectionString);
        //connection.Open();

        //            //Create query for country           
        //            string insertCountry = "INSERT INTO country VALUES (null, @country, NOW(), 'user', NOW(), 'user')";

        //MySqlCommand insertCountryToTable = new MySqlCommand(insertCountry, connection);
        //insertCountryToTable.Parameters.AddWithValue("@country", country);
        //            insertCountryToTable.ExecuteNonQuery();

        //            //Create query for city
        //            int countryID = (int)insertCountryToTable.LastInsertedId;
        //string insertCity = "INSERT INTO city VALUES (null, @city, @countryID, NOW(), 'user', NOW(), 'user')";

        //MySqlCommand insertCityToTable = new MySqlCommand(insertCity, connection);
        //insertCityToTable.Parameters.AddWithValue("@city", city);
        //            insertCityToTable.Parameters.AddWithValue("@countryID", countryID);
        //            insertCityToTable.ExecuteNonQuery();

        //            //Create query for address
        //            int cityID = (int)insertCityToTable.LastInsertedId;
        //string insertAddress = "INSERT INTO address VALUES (null, @address, @addressTwo, @cityID, @postal, @phone, NOW(), 'user', NOW(), 'user')";

        //MySqlCommand insertAddressToTable = new MySqlCommand(insertAddress, connection);
        //insertAddressToTable.Parameters.AddWithValue("@address", address);
        //            insertAddressToTable.Parameters.AddWithValue("@addressTwo", addressTwo);
        //            insertAddressToTable.Parameters.AddWithValue("@phone", phoneNumber);
        //            insertAddressToTable.Parameters.AddWithValue("@postal", postalCode);
        //            insertAddressToTable.Parameters.AddWithValue("@cityID", cityID);
        //            insertAddressToTable.ExecuteNonQuery();

        //            //for testing
        //            Debug.WriteLine("print: " + insertAddressToTable);

        //            ////Create query for adding customer

        //            int addressID = (int)insertAddressToTable.LastInsertedId;
        //string insertCustomer = "INSERT INTO customer VALUES (null, @name, @addressId, '1', NOW(), 'user', NOW(), 'user')";

        //MySqlCommand insertCustomerToTable = new MySqlCommand(insertCustomer, connection);
        //insertCustomerToTable.Parameters.AddWithValue("@name", name);
        //            insertCustomerToTable.Parameters.AddWithValue("@addressId", addressID);
        //            insertCustomerToTable.ExecuteNonQuery();


        //            connection.Close();
        //            MessageBox.Show(message, "Customer saved successfully.", MessageBoxButtons.OK);
        //            this.Hide();





    }
}
