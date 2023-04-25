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
        private string currentCulture;  
        bool LoginSuccess = false;

        public LoginForm()
        {
            InitializeComponent();
            ChangeColorofButtons();
            
            //get localization data
            currentCulture = CultureInfo.CurrentCulture.DisplayName;
            //get the current date and time 
            DateTime currentDateTime = DateTime.Now;
            // Set the text of the label element
            lbl_UserLocationAndTime.Text = $"Location: {currentCulture} ... {currentDateTime.ToString()}";

            //the following text handles language changing on this form
            if (currentCulture == "en-US")
            {
                lbl_LoginHeader.Text = "Welcome!";
                lbl_UserName.Text = "User Name";
                lbl_Password.Text = "Password";
                lbl_InvalidCredentials.Text = "Please Enter Valid Credentials";
                btn_Login.Text = "Login";
                btn_CancelLogin.Text = "Cancel";
                lbl_UserLocationAndTime.Text = $"Location: {currentCulture} ... {currentDateTime.ToString()}";
            }
            else if (currentCulture == "es-US") 
            {
                lbl_LoginHeader.Text = "¡Bienvenido!";
                lbl_UserName.Text = "Nombre";
                lbl_Password.Text = "Contraseña";
                lbl_InvalidCredentials.Text = "Por favor, Introduzca credenciales válidas";
                btn_Login.Text = "Iniciar sesión";
                btn_CancelLogin.Text = "Cancelar";
                lbl_UserLocationAndTime.Text = $"Ubicación: {currentCulture} ... {currentDateTime.ToString()}";
            }
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
                if (currentCulture == "en-US") 
                {
                MessageBox.Show("Successful Connection to the Database");
                }
                else if (currentCulture == "es-US")
                {
                MessageBox.Show("Conexión correcta a la base de datos");
                }
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
            //run a select statement to check the DB if the userID and the password match 

            if (LoginSuccess == true)
            {
                this.Hide();
                mainHomePage.Show();
            }
            
            else if (LoginSuccess == false)
            {

            }
          
            if (txt_LoginName.Text.Length > 0)
            {
                string userName = txt_LoginName.Text.Trim();

                LogUserActivity.ActivateLog(userName);
            }
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
