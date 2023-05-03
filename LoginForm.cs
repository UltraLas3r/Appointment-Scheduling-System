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

        bool nameFound;
        bool passFound;

        public string currentCulture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
       

        public LoginForm()
        {
            InitializeComponent();
            ChangeColorofButtons();

            //get localization data
            


            // CultureInfo.CurrentCulture = new CultureInfo("es"); //TODO >> for testing purposes only, REMOVE before submission!!!!!!!
            //TODO change login form header text to spanish when language is spanish!

            //the following text handles language changing on this form
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
            {
                lbl_LoginHeader.Text = "Welcome!";
                lbl_UserName.Text = "User Name";
                lbl_Password.Text = "Password";
                btn_Login.Text = "Login";
                btn_CancelLogin.Text = "Cancel";
            }
            else
            {
                this.Text = "Página de inicio de sesión";
                lbl_LoginHeader.Text = "¡Bienvenido!";
                lbl_UserName.Text = "Nombre";
                lbl_Password.Text = "Contraseña";
                btn_Login.Text = "Iniciar sesión";
                btn_CancelLogin.Text = "Cancelar";
            }
        }

        private void LoginClick(object sender, EventArgs e)
        {
            CheckUserName();
            CheckPassword();
            //get connection string and connect 
            string loginName = txt_LoginName.Text.Trim();
            string loginPassword = txt_LoginPass.Text;

            //todo add passfound to this ifstatement
            if (nameFound == true && passFound == true)
            {
                MessageBox.Show("Successful Connection to the Database");
                string userName = txt_LoginName.Text.Trim();
                LogUserActivity.ActivateLog(userName);

                this.Hide();
                mainHomePage.Show();
            }
        }

        private void CheckPassword()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            //create command to get the usernames from the table
            string query = "SELECT password FROM user";
            MySqlCommand executeCommand = new MySqlCommand(query, conn);

            //open connection and execute the query 
            conn.Open();
            MySqlDataReader reader = executeCommand.ExecuteReader();

            List<string> passwords = new List<string>();

            while (reader.Read())
            {
                string password = reader["password"].ToString();
                passwords.Add(password);
            }

            foreach (string password in passwords)
            {
                if (txt_LoginPass.Text.Trim() == password)
                {
                    passFound = true;
                    lbl_InvalidCredentials.Hide();
                    lbl_ValidCredentialSpanish.Hide();
                }
                else
                {
                    if (currentCulture == "en")
                    {
                        lbl_InvalidCredentials.Text = "Invalid Password";
                        lbl_InvalidCredentials.Show();
                    }
                    else
                    {
                        lbl_InvalidCredentials.Text = "Invalido Passwordo";
                        lbl_ValidCredentialSpanish.Show();
                    }
                }

                if (currentCulture == "es")
                {
                    MessageBox.Show("Conexión correcta a la base de datos");
                    string userName = txt_LoginName.Text.Trim();
                    LogUserActivity.ActivateLog(userName);
                }
            }
        }

        private void CheckUserName()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            //create command to get the usernames from the table
            string query = "SELECT username FROM user";
            MySqlCommand executeCommand = new MySqlCommand(query, conn);

            //open connection and execute the query 
            conn.Open();
            MySqlDataReader reader = executeCommand.ExecuteReader();

            List<string> userNames = new List<string>();
            while (reader.Read())
            {
                string name = reader["username"].ToString();
                userNames.Add(name);
            }

            foreach (string name in userNames)
            {
                if (txt_LoginName.Text.Trim() == name)
                { 
                    nameFound = true; 
                }
                else 
                {
                    if (currentCulture == "en")
                    {
                        lbl_InvalidCredentials.Show();
                    }
                    else
                    {
                        lbl_ValidCredentialSpanish.Show();
                    }
                }

                if (currentCulture == "es")
                {
                    MessageBox.Show("Conexión correcta a la base de datos");
                    string userName = txt_LoginName.Text.Trim();
                    LogUserActivity.ActivateLog(userName);
                }
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
