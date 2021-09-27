using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava_10
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> dict;
        public Form1()
        {
            InitializeComponent();
        }

        private void luo_button1_Click(object sender, EventArgs e)
        {
            dict = new Dictionary<int, string>();
        }

        private void lisaa_button2_Click(object sender, EventArgs e)
        {
            dict.Add(int.Parse(key_textBox1.Text), value_textBox2.Text);
        }

        private void hae_button3_Click(object sender, EventArgs e)
        {
            var variable = dict[int.Parse(key_hae_textBox3.Text)];
            tulosta_label8.Text = variable;
        }
    }
}
