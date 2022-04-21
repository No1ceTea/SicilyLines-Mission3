using BankUI.Controleur;
using BankUI.DAL;
using BankUI.Modele;
using BankUI.Modele.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUI.Vue {

    public partial class LiaisonView : Form
    {

        private ConnexionSql maConnexionSql;

        private MySqlCommand Ocom;

        Manager monManager;

        public List<LiaisonView> listLiaison = new List<LiaisonView>();

        public LiaisonView()
        {
            InitializeComponent();
            monManager = new Manager();
        }

        private void LiaisonView_Load(object sender, EventArgs e)
        {

            listLiaison = monManager.chargementLBD();
            getPortDepart();
            if (listLiaison.Count != 0) { rafraichirListBox(0); }

        }

        //Actualisation de la listBox d'un certain index
        private void rafraichirListBox(int index)
        {

            LBLiaison.DataSource = null;
            LBLiaison.DataSource = listLiaison;
            LBLiaison.DisplayMember = "Description";
            LBLiaison.SetSelected(index, true);

        }
        //Actualisation de la listBox
        private void rafraichirListBox()
        {

            LBLiaison.DataSource = null;
            LBLiaison.DataSource = listLiaison;
            LBLiaison.DisplayMember = "Description";
            monManager.chargementLBD();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Confirmer et sauvegarder les modifications", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Serialise.sauvegarde(lstcpt);
                Application.Exit();
            }
        }


        private void CBportD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPortD = (string)CBportD.SelectedItem;

            getPortArrivee(selectedPortD);
        }

        private void BTNAjout_Click(object sender, EventArgs e)
        {
            TimeSpan duree;

            if (!(string.IsNullOrEmpty(CBportA.Text) && string.IsNullOrEmpty(CBportA.Text)))
            {
                try
                {
                    duree = TimeSpan.Parse(TBduree.Text);
                    monManager.addLiaison(CBportD.Text, CBportA.Text, duree);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                ExceptionsLiaison ex = new ExceptionsLiaison("Merci de bien vouloir selectionner les ports !");
                MessageBox.Show(ex.Message);
            }

            listLiaison = monManager.chargementLBD();
            rafraichirListBox();
        }

        private void BTNModif_Click(object sender, EventArgs e)
        {
            int i;
            i = LBLiaison.SelectedIndex;

            LiaisonView liaison = listLiaison[i];

            ModifLiaisonView modifLiaisonView = new ModifLiaisonView(liaison);

            modifLiaisonView.ShowDialog();
            monManager.updateLiaison(liaison);

            listLiaison = monManager.chargementLBD();

            rafraichirListBox(i);


        }

        private void BTNSuppr_Click(object sender, EventArgs e)
        {
            int i;
            i = LBLiaison.SelectedIndex;

            LiaisonView liaison = listLiaison[i];

            monManager.deleteLiaison(liaison);

            listLiaison = monManager.chargementLBD();

            rafraichirListBox();
        }

        private void getPortDepart()
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.nom from port");


                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    string portDepart = (string)reader.GetString("nom");

                    CBportD.Items.Add(portDepart);
                }


                reader.Close();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

        }

        //Obtenir port en fonction de celui de la fonction getPortDepart()
        private void getPortArrivee(string selectedPortD)
        {

            CBportA.Items.Clear();


            try
            {

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.nom from port where port.nom not in ('" + selectedPortD + "');");


                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    string portArrivee = (string)reader.GetString("nom");

                    CBportA.Items.Add(portArrivee);
                }



                reader.Close();

                maConnexionSql.closeConnection();


            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

        }

        private void LBLiaison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
