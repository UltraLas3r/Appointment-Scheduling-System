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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            CheckLanguageSetting();

            this.ActiveControl = txt_LoginName;
        }

        private void CheckLanguageSetting()
        {
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
            string loginName = txt_LoginName.Text.Trim();
            string loginPassword = txt_LoginPass.Text;
            CheckUserName();
            CheckPassword();


            if (nameFound != true)
            {
                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
                {
                    lbl_InvalidCredentials.Text = "Invalid Name";
                }
                else
                {
                    lbl_InvalidCredentials.Text = "Contraseña o nombre no válida";
                }

                lbl_InvalidCredentials.Show();

                LogUserActivity.ActivateLog("INVALID LOGIN ATTEMPT: " + loginName + loginPassword);
            }

            if (passFound != true)
            {
                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
                { 
                    lbl_InvalidCredentials.Text = "Invalid Password";
                }

                else
                {
                    lbl_InvalidCredentials.Text = "Contraseña no válida"; 
                }
                
                lbl_InvalidCredentials.Show();

                LogUserActivity.ActivateLog("INVALID LOGIN ATTEMPT: " + loginName + loginPassword);
            }


            if (passFound == true && nameFound == true)
            {
                this.Hide();
                mainHomePage.Show();
                CheckForUpcoming();
            }
        }

        private void CheckUserName()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            string getUserName = "SELECT username FROM user";
            MySqlCommand executeCommand = new MySqlCommand(getUserName, conn);

            //open connection and execute the query 
            conn.Open();
            MySqlDataReader reader = executeCommand.ExecuteReader();

            List<string> userNames = new List<string>();
            while (reader.Read())
            {
                string userName = reader["username"].ToString();
                userNames.Add(userName);
            }

            string searchUserName = txt_LoginName.Text.Trim();

            if (userNames.Any(userName => userName == searchUserName) && currentCulture == "en")
            {
                nameFound = true;
                lbl_InvalidCredentials.Hide();
                userNames.Clear();
            }
            else
            { 
                nameFound = false;
            }
            //the use of a lambda in the above expression simplifies iterating through
            //the list of usernames in the database. 

            conn.Close();
        }

        private void CheckPassword()
        {
            MySqlConnection conn = new MySqlConnection(connString);
           
            string getPassword = "SELECT password FROM user";
            MySqlCommand executeCommand = new MySqlCommand(getPassword, conn);

            conn.Open();
            MySqlDataReader reader = executeCommand.ExecuteReader();

            List<string> passwords = new List<string>();
            while (reader.Read())
            {
                string password = reader["password"].ToString();
                passwords.Add(password);
            }

            string searchPassword = txt_LoginPass.Text.Trim();
            if (passwords.Any(password => password == searchPassword) && currentCulture == "en")
            {
                passFound = true;
                lbl_InvalidCredentials.Hide();
                passwords.Clear();
            }
            else
            {
                passFound = false;
            }
            //the use of a lambda in the above expression simplifies iterating through
            //the list of passwords in the database. 
            conn.Close();
         
        }

        private void CheckForUpcoming()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);

                DateTime start = DateTime.UtcNow;
                DateTime end = DateTime.UtcNow.AddMinutes(15);


                string userNameFromLogin = txt_LoginName.Text.Trim();
                string getUserId = "SELECT userID FROM user where userName = @userName";

                MySqlCommand cmd = new MySqlCommand(getUserId, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@userName", userNameFromLogin);

                Object obj = cmd.ExecuteScalar();
                int userIdfromSQL = Convert.ToInt32(obj.ToString());

                //fill data table for 15 minutes
                string getAppointment = "SELECT * FROM appointment WHERE UserId = @userId AND start BETWEEN @start AND @end;";

                MySqlCommand cmdApp15 = new MySqlCommand(getAppointment, conn);

                DataTable dataTable = new DataTable();
                cmdApp15.Parameters.AddWithValue("@userId", userIdfromSQL);
                cmdApp15.Parameters.AddWithValue("@start", start);
                cmdApp15.Parameters.AddWithValue("@end", end);

                int adapter = new MySqlDataAdapter(cmdApp15).Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("There is an appointment within 15 minutes");
                }
            }
            catch
            {
                MessageBox.Show("Invalid data");
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
