using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project.Model
{
    public class ButtonHoverColorChanger
    {
        private Color _hoverBackColor = Color.Black;
        private Color _hoverForeColor = Color.LimeGreen;

        public ButtonHoverColorChanger() { }
        public ButtonHoverColorChanger(Color hoverBackColor, Color hoverForeColor)
        {
            _hoverBackColor = hoverBackColor;
            _hoverForeColor = hoverForeColor;
        }

        public void Attach (Button button)
        {
            //the lambdas in this public method attach event handlers to the button MouseEnter
            // and MouseLeave events.
            // This lambda helps keep the code cleaner, and allows this class to be used throughout
            // the program in an elegant mannaer.  
            button.MouseEnter += (sender, e) =>
            {
                var b = (Button)sender;
                b.BackColor = _hoverBackColor;
                b.ForeColor = _hoverForeColor;
            };

            button.MouseLeave += (sender, e) =>
            {
                var b = (Button)sender;
                b.BackColor = SystemColors.Control;
                b.ForeColor = SystemColors.ControlText;
            };
        }
 
    }
    
}
