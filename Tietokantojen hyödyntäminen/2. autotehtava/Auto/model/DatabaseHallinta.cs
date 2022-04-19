
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Autokauppa.view;


namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
           yhteysTiedot = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True";
        }

        public List<Auto> SortAllDataBase(int i)
        {
            connectDatabase();
            DataTable AutoTable = new DataTable();
            SqlDataAdapter AutoAll = new SqlDataAdapter("SELECT * FROM auto LEFT OUTER JOIN AutonMallit ON AutonMallit.ID = auto.AutonMalliID " +
                                                        "LEFT OUTER JOIN AutonMerkki ON AutonMerkki.ID = auto.AutonMerkkiID " +
                                                        "LEFT OUTER JOIN Varit ON Varit.ID = auto.VaritID " +
                                                        "LEFT OUTER JOIN Polttoaine ON Polttoaine.ID = auto.PolttoaineID ORDER BY Hinta", dbYhteys);
            AutoAll.Fill(AutoTable);
            DataRow row = AutoTable.Rows[i];
            List<Auto> palaute = new List<Auto>();
            Auto auto = new Auto();
            auto.Id1 = int.Parse(row["ID"].ToString());
            auto.Hinta1 = decimal.Parse(row["Hinta"].ToString());
            auto.Rekisteri_paivamaara1 = DateTime.Parse(row["Rekisteri_paivamaara"].ToString());
            auto.Moottorin_tilavuus1 = decimal.Parse(row["Moottorin_tilavuus"].ToString());
            auto.Mittarilukema1 = int.Parse(row["Mittarilukema"].ToString());
            auto.AutoMerkki1 = row["Merkki"].ToString();
            auto.AutoMalli1 = row["Auton_mallin_nimi"].ToString();
            auto.Vari1 = row["Varin_nimi"].ToString();
            auto.Polttoaine1 = row["Polttoaineen_nimi"].ToString();
            palaute.Add(auto);
            disconnectDatabase();
            return palaute;
        }

        public int checkDataBaseCount()
        {
            connectDatabase();
            SqlCommand myCommand = new SqlCommand("Select count(*) from auto", dbYhteys);
            myCommand.CommandType = CommandType.Text;
            object count = myCommand.ExecuteScalar();
            int counter = int.Parse(count.ToString());
            disconnectDatabase();
            return counter;
        }

        public bool connectDatabase()
        {
            dbYhteys = new SqlConnection(yhteysTiedot);
            
            try
            { 
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            connectDatabase();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = dbYhteys;
            string format = "yyyy-MM-dd";
            myCommand.CommandText = (@"INSERT INTO auto (Hinta, Rekisteri_paivamaara, 
                                     Moottorin_tilavuus, Mittarilukema, AutonMerkkiID, AutonMalliID,
                                     VaritID, PolttoaineID) VALUES 
                                     ('" + newAuto.Hinta1 + "','" + newAuto.Rekisteri_paivamaara1.ToString(format) + "','" + newAuto.Moottorin_tilavuus1 + "','" +
                                     newAuto.Mittarilukema1 + "','" + newAuto.AutonMerkkiID1 + "','" + newAuto.AutonMalliID1 + "','" +
                                     newAuto.VaritID1 + "','" + newAuto.PolttoaineID1 + "')");

            myCommand.ExecuteNonQuery();

            bool palaute = false;
            disconnectDatabase();
            return palaute; 
        }

        public int DeleteInDataBase(int id)
        {
            connectDatabase();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = dbYhteys;
            myCommand.CommandText = ("DELETE FROM auto WHERE ID = " + id);
            myCommand.ExecuteNonQuery();
            disconnectDatabase();
            return id;
        }

        public List<AutonMerkki> GetAllAutoMakersFromDatabase()
        {
            DataTable AutoMakersTable = new DataTable();
            connectDatabase();
            SqlDataAdapter GetAllAutoMaker = new SqlDataAdapter("SELECT * FROM AutonMerkki", dbYhteys);
            GetAllAutoMaker.Fill(AutoMakersTable);
            List<AutonMerkki> palaute = new List<AutonMerkki>();

            foreach (DataRow Datarows in AutoMakersTable.Rows)
            {
                AutonMerkki automerkki = new AutonMerkki();
                automerkki.Merkki = Datarows["Merkki"].ToString();
                automerkki.ID = int.Parse(Datarows["ID"].ToString());
                palaute.Add(automerkki);
            }
            //List<AutonMerkki> palaute=null;
            disconnectDatabase();
            return palaute;

        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId)             
        {
            DataTable AutoModelTable = new DataTable();
            connectDatabase();
            SqlDataAdapter GetAllAutoModel = new SqlDataAdapter("SELECT * FROM AutonMallit", dbYhteys);
            GetAllAutoModel.Fill(AutoModelTable);
            List<AutonMalli> palaute = new List<AutonMalli>();
            foreach (DataRow Datarows in AutoModelTable.Rows)
            {
                if (makerId == int.Parse(Datarows["AutonMerkkiID"].ToString()))
                {
                    AutonMalli automalli = new AutonMalli();
                    automalli.Malli = Datarows["Auton_mallin_nimi"].ToString();
                    automalli.ID = int.Parse(Datarows["ID"].ToString());
                    palaute.Add(automalli);
                }
            }
            //List<int> palaute = null;
            disconnectDatabase();
            return palaute;
        }

        public List<Vari> getAllAutoVari()
        {
            DataTable AutoVariTable = new DataTable();
            connectDatabase();
            SqlDataAdapter GetAllAutoVari = new SqlDataAdapter("SELECT * FROM Varit", dbYhteys);
            GetAllAutoVari.Fill(AutoVariTable);
            List<Vari> palaute = new List<Vari>();
            foreach (DataRow Datarows in AutoVariTable.Rows)
            {
                Vari autovari = new Vari();
                autovari.VariNimi = Datarows["Varin_nimi"].ToString();
                autovari.ID = int.Parse(Datarows["ID"].ToString());
                palaute.Add(autovari);
            }
            //List<int> palaute = null;
            disconnectDatabase();
            return palaute;
        }

        public List<Polttoaine> getAllAutoPolttoaine()
        {
            DataTable AutoPolttoaineTable = new DataTable();
            connectDatabase();
            SqlDataAdapter GetAllAutoPolttoaine = new SqlDataAdapter("SELECT * FROM Polttoaine", dbYhteys);
            GetAllAutoPolttoaine.Fill(AutoPolttoaineTable);
            List<Polttoaine> palaute = new List<Polttoaine>();
            foreach (DataRow Datarows in AutoPolttoaineTable.Rows)
            {
                Polttoaine polttoaine = new Polttoaine();
                polttoaine.PolttoaineNimi = Datarows["Polttoaineen_nimi"].ToString();
                polttoaine.ID = int.Parse(Datarows["ID"].ToString());
                palaute.Add(polttoaine);
            }
            //List<int> palaute = null;
            disconnectDatabase();
            return palaute;
        }

    }
}
