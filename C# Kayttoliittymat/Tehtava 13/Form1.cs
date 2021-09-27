using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_13
{
    public partial class Form1 : Form
    {
        Bitmap hessu = new Bitmap(Properties.Resources.HessuHopo, new Size(500, 250));
        Point piste = new Point(50,50);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics x = e.Graphics;
            x.DrawImage(hessu, piste);
            hessu.MakeTransparent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DoubleBuffered = true;
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            DoubleBuffered = true;
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
