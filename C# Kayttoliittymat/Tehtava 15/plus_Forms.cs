using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtava_15
{
    public partial class plus_Forms : Form
    {
        aloitus_Forms aloitus_Forms = new aloitus_Forms();

        public Dictionary<string, int> kayttaja_ja_pistelista = new Dictionary<string, int>();

        int pisteet;
        int jako_numero1_tulos;
        int kerto_numero1_tulos;
        List<int> jakolista;
        List<int> kertolista;
        Random rnd = new Random();

        public plus_Forms()
        {
            InitializeComponent();
        }

        // Kun ladataan form
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            plus_button.TabStop = false;
            plus_button.FlatStyle = FlatStyle.Flat;
            plus_button.FlatAppearance.BorderSize = 0;
            miinus_button.TabStop = false;
            miinus_button.FlatStyle = FlatStyle.Flat;
            miinus_button.FlatAppearance.BorderSize = 0;
            jako_button.TabStop = false;
            jako_button.FlatStyle = FlatStyle.Flat;
            jako_button.FlatAppearance.BorderSize = 0;
            kerto_button.TabStop = false;
            kerto_button.FlatStyle = FlatStyle.Flat;
            kerto_button.FlatAppearance.BorderSize = 0;

            plus_button.BackColor = Color.FromArgb(31, 40, 51);
            plus_button.ForeColor = Color.White;

            tervehdys_label.Text = "Tervetuloa pelaamaan " + aloitus_Forms.kayttaja + "!";
        }


        //Laskut
        private void plusLasku()
        {
            int i = 0;

            while (i < 2)
            {
                int plus_numero1 = rnd.Next(100);
                int plus_numero2 = rnd.Next(100);

                if (plus_numero1 < plus_numero2)
                {
                    plus_label1.Text = plus_numero1.ToString();
                    plus_label2.Text = plus_numero2.ToString();
                    i++;
                }
            }
        }
        private void miinusLasku()
        {
            int i = 0;

            while(i < 2)
            {
                int miinus_numero1 = rnd.Next(100);
                int miinus_numero2 = rnd.Next(100);

                if (miinus_numero1 > miinus_numero2)
                {
                    miinus_label1.Text = miinus_numero1.ToString();
                    miinus_label2.Text = miinus_numero2.ToString();
                    i++;
                }
            }
        }
        private void kertoLasku()
        {
            int keraaja = 0;
            int kierros = 0;
            int i = 0;
            kertolista = new List<int>();

            while (i < 1)
            {
                int kerto_numero1 = rnd.Next(100);
                int kerto_numero2 = rnd.Next(100);

                if (kerto_numero1 < kerto_numero2)
                {
                    while (keraaja < 200)
                    {
                        keraaja = kerto_numero2 * (2 + kierros);
                        kertolista.Add(keraaja);
                        kierros++;
                    }

                    int rnd_index = rnd.Next(kertolista.Count - 1);
                    kerto_numero1_tulos = kertolista[rnd_index];

                    kerto_label1.Text = kerto_numero2.ToString(); 
                    kerto_label2.Text = kerto_numero1_tulos.ToString();
                    i++;
                }
            }
        }
        private void jakoLasku()
        {
            int keraaja = 0;
            int kierros = 0;
            int i = 0;
            jakolista = new List<int>();

            while (i < 1)
            {
                int jako_numero1 = rnd.Next(100);
                int jako_numero2 = rnd.Next(100);

                if (jako_numero1 > jako_numero2)
                {
                    while (keraaja < 200)
                    {
                        keraaja = jako_numero2 * (2 + kierros);
                        jakolista.Add(keraaja);
                        kierros++;
                    }

                    int rnd_index = rnd.Next(jakolista.Count-1);
                    jako_numero1_tulos = jakolista[rnd_index];

                    jako_label1.Text = jako_numero1_tulos.ToString();
                    jako_label2.Text = jako_numero2.ToString();
                    i++;
                }
            }
        }


        //laskujen tulostestaus, tarkista nappia painaessa
        private void tarkista_button_Click(object sender, EventArgs e)
        {
            if (plus_textBox.ReadOnly == false)
            {
                plus_lasku_tulos();
            }
            else if (miinus_textBox.ReadOnly == false)
            {
                miinus_lasku_tulos();
            }
            else if (kerto_textBox.ReadOnly == false)
            {
                kerto_lasku_tulos();
            }
            else if (jako_textBox.ReadOnly == false)
            {
                jako_lasku_tulos();
            }
        }


        //laskujen tulostestaus
        private void jako_lasku_tulos()
        {
            int jako_yht = int.Parse(jako_label1.Text) / int.Parse(jako_textBox.Text);
            if (jako_yht == int.Parse(jako_label2.Text))
            {
                MessageBox.Show("Oikein");
                jako_textBox.Clear();
                jakoLasku();

                pisteet++;
                pisteet_label2.Text = pisteet.ToString();
            }
            else
            {
                MessageBox.Show("Väärin");
                jako_textBox.Clear();
                jakoLasku();

                pisteet--;
                pisteet_label2.Text = pisteet.ToString();
            }
        }
        private void kerto_lasku_tulos()
        {
            int kerto_yht = int.Parse(kerto_label1.Text) * int.Parse(kerto_textBox.Text);
            if (kerto_yht == int.Parse(kerto_label2.Text))
            {
                MessageBox.Show("Oikein");
                kerto_textBox.Clear();
                kertoLasku();

                pisteet++;
                pisteet_label2.Text = pisteet.ToString();
            }
            else
            {
                MessageBox.Show("Väärin");
                kerto_textBox.Clear();
                kertoLasku();

                pisteet--;
                pisteet_label2.Text = pisteet.ToString();
            }
        }
        private void miinus_lasku_tulos()
        {
            int miinus_yht = int.Parse(miinus_label1.Text) - int.Parse(miinus_textBox.Text);
            if (miinus_yht == int.Parse(miinus_label2.Text))
            {
                MessageBox.Show("Oikein");
                miinus_textBox.Clear();
                miinusLasku();

                pisteet++;
                pisteet_label2.Text = pisteet.ToString();
            }
            else
            {
                MessageBox.Show("Väärin");
                miinus_textBox.Clear();
                miinusLasku();

                pisteet--;
                pisteet_label2.Text = pisteet.ToString();
            }
        }
        private void plus_lasku_tulos()
        {
            int plus_yht = int.Parse(plus_label1.Text) + int.Parse(plus_textBox.Text);
            if (plus_yht == int.Parse(plus_label2.Text))
            {
                MessageBox.Show("Oikein");
                plus_textBox.Clear();
                plusLasku();

                pisteet++;
                pisteet_label2.Text = pisteet.ToString();
            }
            else
            {
                MessageBox.Show("Väärin");
                plus_textBox.Clear();
                plusLasku();

                pisteet--;
                pisteet_label2.Text = pisteet.ToString();
            }
        }






        // exit nappi
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Header nappien toiminta
        private void btn_Click(object sender, EventArgs e)
        {
            header_nappien_painallus(sender);

            if (plus_button.ForeColor == Color.White)
            {
                plus_textBox.ReadOnly = false;
                plusLasku();
            }
            else if (miinus_button.ForeColor == Color.White)
            {
                miinus_textBox.ReadOnly = false;
                miinusLasku();
            }
            else if (kerto_button.ForeColor == Color.White)
            {
                kerto_textBox.ReadOnly = false;
                kertoLasku();
            }
            else if (jako_button.ForeColor == Color.White)
            {
                jako_textBox.ReadOnly = false;
                jakoLasku();
            }
        }

        private void header_nappien_painallus(object sender)
        {
            Button nappi = sender as Button;
            foreach (Button butt in panel1.Controls.OfType<Button>())
            {
                butt.BackColor = Color.FromArgb(102, 252, 241);
                butt.ForeColor = Color.Black;

                plus_textBox.ReadOnly = true;
                miinus_textBox.ReadOnly = true;
                kerto_textBox.ReadOnly = true;
                jako_textBox.ReadOnly = true;

                plus_textBox.Clear();
                miinus_textBox.Clear();
                kerto_textBox.Clear();
                jako_textBox.Clear();

            }
            nappi.BackColor = Color.FromArgb(31, 40, 51);
            nappi.ForeColor = Color.White;
        }

        private void tallenna_button_Click(object sender, EventArgs e)
        {
            kayttaja_ja_pistelista.Add(aloitus_Forms.kayttaja, pisteet);

            TextWriter writer = new StreamWriter(aloitus_Forms.save_path, true);

            foreach (var entry in kayttaja_ja_pistelista)
                writer.WriteLine("{0}   {1} Pistettä", entry.Key, entry.Value);

            writer.Close();

            aloitus_Forms.Show();
            this.Hide();
        }
    }
}
