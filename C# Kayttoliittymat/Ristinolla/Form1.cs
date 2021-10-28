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

namespace Ristinolla
{
    public partial class Form1 : Form
    {

        List<Button> buttonsList = new List<Button>();

        bool pelaaja;
        bool pelaajaA = true;
        bool pelaajaB = false;

        int jakojaannosmittari = 0;
        int pelaajaA_pisteet = 0;
        int pelaajaB_pisteet = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kierros = 0;
            int x = 0;
            int y = 10;
            jakojaannosmittari = 0;

            voitto_label.Text = "";
            buttonsList.Clear();
            Box.Controls.Clear();
            peli_maara_trackBar.Enabled = false;
            aloita_peli_button.Enabled = false;

            vuoro_pictureBox.BackgroundImage = Properties.Resources.nolla;

            //pelilaudan luonti
            for (int a = 0; a < 3; a++)
            {
                x = x + kierros;
                y = 10;
                kierros = 165;

                for (int i = 0; i < 3; i++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(165, 165);
                    btn.Location = new Point(x, y);
                    btn.BackColor = Color.White;
                    btn.BringToFront();

                    y = y + 165;

                    buttonsList.Add(btn);

                    Controls.Add(btn);
                    Box.Controls.Add(btn);

                    btn.Click += btn_click;
                }
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            valitseeVuoron();
            lisaaKuva(clickedButton);

            if (pelaaja == pelaajaA)
            {
                vuoro_pictureBox.BackgroundImage = Properties.Resources.risti;
                vuoro_pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                clickedButton.Tag = 1;
            }
            else if (pelaaja == pelaajaB)
            {
                vuoro_pictureBox.BackgroundImage = Properties.Resources.nolla;
                vuoro_pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                clickedButton.Tag = 2;
            }

            PystyTarkistusSilmukka();
            SivuTarkistuSilmukka();
            VinoTarkistusSilmukka();
 

            if (buttonsList[0].Tag != null && buttonsList[1].Tag != null && buttonsList[2].Tag != null
                && buttonsList[3].Tag != null && buttonsList[4].Tag != null && buttonsList[5].Tag != null
                && buttonsList[6].Tag != null && buttonsList[7].Tag != null && buttonsList[8].Tag != null
                && voitto_label.Text == "")
            {
                voitto_label.Text = "Tasapeli";
                Viive(2);
                button1_Click(new object(), new EventArgs());
            }

            clickedButton.Enabled = false;
        }

        private void VinoTarkistusSilmukka()
        {
            int y = 0;
            int z = 0;

            for (int i = 0; i < 4; i = i+2)
            {
                if (buttonsList[i].Tag != null && buttonsList[i + 4 - y].Tag != null && buttonsList[i + 8 - z].Tag != null)
                {
                    if (buttonsList[i].Tag.ToString() == buttonsList[i + 4 - y].Tag.ToString() && buttonsList[i + 4 - y].Tag.ToString() == buttonsList[i + 8 - z].Tag.ToString())
                    {
                        PisteidenTarkistus(i);
                    }
                }

                y = y + 2;
                z = z + 4;

            }
        }
        private void SivuTarkistuSilmukka()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttonsList[i].Tag != null && buttonsList[i+3].Tag != null && buttonsList[i+6].Tag != null)
                {
                    if (buttonsList[i].Tag.ToString() == buttonsList[i+3].Tag.ToString() && buttonsList[i+3].Tag.ToString() == buttonsList[i+6].Tag.ToString())
                    {
                        PisteidenTarkistus(i);
                    }
                }
            }
        }
        private void PystyTarkistusSilmukka()
        {
            for(int i = 0; i < 9; i=i+3)
            {
                if (buttonsList[i].Tag != null && buttonsList[i + 1].Tag != null && buttonsList[i + 2].Tag != null)
                {
                    if (buttonsList[i].Tag.ToString() == buttonsList[i + 1].Tag.ToString() && buttonsList[i + 1].Tag.ToString() == buttonsList[i + 2].Tag.ToString())
                    {
                        PisteidenTarkistus(i);
                    }
                }
            }
        }

        private void PisteidenTarkistus(int i)
        {

            if (buttonsList[i].Tag.ToString() == "1")
            {
                pelaajaA_pisteet++;
                pelaajaA_pisteet_label.Text = pelaajaA_pisteet.ToString();
                voitto_label.Text = "PelaajaA voitti";
                Pelinjatkaminen();
            }
            else if (buttonsList[i].Tag.ToString() == "2")
            {
                pelaajaB_pisteet++;
                pelaajaB_pisteet_label.Text = pelaajaB_pisteet.ToString();
                voitto_label.Text = "PelaajaB voitti";
                Pelinjatkaminen();
            }
        }

        private void lisaaKuva(Button clickedButton)
        {
            if (pelaaja == pelaajaA)
            {
                clickedButton.BackgroundImage = Properties.Resources.ResourceManager.GetObject("nolla") as Bitmap;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (pelaaja == pelaajaB)
            {
                clickedButton.BackgroundImage = Properties.Resources.ResourceManager.GetObject("risti") as Bitmap;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void valitseeVuoron()
        {
            if (jakojaannosmittari % 2 == 0)
            {
                pelaaja = pelaajaA;
            }
            else if (jakojaannosmittari % 2 != 0)
            {
                pelaaja = pelaajaB;
            }
            jakojaannosmittari++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "PelaajaA";
            label2.Text = "PelaajaB";
        }

        private void peli_maara_trackBar_Scroll(object sender, EventArgs e)
        {
            peli_maara_label.Text = peli_maara_trackBar.Value.ToString();
        }
        private void Pelinjatkaminen()
        {
            if (pelaajaA_pisteet != peli_maara_trackBar.Value && pelaajaB_pisteet != peli_maara_trackBar.Value)
            {
                Viive(2);
                button1_Click(new object(), new EventArgs());
            }
            else
            {
                Viive(2);
                Box.Controls.Clear();
                peli_maara_trackBar.Enabled = true;
                aloita_peli_button.Enabled = true;

                pelaajaA_pisteet = 0;
                pelaajaB_pisteet = 0;

                pelaajaA_pisteet_label.Text = pelaajaA_pisteet.ToString();
                pelaajaB_pisteet_label.Text = pelaajaB_pisteet.ToString();

                voitto_label.Text = "";
                peli_maara_trackBar.Value = 1;
                peli_maara_label.Text = "1";

                vuoro_pictureBox.Image = null;
            }
        }
        private void Viive(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }
    }
}
