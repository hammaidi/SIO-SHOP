using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace sio_shop
{
    public class Employe : Personne
    {
        public string Login { get; set; }
        public string Mdp { get; set; }
        public Employe(string identifiant, string nom, string prenom, string adresse, string mail, string tel, string login, string mdp)
            : base(identifiant, nom, prenom, adresse, mail, tel)
        {
            Login = login;
            Mdp = mdp;
        }
        public Employe(MySqlConnection BDDcnx, string p_id) // permet de creer un employe à partir de son ID
        {
            string sql = "SELECT * FROM employe WHERE matricule = '" + p_id + "';";
            MySqlCommand cmd = new MySqlCommand();
            // Établissez la connexion de la commande.
            cmd.Connection = BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int iID = reader.GetOrdinal("matricule");
                    int inom = reader.GetOrdinal("nom");
                    int iPrenom = reader.GetOrdinal("prenom");
                    int iAdresse = reader.GetOrdinal("adresse");
                    int iMail = reader.GetOrdinal("mail");
                    int iTel = reader.GetOrdinal("tel");
                    int iLogin = reader.GetOrdinal("Login");
                    int iMdp = reader.GetOrdinal("mdp");
                    string bID = reader.GetString(iID);
                    string bnom = reader.GetString(inom);
                    string bPrenom = reader.GetString(iPrenom);
                    string bAdresse = reader.GetString(iAdresse);
                    string bMail = reader.GetString(iMail);
                    string bTel = reader.GetString(iTel);
                    string bLogin = reader.GetString(iLogin);
                    string bMdp = reader.GetString(iMdp);
                    Identifiant = bID;
                    Nom = bnom;
                    Prenom = bPrenom;
                    Adresse = bAdresse;
                    Mail = bMail;
                    Tel = bTel;
                    Login = bLogin;
                    Mdp = bMdp;
                }
            }
            reader.Close();
        }
        public Employe()
        {
            Identifiant = null;
            Nom = null;
            Prenom = null;
            Adresse = null;
            Mail = null;
            Tel = null;
            Login = null;
            Mdp = null;
        }
    }
}
