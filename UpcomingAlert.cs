using mschreiber_Software2_c969Project.Model;
using MySql.Data.MySqlClient;
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
    
    public partial class UpcomingAlert : Form
    {
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public UpcomingAlert()
        {
            InitializeComponent();
            UpcomingAlert_Load();
            ChangeColorofButtons();
        }

        private void lbl_Header_Click(object sender, EventArgs e)
        {

        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_Close);
        }

        private void UpcomingAlert_Load()
        {
            //if there is an appointment that exists within 15 minutes of the user's
            //computer time, display a warning popup that has the appointment info

            MySqlConnection conn = new MySqlConnection(connString);

            string getUpcomming = "SELECT * FROM appointment WHERE start BETWEEN NOW() AND DATE_ADD(NOW(), INTERVAL 15 MINUTE);";
            MySqlCommand cmd = new MySqlCommand(getUpcomming, conn);

            //finally, create a copy of the datatable form MySQL to put into the DGV
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adpt.Fill(dataTable);

            //point datagridview to the data source
            dgv_warning.DataSource = dataTable;
        }
    }
}
