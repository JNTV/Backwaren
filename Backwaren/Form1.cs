using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Backwaren
{
    public partial class Backwaren : Form
    {
        Logik logik = new Logik();
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

        public Backwaren()
        {
            InitializeComponent();
        }

        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            logik.LoadData();
        }

        /// <summary>
        /// Connect dgv with equal lists and show average calories
        /// </summary>
        private void DatenAnzeigen()
        {
            //Add lists to DataGridViews
            dgvHearty.DataSource = null;
            dgvSweet.DataSource = null;
            dgvHearty.DataSource = listeHerzhaft;
            dgvSweet.DataSource = listeSuess;

            //Calculate averge calories
            txtCaloriesHearty.Text = listeHerzhaft.Durchschnitt().ToString();
            txtCaloriesSweet.Text = listeSuess.Durchschnitt().ToString();
        }

        private void cmdNewEntry_Click(object sender, EventArgs e)
        {
            CreateEntry();
        }

        /// <summary>
        /// New DB-Entry
        /// </summary>
        private void CreateEntry()
        {
            try
            {
                //read Data from GUI
                bezeichnung = txtName.Text;
                preis = Convert.ToDecimal(txtPrice.Text);
                kalorien = Convert.ToInt32(txtCalories.Text);
                herzhaft = cbHearty.Checked;
                if (String.IsNullOrEmpty(bezeichnung))
                {
                    throw new ArgumentException("No label given");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Fehler!" + Environment.NewLine + "Eingabe unvollständig oder fehlerhaft!");
                return;
            }

            addToList();
            
            //Show new Dataset in dgv
            DatenAnzeigen();

            //Command to write new Dataset in db
            query = String.Format("INSERT INTO tblBackwaren (Bezeichnung, Preis, Kalorien, Herzhaft) VALUES ('{0}','{1}','{2}',{3})", bezeichnung, preis, kalorien, herzhaft);
            command.CommandText = query;

            //Write new Dataset in db
            try
            {
                //Open db and Execute Command
                con.Open();
                command.ExecuteNonQuery();

                //Reseting textboxes
                txtCalories.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                cbHearty.Checked = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //Close db
                con.Close();
            }
        }
    }
}
