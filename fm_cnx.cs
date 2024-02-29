using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // A AJOUTER
using System.Data.Common; // A AJOUTER

namespace sio_shop
{
    public partial class fm_cnx : Form
    {
        bool flag = true;
        public fm_cnx()
        {
            InitializeComponent(); 
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string mdp = tb_mdp.Text;
            bool ResCnx = false;
            string sql = "Select * from employe";
            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();
            // Établissez la connexion de la commande.
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int iLogin = reader.GetOrdinal("login");
                    int iMdp = reader.GetOrdinal("mdp");
                    string BDDid = reader.GetString(0);
                    string BDDlogin = reader.GetString(iLogin);
                    string BDDpass = reader.GetString(iMdp);
                    if (login == BDDlogin && mdp == BDDpass)
                    {
                        ResCnx = true;
                        reader.Close();
                        Employe e1 = new Employe(Program.BDDcnx, BDDid);
                        Program.emp = e1;
                        fm_menu menu = new fm_menu();
                        flag = false; // ce n'est pas une fermeture en cliquant sur la croix donc
                        menu.Show();
                        Close();
                        break;
                    }
                }
            }
            reader.Close(); //fin de la lecture des enregistrement si on est connecté
            if (!ResCnx)
                MessageBox.Show("Erreur d'authentification" , "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Fm_cnx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                Environment.Exit(0);
            }
        }
    }
}
