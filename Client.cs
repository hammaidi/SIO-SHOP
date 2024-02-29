using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sio_shop
{
    class Client : Personne
    {
        public List<Tuple<Produit, DateTime>> Lst_pdt_achete { get; set; }
        // tuple pour avoir une liste avec type 1 lié à type 2; on a donc une liste de Tuples
        public Client(string identifiant, string nom, string prenom, string adresse, string mail, string tel)
            : base(identifiant, nom, prenom, adresse, mail, tel)
        {
            Lst_pdt_achete = new List<Tuple<Produit, DateTime>>();
        }
        public Client()
        {
            Identifiant = null;
            Nom = null;
            Prenom = null;
            Adresse = null;
            Mail = null;
            Tel = null;
            Lst_pdt_achete = new List<Tuple<Produit, DateTime>>();
        }
        public Client(DbDataReader reader)
        {
            int iID = reader.GetOrdinal("num_client");
            int inom = reader.GetOrdinal("nom");
            int iPrenom = reader.GetOrdinal("prenom");
            int iAdresse = reader.GetOrdinal("adresse");
            int iMail = reader.GetOrdinal("mail");
            int iTel = reader.GetOrdinal("tel");
            Identifiant = reader.GetString(iID);
            Nom = reader.GetString(inom);
            Prenom = reader.GetString(iPrenom);
            Adresse = reader.GetString(iAdresse);
            Mail = reader.GetString(iMail);
            Tel = reader.GetString(iTel);
        }
        public string print()
        {
            return Identifiant + " - " + Nom + " - " + Prenom + " - " + Tel + " - " + Adresse;
        }
        /*public static void getAllClients(MySqlConnection BDDcnx)
        {
            string sql = "Select * from client order by num_client;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    int iID = reader.GetOrdinal("num_client");
                    int inom = reader.GetOrdinal("nom");
                    int iPrenom = reader.GetOrdinal("prenom");
                    int iAdresse = reader.GetOrdinal("adresse");
                    int iMail = reader.GetOrdinal("mail");
                    int iTel = reader.GetOrdinal("tel");
                    string bID = reader.GetString(iID);
                    string bnom = reader.GetString(inom);
                    string bPrenom = reader.GetString(iPrenom);
                    string bAdresse = reader.GetString(iAdresse);
                    string bMail = reader.GetString(iMail);
                    string bTel = reader.GetString(iTel);
                    Client cli_generique = new Client(bID, bnom, bPrenom, bAdresse, bMail, bTel);
                    cli_generique.print();
                }
            }
            reader.Close();
        }
        public static Client getClient(MySqlConnection BDDcnx, string nom, string prenom)
        {
            Client cli_generique = new Client();
            string sql = $"Select * from client where nom = '{nom}' and prenom = '{prenom}' order by num_client;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n--------------------------------------------------------------------------------------");
                    int iID = reader.GetOrdinal("num_client");
                    int inom = reader.GetOrdinal("nom");
                    int iPrenom = reader.GetOrdinal("prenom");
                    int iAdresse = reader.GetOrdinal("adresse");
                    int iMail = reader.GetOrdinal("mail");
                    int iTel = reader.GetOrdinal("tel");
                    string bID = reader.GetString(iID);
                    string bnom = reader.GetString(inom);
                    string bPrenom = reader.GetString(iPrenom);
                    string bAdresse = reader.GetString(iAdresse);
                    string bMail = reader.GetString(iMail);
                    string bTel = reader.GetString(iTel);
                    cli_generique = new Client(bID, bnom, bPrenom, bAdresse, bMail, bTel);
                }
            }
            else //recherche non concluante
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAucun résultat.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            reader.Close();
            return cli_generique;
        }

        public static Client getClient(MySqlConnection BDDcnx, int pid)
        {
            Client cli_generique = new Client();
            // création du client dont on veut l'historique
            string sql = $"Select * from client where num_client = {pid};";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n--------------------------------------------------------------------------------------");
                    int iID = reader.GetOrdinal("num_client");
                    int inom = reader.GetOrdinal("nom");
                    int iPrenom = reader.GetOrdinal("prenom");
                    int iAdresse = reader.GetOrdinal("adresse");
                    int iMail = reader.GetOrdinal("mail");
                    int iTel = reader.GetOrdinal("tel");
                    string bID = reader.GetString(iID);
                    string bnom = reader.GetString(inom);
                    string bPrenom = reader.GetString(iPrenom);
                    string bAdresse = reader.GetString(iAdresse);
                    string bMail = reader.GetString(iMail);
                    string bTel = reader.GetString(iTel);
                    cli_generique = new Client(bID, bnom, bPrenom, bAdresse, bMail, bTel);
                }
            }
            reader.Close();
            return cli_generique;
        }
        public void getHistorique(MySqlConnection BDDcnx)
        {
            print();
            Lst_pdt_achete = Produit.getPdtAchetes(BDDcnx, this); // this
            Console.WriteLine("\n---------------------- Historique d'achat ----------------------\n");
            for (int i = 0; i < Lst_pdt_achete.Count; i++)
            {
                Console.WriteLine("Produit : " + Lst_pdt_achete[i].Item1.Marque);
                Console.WriteLine("Date achat : " + Lst_pdt_achete[i].Item2.Date + "\n");

            }
            Console.ReadKey();
        }*/
    }
}
