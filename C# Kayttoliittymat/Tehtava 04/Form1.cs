using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonClick(object sender, EventArgs e)

        {
            Button painettuNappi = sender as Button;
            MessageBox.Show(painettuNappi.Text,"Huom");
        }

        private void default_button_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }
    }
}
