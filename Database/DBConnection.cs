using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set;}


        public static void StartConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);

                //open connection
                conn.Open();

                MessageBox.Show("Connection is open");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No Connection made");


            }


        }

        public static void CloseConnection()
        {
            try 
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("example connection");
            }
        }

    }
}
