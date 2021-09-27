using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtavat_07
{
    public partial class Form1 : Form
    {
        int[] numerot;
        public Form1()
        {
            InitializeComponent();
        }

        private void luo_taulukko_button_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int maara);
            numerot = new int[maara];
        }

        private void tallenna_button_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int index);
            int.TryParse(textBox2.Text, out int talleta_numero);
            numerot[index] = talleta_numero;       
        }

        private void hae_button_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox4.Text, out int haettava_numero);
            int.TryParse(textBox3.Text, out int index);
            //numerot.ElementAtOrDefault(index)

            try
            {
                if (index == haettava_numero)
                {
                    label8.Text = numerot[haettava_numero].ToString();
                }
                else
                {
                    MessageBox.Show("Jokin meni pieleen");
                }
            }
            catch
            {
                
            }

        }
    }
}
