using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            var tulos = MessageBox.Show("Paina YES jatkaaksesi ja NO lopettaaksesi!",
                "Tapahtuma", 
                MessageBoxButtons.YesNo);

            while (tulos == DialogResult.Yes )
            {
                tulos = MessageBox.Show("Paina YES jatkaaksesi ja NO lopettaaksesi!",
                    "Tapahtuma",
                    MessageBoxButtons.YesNo);
            }
        }
    }
}
