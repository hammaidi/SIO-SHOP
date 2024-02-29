using MySql.Data.MySqlClient; // A AJOUTER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sio_shop
{
    static class Program
    {
        public static MySqlConnection BDDcnx; // connexion globale
        public static Employe emp;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                BDDcnx = bddLink.GetDBConnection();
                BDDcnx.Open();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                fm_cnx fmc = new fm_cnx();
                fmc.Show();
                Application.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion à la base de données.\nDétails : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
