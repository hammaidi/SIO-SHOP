using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // DLL A AJOUTER

namespace sio_shop
{
    class bddLink
    {
        public static MySqlConnection GetDBConnection() // static pour l'appeler sans déclaration
        {
            // Paramètres de connexion
            string host = "127.0.0.1";
            string database = "db_magasin";
            string username = "root";
            string password = "";
            string ssl = "None";
            //--------------------------------------------
            // Requête pour se connecter
            //--------------------------------------------
            string connString = "Server=" + host + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";SslMode=" + ssl;
            MySqlConnection cnx = new MySqlConnection(connString);
            return cnx;
        }
    }
}
