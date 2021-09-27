using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_09
{
    public partial class Form1 : Form
    {
        List<string> lista;
        public Form1()
        {
            InitializeComponent();
        }
        public void lisaaLista()
        {
            
        }
        public void luo_lista_button_Click(object sender, EventArgs e)
        {
            lista = new List<string>();        
        }

        public void lisaa_button1_Click(object sender, EventArgs e)
        {
            lista.Add(textBox1.Text);
        }

        private void hae_button2_Click(object sender, EventArgs e)
        {
            foreach (string i in lista)
            {
                comboBox1.Items.Add(i);
            }
        }

    }
}
