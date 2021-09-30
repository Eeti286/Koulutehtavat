using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Form2 : Form
    {
        public string Pelaaja1 = "";
        public string Pelaaja2 = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aloita_peli_button_Click(object sender, EventArgs e)
        {
            if (PelaajaA_textBox.Text != "" && PelaajaB_textBox.Text != "")
            {
                Pelaaja1 = PelaajaA_textBox.Text;
                Pelaaja2 = PelaajaB_textBox.Text;

                this.Hide();
                Form1 Main = new Form1();
                Main.Show();

            }
        }
    }
}
