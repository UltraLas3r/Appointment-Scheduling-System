using mschreiber_Software2_c969Project.Model;
using MySqlX.XDevAPI.Common;
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
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
            ChangeColorofButtons();
        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_Cancel);
            hoverColorChanger.Attach(btn_SaveAppointment);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
            }

            else
            {
                return;
            }
        }

        private void btn_SaveAppointment_Click(object sender, EventArgs e)
        {
            bool checkForInput;
            
            if (txt_CustFirstName.Text.Length >= 1)
            {
                checkForInput = true;

                string firstName = txt_CustFirstName.Text;
                string lastName = txt_CustLastName.Text;
                string address =  txt_Address.Text;
                string city = txt_City.Text;
                string country = txt_Country.Text;
                string phoneNumber = txt_PhoneNumber.Text.ToString();

                string message = "\nPlease Verify that the following information is accurate: "
                    + "\nName: " + firstName + " " + lastName 
                    + "\nAddress: " + address 
                    + "\nCity: " + city 
                    + "\nCountry: " + country 
                    + "\nPhone Number: " + phoneNumber;

                DialogResult result = MessageBox.Show (message, "Verify Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (result == DialogResult.Yes)
                {
                    //update database with new data first need an SQL statement, then the commands that will take the text and insert.
                    //string sql = "INSERT INTO "
                    // command.Parameters.AddWithValue("@name", txt_customerName);
                    //command.ExecuteNonQuery();

                    //connection.Close();

                    //MessageBox.Show("Customer saved successfully.");
                    this.Hide();
                }

                else
                {
                    return;
                }
            }
        }
    }
}
