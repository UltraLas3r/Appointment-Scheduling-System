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

            //hoverColorChanger.Attach();
            //hoverColorChanger.Attach();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
