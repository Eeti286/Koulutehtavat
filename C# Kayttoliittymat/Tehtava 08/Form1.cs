using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_08
{
    public partial class Form1 : Form
    {
        private int[] lotto = new int[7];
        private int[] lottorivi = new int[40];
        private int[] sekoitettu_lottorivi;
        private int[] lisarivi = new int[2];
        private int[] kayttaja = new int[7];

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void lisaaNumerot()
        {
            int a = 0;
            for (int i = 0; i < 40; i++)
            {
                lottorivi[i] = a;
                a++;
            }
        }

        private void sekoitetaan()
        {
            sekoitettu_lottorivi = lottorivi.OrderBy(x => rnd.Next()).ToArray();
        }

        private void lisaaRivit()
        {
            for (int i = 0; i < 7; i++)
            {
                lotto[i] = sekoitettu_lottorivi[i];
            }
        }
        private void lisaaLisaRivit()
        {
            for (int i = 0; i < 2; i++)
            {
                lisarivi[i] = sekoitettu_lottorivi[i + 7];
            }
        }

        private void jarjestele()
        {
            Array.Sort(lotto);
            Array.Sort(lisarivi);
        }

        private void tulosta()
        {
            label2.Text = string.Join(", ", lotto);
            lisarivi_label.Text = string.Join(", ", lisarivi);
        }

        private void Käyttäjä()
        {
            int i = 0;
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                int userval = int.Parse(textBox.Text);
                kayttaja[6 - i] = userval;
                i++;
            }
        }

        private void tarkistaTulos()
        {
            int tulos = 0;
            for ( int i = 0; i < 7; i++)
            {
                if (lotto[i] == kayttaja[i])
                {
                    tulos++;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (lisarivi[0] == kayttaja[i])
                {
                    tulos++;
                }
                if (lisarivi[1] == kayttaja[i])
                {
                    tulos++;
                }
            }
            MessageBox.Show("sait " +  tulos + " oikein", "Pisteet");
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            lisaaNumerot();
            sekoitetaan();
            lisaaRivit();
            lisaaLisaRivit();
            jarjestele();
            tulosta();

            Käyttäjä();
            tarkistaTulos();
            

        }
    }
}
