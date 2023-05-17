using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mschreiber_Software2_c969Project.Model
{

    //TODO this may not be necessary.


    internal class DBQuery
    {
        public void AddNewCustomer(string name, string address, string addressTwo, string city, string country, string phoneNumber, string postalCode, object connection)
        {
            //Create query for country           
            string insertCountry = "INSERT INTO country VALUES (null, @country, NOW(), 'user', NOW(), 'user')";

            MySqlCommand insertCountryToTable = new MySqlCommand(insertCountry, (MySqlConnection)connection);
            insertCountryToTable.Parameters.AddWithValue("@country", country);
            insertCountryToTable.ExecuteNonQuery();

            //Create query for city
            int countryID = (int)insertCountryToTable.LastInsertedId;
            string insertCity = "INSERT INTO city VALUES (null, @city, @countryID, NOW(), 'user', NOW(), 'user')";

            MySqlCommand insertCityToTable = new MySqlCommand(insertCity, (MySqlConnection)connection);
            insertCityToTable.Parameters.AddWithValue("@city", city);
            insertCityToTable.Parameters.AddWithValue("@countryID", countryID);
            insertCityToTable.ExecuteNonQuery();

            //Create query for address
            int cityID = (int)insertCityToTable.LastInsertedId;
            string insertAddress = "INSERT INTO address VALUES (null, @address, @addressTwo, @cityID, @postal, @phone, NOW(), 'user', NOW(), 'user')";

            MySqlCommand insertAddressToTable = new MySqlCommand(insertAddress, (MySqlConnection)connection);
            insertAddressToTable.Parameters.AddWithValue("@address", address);
            insertAddressToTable.Parameters.AddWithValue("@addressTwo", addressTwo);
            insertAddressToTable.Parameters.AddWithValue("@phone", phoneNumber);
            insertAddressToTable.Parameters.AddWithValue("@postal", postalCode);
            insertAddressToTable.Parameters.AddWithValue("@cityID", cityID);
            insertAddressToTable.ExecuteNonQuery();

            ////Create query for adding customer

            int addressID = (int)insertAddressToTable.LastInsertedId;
            string insertCustomer = "INSERT INTO customer VALUES (null, @name, @addressId, '1', NOW(), 'user', NOW(), 'user')";

            MySqlCommand insertCustomerToTable = new MySqlCommand(insertCustomer, (MySqlConnection)connection);
            insertCustomerToTable.Parameters.AddWithValue("@name", name);
            insertCustomerToTable.Parameters.AddWithValue("@addressId", addressID);
            insertCustomerToTable.ExecuteNonQuery();
        }
    }
}
