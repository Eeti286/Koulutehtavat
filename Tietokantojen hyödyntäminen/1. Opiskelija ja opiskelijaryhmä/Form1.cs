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

namespace _1.Opiskelija_ja_opiskelijaryhmä
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Opiskelija_ja_opiskelijaryhma;Integrated Security=True"); 
        string selectedId;
        public Form1()
        {
            InitializeComponent();

            myConnection.Open();
            updateTable();
            myConnection.Close();

        }

        private void updateTable()
        {
            DataTable OpiskelijaTable = new DataTable();
            SqlCommand myCommand = new SqlCommand();
            SqlDataAdapter OpiskelijaAll = new SqlDataAdapter("SELECT Opiskelija.*, Opiskelijaryhmä.RyhmaNimi FROM Opiskelija, Opiskelijaryhmä WHERE Opiskelija.Ryhma = Opiskelijaryhmä.Id", myConnection);
            OpiskelijaAll.Fill(OpiskelijaTable);
            dataGridView1.DataSource = OpiskelijaTable;

            DataTable OpiskelijaryhmaTable = new DataTable();
            SqlDataAdapter RyhmanNimi = new SqlDataAdapter("SELECT * FROM [dbo].[Opiskelijaryhmä]", myConnection);
            RyhmanNimi.Fill(OpiskelijaryhmaTable);
            DataRow row = OpiskelijaryhmaTable.NewRow();
            comboBox1.DataSource = OpiskelijaryhmaTable;
            comboBox1.DisplayMember = "RyhmaNimi";
            comboBox1.ValueMember = "Id";

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lisää_button_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand();
            myConnection.Open();        
            string etunimi = etunimi_textBox.Text;
            string sukunimi = sukunimi_textBox.Text;
            int ryhma = int.Parse(comboBox1.SelectedValue.ToString());

            nameClass add = new nameClass(etunimi, sukunimi, ryhma);
            myCommand.Connection = myConnection;
            myCommand.CommandText = (@"INSERT INTO [dbo].[Opiskelija] (etunimi,sukunimi, ryhma) 
                    VALUES ('" + add.Etunimi + "','" + add.Sukunimi + "','" + add.Ryhma + "')");

            myCommand.ExecuteNonQuery();
            updateTable();
            myConnection.Close();

        }

        private void poista_button_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = ("DELETE FROM [dbo].[Opiskelija] WHERE Id = " + selectedId);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            updateTable();
            myConnection.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = row.Cells[0].Value.ToString();
            }
        }

        private void etunimi_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
