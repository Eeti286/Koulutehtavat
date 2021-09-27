using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tehtava_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void start_button_Click(object sender, EventArgs e)
        {
            int.TryParse(arvo_textBox.Text, out int maara);
            int numero = 0;

            for (int i = 0; i < maara; i++)
            {
                numero = numero + 1;
                label1.Text = numero.ToString();
                Thread.Sleep(10);
                Update();
            }

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
