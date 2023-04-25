using mschreiber_Software2_c969Project.Model;
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
        public UpcomingAlert()
        {
            InitializeComponent();
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
    }
}
