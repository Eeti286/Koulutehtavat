using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_01
{
    public partial class Elokuvasovellus : Form
    {
        int vuosi = DateTime.Now.Year;

        int tyhja = 0;
        string tyhja_nimi = "[Syötä elokuvan nimi]";
        string tyhja_arvio = "[Syötä arviosi]";

        public Elokuvasovellus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nimi_textBox.Text = tyhja_nimi;
            julkaisuvuosi_textBox.Text = vuosi.ToString();
            id_textBox.Text = tyhja.ToString();
            kesto_textBox.Text = tyhja.ToString();
            arvio_textBox.Text = tyhja_arvio;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nimi_textBox.Text == tyhja_nimi)
            {
                MessageBox.Show("Nimikenttä on tyhjä");
            }
            else if (int.TryParse(nimi_textBox.Text, out int _nimi_textBox))
            {
                MessageBox.Show("Nimi on pitää olla teksti");
                return;
            }
                else if (julkaisuvuosi_textBox.Text == tyhja.ToString())
                {
                    MessageBox.Show("Julkaisuvuosikenttä on tyhjä");
                }
                else if (!int.TryParse(julkaisuvuosi_textBox.Text, out int _julkaisuvuosi_textBox))
                {
                    MessageBox.Show("julkaisuvuosi pitää olla numero");
                    return;
                }
                    else if (kesto_textBox.Text == tyhja.ToString())
                    {
                        MessageBox.Show("Kestokenttä on tyhjä");
                    }
                    else if (!int.TryParse(kesto_textBox.Text, out int _kesto_textBox))
                    {
                        MessageBox.Show("Kestö pitää olla numero");
                        return;
                    }
                        if (arvio_textBox.Text == tyhja_nimi)
                        {
                            MessageBox.Show("Arviokenttä on tyhjä");
                        }
                        else if (int.TryParse(arvio_textBox.Text, out int _arvio_textBox))
                        {
                            MessageBox.Show("Arvio on pitää olla teksti");
                            return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Eerik Linjama");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kesto_textBox_Click(object sender, EventArgs e)
        { 
            if (kesto_textBox.Text == tyhja.ToString())
            {
                kesto_textBox.Clear();
            }
        }
        private void nimi_textBox_Click(object sender, EventArgs e)
        {
            if (nimi_textBox.Text == tyhja_nimi)
            {
                nimi_textBox.Clear();
            }
        }

        private void arvio_textBox_Click(object sender, EventArgs e)
        {
            if (arvio_textBox.Text == tyhja_arvio)
            {
                arvio_textBox.Clear();
            }
        }

        private void nimi_textBox_Leave(object sender, EventArgs e)
        {
            if (nimi_textBox.Text == "")
            {
                nimi_textBox.Text = tyhja_nimi;
            }
        }

        private void kesto_textBox_Leave(object sender, EventArgs e)
        {
            if (kesto_textBox.Text == "")
            {
                kesto_textBox.Text = tyhja.ToString();
            }
        }

        private void arvio_textBox_Leave(object sender, EventArgs e)
        {
            if (arvio_textBox.Text == "")
            {
                arvio_textBox.Text = tyhja_arvio;
            }
        }
    }
}
