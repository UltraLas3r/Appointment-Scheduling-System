using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using mschreiber_Software2_c969Project.Model;

namespace mschreiber_Software2_c969Project
{

    public partial class LoginForm : Form
    {
        MainHomePage mainHomePage = new MainHomePage();

        public LoginForm()
        {
            InitializeComponent();
            ChangeColorofButtons();
            
            //get localization data
            string userLocation = CultureInfo.CurrentCulture.DisplayName;
            //get the current date and time 
            DateTime currentDateTime = DateTime.Now;
            // Set the text of the label element
            lbl_UserLocationAndTime.Text = $"Location: {userLocation} ... {currentDateTime.ToString()}";
        }

        private void LoginClick(object sender, EventArgs e)
        {
            //get connection string and connect 
            bool connectionMade;
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(constr);
                
                conn.Open();
                MessageBox.Show("Successful Connection to the Database");
                connectionMade = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            //needs to check if there is a valid entry in the DB for the user.
            if (true)
            {
                this.Hide();
                mainHomePage.Show();
            }
                 
          
            if (txt_LoginName.Text.Length > 0)
            {
                string userName = txt_LoginName.Text.Trim();

                LogUserActivity.ActivateLog(userName);
            }
        }

        private void rb_LanguageGerman_CheckedChanged(object sender, EventArgs e)
        {
            //if selected, change language on the LoginForm to German 
        }

        private void rb_LanguageEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //if selected, change the language on the LoginForm to English (this is default)
        }

        private void ChangeColorofButtons()
        {
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);
            hoverColorChanger.Attach(btn_Login);
            hoverColorChanger.Attach(btn_CancelLogin);
        }

        private void btn_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
