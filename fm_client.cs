using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sio_shop
{
    public partial class fm_client : Form
    {
        bool flag = true;
        public fm_client()
        {
            InitializeComponent();
            data_load("");
        }

        private void Fm_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                Environment.Exit(1);
            }
        }

        private void Lv_clients_DoubleClick(object sender, EventArgs e)
        {
            if (lv_clients.SelectedItems.Count != 0)
            {
                fm_details fmd = new fm_details(lv_clients.SelectedItems[0].SubItems[0].Text); // recupere le texte de la premiere colonne de la ligne selectionnée
                fmd.Show();
                flag = false;
                Close();
            }
        }

        private void Bt_retour_Click(object sender, EventArgs e)
        {
            fm_menu fmm = new fm_menu();
            fmm.Show();
            flag = false;
            Close();
        }
        private void data_load(string pnom)
        {
            string sql = null;
            if (pnom == null)
                sql = "Select * from client order by num_client;";
            else
                sql = $"Select * from client where nom LIKE '{pnom}%' order by num_client;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Client cli_generique = new Client(reader);
                    string[] row = new string[] { cli_generique.Identifiant, cli_generique.Nom, cli_generique.Prenom, cli_generique.Tel, cli_generique.Mail, cli_generique.Adresse };
                    var lvi = new ListViewItem(row);
                    lv_clients.Items.Add(lvi);
                }
            }
            reader.Close();
        }
        private void Tb_search_TextChanged(object sender, EventArgs e)
        {
            lv_clients.Items.Clear();
            data_load(tb_search.Text);
        }

        private void Bt_new_Click(object sender, EventArgs e)
        {
            fm_details fmd = new fm_details(null); // recupere le texte de la premiere colonne de la ligne selectionnée
            fmd.Show();
            flag = false;
            Close();
        }
    }
}
