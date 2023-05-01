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
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        private string currentCulture;  
        bool LoginSuccess = false;
        bool ConnectionMade = false;
        private object isLoginTrue;

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

           // CultureInfo.CurrentCulture = new CultureInfo("es"); //TODO >> for testing purposes only, REMOVE before submission!!!!!!!
           //TODO change login form header text to spanish when language is spanish!

            //the following text handles language changing on this form
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
            {
                lbl_LoginHeader.Text = "Welcome!";
                lbl_UserName.Text = "User Name";
                lbl_Password.Text = "Password";
                lbl_InvalidCredentials.Text = "Please Enter Valid Credentials";
                btn_Login.Text = "Login";
                btn_CancelLogin.Text = "Cancel";
                lbl_UserLocationAndTime.Text = $"Location: {currentCulture} ... {currentDateTime.ToString()}";
            }
            else 
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
            string loginName = txt_LoginName.Text.Trim();
            string loginPassword = txt_LoginPass.Text;

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(constr);

                conn.Open();
                if (currentCulture == "en") 
                {
                MessageBox.Show("Successful Connection to the Database");
                }
                else if (currentCulture == "es")
                {
                MessageBox.Show("Conexión correcta a la base de datos");
                }

                ConnectionMade = true;
                LoginSuccess = true;
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
            //run a select statement to check the DB if the userID and the password match an entry in the database 

            //set LoginSuccess to true IF there is a match in the DB
            CheckUserName();

            if (loginName == isLoginTrue)
            {
                LoginSuccess = true;
            }


            if (LoginSuccess == true)
            {
                this.Hide();
                mainHomePage.Show();
            }
            
            else if (LoginSuccess == false)
            {
                if (currentCulture == "en") 
                    {
                        lbl_InvalidCredentials.Show();
                    }
                if (currentCulture == "es")
                    {
                    lbl_ValidCredentialSpanish.Show();
                    }
            }
          
            if (txt_LoginName.Text.Length > 0)
            {
                string userName = txt_LoginName.Text.Trim();
                LogUserActivity.ActivateLog(userName);
            }
        }

        private object CheckUserName()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string query = "SELECT username FROM user WHERE userID = 1";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                //Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                   var db_NameQueryResult = adapter;
                    //take this value and use it in the LOGINCLICK method
                   var isLoginTrue = db_NameQueryResult;
                }
            }

            return isLoginTrue;
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
