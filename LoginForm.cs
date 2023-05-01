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
        private object isLoginTrue;

        public LoginForm()
        {
            InitializeComponent();
            ChangeColorofButtons();
            
            //get localization data
            currentCulture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        

            //CultureInfo.CurrentCulture = new CultureInfo("es"); //TODO >> for testing purposes only, REMOVE before submission!!!!!!!
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
                ;
            }
            else 
            {
                lbl_LoginHeader.Text = "¡Bienvenido!";
                lbl_UserName.Text = "Nombre";
                lbl_Password.Text = "Contraseña";
                lbl_InvalidCredentials.Text = "Por favor, Introduzca credenciales válidas";
                btn_Login.Text = "Iniciar sesión";
                btn_CancelLogin.Text = "Cancelar";  
            }
        }

        private void LoginClick(object sender, EventArgs e)
        {
            // CheckUserName();
            //get connection string and connect 
            string loginName = txt_LoginName.Text.Trim();
            string loginPassword = txt_LoginPass.Text;

            if (loginName.Length > 0 && currentCulture == "en")
            {
                MessageBox.Show("Successful Connection to the Database");

                string userName = txt_LoginName.Text.Trim();
                LogUserActivity.ActivateLog(userName);

                this.Hide();
                mainHomePage.Show();
            }

            else
            {
                lbl_InvalidCredentials.Show();
            }

            if (txt_LoginName.Text.Length > 0 && currentCulture == "es")
            {
                MessageBox.Show("Conexión correcta a la base de datos");

                string userName = txt_LoginName.Text.Trim();
                LogUserActivity.ActivateLog(userName);

                
            }

            else
            {
                lbl_ValidCredentialSpanish.Show();
            }


        }
 
        //private object CheckUserName()
        //{
        //    //MySqlConnection conn = new MySqlConnection(connString);

        //    //string query = "SELECT username FROM user WHERE userID = 1";

        //    //using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //    //{
        //    //    Create a new MySQL data adapter
        //    //    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
        //    //    {
        //    //        var db_NameQueryResult = adapter;
        //    //        take this value and use it in the LOGINCLICK method
        //    //       var isLoginTrue = db_NameQueryResult;
        //    //    }
        //    //}

        //    //return isLoginTrue;
        //}

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
