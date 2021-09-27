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

namespace Muistipeli
{
    public partial class Form1 : Form
    {
        List<int> vaikeaLista = new List<int>(Enumerable.Range(1, 18));
        List<int> helppoLista = new List<int>(Enumerable.Range(1, 8));

        List<int> sekoitettuVaikeaLista;
        List<int> sekoitettuHelppoLista;

        List<int> voitonTarkistus = new List<int>();
        List<Button> pariLista = new List<Button>();

        Random rnd = new Random();
       
        bool radioButtonClicked = false;
        int size = 0;
        int row = 0;
        int tarkistus = 1;

        //ajastin
        int timeCs, timeSec, timeMin;
        bool isActive;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }


        // valitsee vaikeustason
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonClicked = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonClicked = true;
        }


        //aloittaa pelin
        private void aloita_peli_button_Click(object sender, EventArgs e)
        {
            Box.Controls.Clear();
            lisataanLuvutListaan();
            sekoitetaanNumerot();
            luodaanPelilauta();
            resetAjastin();

            voitonTarkistus.Clear();
            voitto_label.Text = "";

            aloitaAjastin();
        }


        //tarkistaa kuinka monta riviä ja nappia peliin luodaan
        private void tarkistaaTason()
        {
            if (radioButtonClicked == true) // vaikea
            {
                size = 75;
                row = 6;
            }
            else if (radioButtonClicked == false) // helppo
            {
                size = 112;
                row = 4;
            }
        }


        //luo pelilaudan 
        private void luodaanPelilauta()
        {
            int x = 25;
            int y = 25;
            int counter = 0;

            tarkistaaTason();

            for (int a = 0; a < row; a++)
            {
                x = x + counter;
                y = 25;
                counter = size;

                for (int i = 0; i < row; i++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(size, size);
                    btn.BackColor = Color.Pink;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.Location = new Point(x, y);
                    y = y + size;

                    asettaaTag(btn);
                    btn.Click += btn_click;

                    Controls.Add(btn);
                    Box.Controls.Add(btn);
                }
            }
        }


        //lisää pelilautaan kuvat
        private void lisaaKuvat(Button clickedButton)
        {
            if (clickedButton != null)
            {
                string nimi = "k" + clickedButton.Tag;
                clickedButton.BackgroundImage = Properties.Resources.ResourceManager.GetObject(nimi) as Bitmap;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }


        //lisätään luvut listaan
        private void lisataanLuvutListaan() 
        {
            if (radioButtonClicked == true)
            {
                for (int i = 0; i < 18; i++)
                {
                    vaikeaLista.Add(i + 1);
                }
            }
            else if (radioButtonClicked == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    helppoLista.Add(i + 1);
                }
            }
        }


        //sekoitetaan listassa olevat luvut
        private void sekoitetaanNumerot()
        {
            if (radioButtonClicked == true)
            {
                sekoitettuVaikeaLista = vaikeaLista.OrderBy(item => rnd.Next()).ToList();
            }
            else if (radioButtonClicked == false)
            {
                sekoitettuHelppoLista = helppoLista.OrderBy(item => rnd.Next()).ToList();
            }          
        }


        //asettaa napeille tagit
        private void asettaaTag(Button btn)
        {
            if (radioButtonClicked == true)
            {
                int luku = rnd.Next(sekoitettuVaikeaLista.Count);
                btn.Tag = sekoitettuVaikeaLista[luku];

                btn.Text = btn.Tag.ToString();

                sekoitettuVaikeaLista.RemoveAt(luku);
            }
            else if (radioButtonClicked == false)
            {
                int luku = rnd.Next(sekoitettuHelppoLista.Count);
                btn.Tag = sekoitettuHelppoLista[luku];

                btn.Text = btn.Tag.ToString();

                sekoitettuHelppoLista.RemoveAt(luku);
            }

        }

        //lisää viiveen
        private void viive(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }


        //tarkistaa onko kyseessa sama vai eri pari
        private void tarkistaaParin(Button clickedButton)
        {
            if (pariLista.Count == 0)
            {
                pariLista.Add(clickedButton);
            }

            else if (pariLista.Count != 0)
            {
                if (pariLista[0].Tag.ToString() == clickedButton.Tag.ToString())
                {
                    pariLista.Add(clickedButton);
                    pariLista[0].BackgroundImage = null;
                    pariLista[0].BackColor = Color.Black;
                    pariLista[1].BackgroundImage = null;
                    pariLista[1].BackColor = Color.Black;
                    pariLista[0].Enabled = false;
                    pariLista[1].Enabled = false;

                    voitonTarkistus.Add(tarkistus); // lístätään voiton tarkistusta varten

                    pariLista.Clear();
                }
                else
                {
                    viive(2);
                    pariLista.Add(clickedButton);
                    pariLista[0].BackgroundImage = null;
                    pariLista[1].BackgroundImage = null;
                    pariLista.Clear();
                }
            }
        }


        // kun nappia painetaan
        private void btn_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            lisaaKuvat(clickedButton);

            tarkistaaParin(clickedButton);

            tarkistaaVoiton(clickedButton);
        }


        // tarkistetaan onko kaikki koertit käännetty
        private void tarkistaaVoiton(Button clickedButton)
        {
            if (radioButtonClicked == true)
            {
                if (voitonTarkistus.Count == 18)
                {
                    voitto_label.Text = "Voitit pelin!";
                    pysäytäAjastin();
                }
            }
            else if(radioButtonClicked == false)
            {
                if (voitonTarkistus.Count == 8)
                {
                    voitto_label.Text = "Voitit pelin;";
                    pysäytäAjastin();
                }
            }
        }



        // ajastin
        private void aloitaAjastin()
        {
            isActive = true;
        }
        private void pysäytäAjastin()
        {
            isActive = false;
        }

        private void resetAjastin()
        {
            isActive = false;

            ResetTime();
        }
        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void sec_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                timeCs++;

                if(timeCs >= 100)
                {
                    timeSec++;
                    timeCs = 0;

                    if(timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }

            }

            DrawTime();

        }
        
        private void DrawTime()
        {
            cs_label.Text = String.Format("{0,00}", timeCs);
            sec_label.Text = String.Format("{0,00}", timeSec);
            min_label.Text = String.Format("{0,00}", timeMin);
        }


    }
}
