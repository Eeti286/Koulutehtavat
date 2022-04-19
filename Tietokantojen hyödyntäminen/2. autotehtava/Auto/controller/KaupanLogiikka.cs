using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.view;
using Autokauppa.model;

namespace Autokauppa.controller
{


    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(model.Auto newAuto)
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> getAllAutoMakers()
        {

            return dbModel.GetAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> getAutoModels(int makerId) {

            return dbModel.getAutoModelsByMakerId(makerId);
        }

        public List<Vari> getAutoVari()
        {
            return dbModel.getAllAutoVari();
        }

        public List<Polttoaine> getAutoPolttoaine()
        {
            return dbModel.getAllAutoPolttoaine();
        }
        public int AllDatabaseRowCount()
        {
            return dbModel.checkDataBaseCount();
        }
        public List<Auto> sortDataBase(int i)
        {
            return dbModel.SortAllDataBase(i);
        }

        public int deleteItemInDataBase(int id)
        {
            return dbModel.DeleteInDataBase(id);
        }
    }
}
