using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        int factor = 0;
        KaupanLogiikka registerHandler = new KaupanLogiikka();

        public MainMenu()
        {
            KaupanLogiikka registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void TestDatabaseConnection(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void cbMalli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMerkki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            cbPolttoaine.Text = null;
            cbVari.Text = null;
            cbMerkki.Text = null;
            cbMalli.Text = null;
            tbHinta.Clear();
            tbMittarilukema.Clear();
            tbTilavuus.Clear();
            tbId.Clear();
            dtpPaiva.Value = DateTime.Now;
        }

        private void cbMerkki_Click(object sender, EventArgs e)
        {
            cbMerkki.DisplayMember = "Merkki";
            cbMerkki.ValueMember = "ID";
            cbMerkki.DataSource = registerHandler.getAllAutoMakers();
            cbMalli.Text = null;
        }

        private void cbVari_Click(object sender, EventArgs e)
        {
            cbVari.DisplayMember = "VariNimi";
            cbVari.ValueMember = "ID";
            cbVari.DataSource = registerHandler.getAutoVari();
        }

        private void cbPolttoaine_Click(object sender, EventArgs e)
        {

            cbPolttoaine.DisplayMember = "PolttoaineNimi";
            cbPolttoaine.ValueMember = "ID";
            cbPolttoaine.DataSource = registerHandler.getAutoPolttoaine();
        }

        private void cbMalli_Click(object sender, EventArgs e)
        {
            cbMalli.DisplayMember = "Malli";
            cbMalli.ValueMember = "ID";
            int id = int.Parse(cbMerkki.SelectedValue.ToString());
            cbMalli.DataSource = registerHandler.getAutoModels(id);
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.AutonMalliID1 = int.Parse(cbMalli.SelectedValue.ToString());
            auto.AutonMerkkiID1 = int.Parse(cbMerkki.SelectedValue.ToString());
            auto.Hinta1 = int.Parse(tbHinta.Text);
            auto.Rekisteri_paivamaara1 = dtpPaiva.Value;
            auto.VaritID1 = int.Parse(cbVari.SelectedValue.ToString());
            auto.PolttoaineID1 = int.Parse(cbPolttoaine.SelectedValue.ToString());
            auto.Mittarilukema1 = int.Parse(tbMittarilukema.Text);
            auto.Moottorin_tilavuus1 = int.Parse(tbTilavuus.Text);
            registerHandler.saveAuto(auto);
        }

        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            int count = registerHandler.AllDatabaseRowCount() - 1;
            factor++;
            if (factor > count)
            {
                factor = 0;
            }
            List<Auto> auto = registerHandler.sortDataBase(factor);
            tbHinta.Text = auto[0].Hinta1.ToString();
            tbId.Text = auto[0].Id1.ToString();
            tbMittarilukema.Text = auto[0].Mittarilukema1.ToString();
            tbTilavuus.Text = auto[0].Moottorin_tilavuus1.ToString();
            cbMerkki.Text = auto[0].AutoMerkki1.ToString();
            cbMalli.Text = auto[0].AutoMalli1.ToString();
            cbVari.Text = auto[0].Vari1.ToString();
            cbPolttoaine.Text = auto[0].Polttoaine1.ToString();
            dtpPaiva.Value = auto[0].Rekisteri_paivamaara1;
        }

        private void btnEdellinen_Click(object sender, EventArgs e)
        {
            int count = registerHandler.AllDatabaseRowCount() - 1;
            factor--;
            if (factor < 0)
            {
                factor = count;
            }
            List<Auto> auto = registerHandler.sortDataBase(factor);
            tbHinta.Text = auto[0].Hinta1.ToString();
            tbId.Text = auto[0].Id1.ToString();
            tbMittarilukema.Text = auto[0].Mittarilukema1.ToString();
            tbTilavuus.Text = auto[0].Moottorin_tilavuus1.ToString();
            cbMerkki.Text = auto[0].AutoMerkki1.ToString();
            cbMalli.Text = auto[0].AutoMalli1.ToString();
            cbVari.Text = auto[0].Vari1.ToString();
            cbPolttoaine.Text = auto[0].Polttoaine1.ToString();
            dtpPaiva.Value = auto[0].Rekisteri_paivamaara1;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);
            registerHandler.deleteItemInDataBase(id);
            cbPolttoaine.Text = null;
            cbVari.Text = null;
            cbMerkki.Text = null;
            cbMalli.Text = null;
            tbHinta.Clear();
            tbMittarilukema.Clear();
            tbTilavuus.Clear();
            tbId.Clear();
            dtpPaiva.Value = DateTime.Now;

        }
    }
}
