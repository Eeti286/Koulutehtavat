using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tehtava_15
{

    public partial class aloitus_Forms : Form
    {
        public static string kayttaja = "";


        public string save_path = "C:/Koulu/Amis/C#/Käyttöliittymät/Kayttoliittymat/Tehtava 15/kayttaja_ja_pisteet.txt";
        public aloitus_Forms()
        {
            InitializeComponent();
        }

        private void poistu_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kirjaudu_button_Click(object sender, EventArgs e)
        {
            kayttaja = kayttajatunnus_textBox.Text;

            this.Hide();
            plus_Forms Main = new plus_Forms();
            Main.Show();
        }

        private void taulukko_richTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void aloitus_Forms_Load(object sender, EventArgs e)
        {
            //kayttajalista.Add("Moi");


            taulukko_richTextBox.Text = File.ReadAllText(save_path);
                       
        }
    }
}
