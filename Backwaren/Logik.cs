using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backwaren
{
    class Logik
    {
        //Connection-Variables
        string query;
        OleDbCommand command;
        string connectionstring;
        OleDbConnection con;

        //DB-Lists
        BackwarenListe listeSuess = new BackwarenListe();
        BackwarenListe listeHerzhaft = new BackwarenListe();

        //DB-Variables
        string bezeichnung;
        decimal preis;
        int kalorien;
        bool herzhaft;

        public void LoadData()
        {
            connectionstring = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Backwaren.accdb";
            con = new OleDbConnection(connectionstring);
            query = "SELECT * FROM tblBackwaren";

            //Command to Read the db
            command = new OleDbCommand(query, con);

            try
            {
                //Open DB
                con.Open();

                //Execute command
                OleDbDataReader reader = command.ExecuteReader();

                //Read DB
                while (reader.Read())
                {
                    //Read Data from Row
                    bezeichnung = reader.GetString(1);
                    preis = reader.GetDecimal(2);
                    kalorien = reader.GetInt32(3);
                    herzhaft = reader.GetBoolean(4);

                    addToList();
                }
                DatenAnzeigen();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Add Dataset to List
        /// </summary>
        private void addToList()
        {
            if (herzhaft == true)
            {
                listeHerzhaft.Add(new Backware(bezeichnung, preis, kalorien));
            }
            else
            {
                listeSuess.Add(new Backware(bezeichnung, preis, kalorien));
            }
        }

        public BackwarenListe getListeSuess(){
            return listeSuess;
        }
        public BackwarenListe getListeHerzhaft()
        {
            return listeHerzhaft;
        }
    }
}
