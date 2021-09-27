using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_11
{
    public partial class Form1 : Form
    {
        Point piste;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics Graf = e.Graphics;

            //pää
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            //selka
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);
            
            //kädet
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, piste.X + 70, piste.Y + 60);

            //jalat
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X + 70, piste.Y + 181);
            
            DrawCordintes(Graf);
        }

        private void DrawCordintes(Graphics Graf)
        {
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",
                new Font("Arial", 14, System.Drawing.FontStyle.Regular),
                new SolidBrush(Color.Black), 8, 30);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                piste = e.Location;
                Invalidate();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = piste.X;
            int y = piste.Y;
            if (e.KeyCode == Keys.W)
            {
                y--;
                Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                x--;
                Invalidate();
            }
            else if (e.KeyCode == Keys.S)
            {
                y++;
                Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                //piste = new Point(x+1, y);
                x++;
                Invalidate();
            }
            piste = new Point(x, y);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}
