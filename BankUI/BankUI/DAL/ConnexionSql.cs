using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.DAL
{
    internal class ConnexionSql
    {
        private static ConnexionSql connection = null;

        private MySqlConnection Conex;

        private static readonly object mylock = new object();

        private string connString;

        //Connnexion à la base de donnée

        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    Conex = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        //Méthode d'instance de connexion si elle n'existe pas 
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {


                if (null == connection)
                { // Premier appel
                    connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);


                }

            }
            catch (Exception emp)
            {
                throw (emp);


            }
            return connection;
        }

        public void openConnection()
        {

            if (Conex.State == System.Data.ConnectionState.Closed)
                Conex.Open();
        }

        //Close connection
        public void closeConnection()
        {
            if (Conex.State == System.Data.ConnectionState.Open)
                Conex.Close();
        }

        public bool isOpen()
        {
            bool res = false;
            if (Conex.State == System.Data.ConnectionState.Open) { res = true; }

            return (res);
        }
        //Fermeture de la connexion


        //Exécution d'une requête
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.Conex);
            return (mysqlCom);
        }
    }
}
