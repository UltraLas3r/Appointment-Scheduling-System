using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class LoginForm : Form
    {
        MainHomePage mainHomePage = new MainHomePage();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {

            //needs to check if there is a valid entry in the DB for the user.
            if (true)
            {
                this.Hide();
                mainHomePage.Show();
            }

            else
            {
                return;
            }
            //if a valid entry exists, complete the following query
            
        }

        private void rb_LanguageGerman_CheckedChanged(object sender, EventArgs e)
        {
            //if selected, change language on the LoginForm to German
            
        }

        private void rb_LanguageEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //if selected, change the language on the LoginForm to English (this is default)
        }
    }
}
