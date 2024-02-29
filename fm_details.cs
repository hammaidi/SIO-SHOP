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
using MySql.Data.MySqlClient;

namespace sio_shop
{
    public partial class fm_details : Form
    {
        bool flag = true;
        public fm_details(string p_IDclient)
        {
            InitializeComponent();
            if (p_IDclient != null)
            {
                info_client(p_IDclient);
                pdt_client(p_IDclient);
            }
            else
                load_id();
        }

        private void Bt_retour_Click(object sender, EventArgs e)
        {
            fm_client fmc = new fm_client();
            fmc.Show();
            flag = false;
            Close();
        }

        // fonction créées pour améliorer la lisibilité
        private void info_client(string id)
        {
            string sql = $"Select * from client where num_client = {id} ;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Client cli_generique = new Client(reader);
                    tb_id.Text = cli_generique.Identifiant;
                    tb_nom.Text = cli_generique.Nom;
                    tb_prenom.Text = cli_generique.Prenom;
                    tb_tel.Text = cli_generique.Tel;
                    tb_mail.Text = cli_generique.Mail;
                    tb_adresse.Text = cli_generique.Adresse;
                }
            }
            reader.Close();
        }
        private void pdt_client (string id)
        {
            double prix_total = 0;
            string sql = $"select produit.*, pdt_achete.date_achat FROM produit JOIN pdt_achete ON produit.reference = pdt_achete.REFERENCE where pdt_achete.Num_client = {id} order by date_achat DESC;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idate = reader.GetOrdinal("date_achat");
                    DateTime bdate = DateTime.Parse(reader.GetString(idate));
                    //creation d'objet produit // creation tuple // ajout liste

                    Produit p1 = new Produit(reader);
                    prix_total += p1.Prix;
                    //insertion listView
                    string[] row = new string[] { bdate.Day.ToString() + '/' + bdate.Month + '/' + bdate.Year.ToString(), p1.Reference, p1.Marque, p1.Nom, p1.Prix.ToString() + " €" };
                    var lvi = new ListViewItem(row);
                    lv_pdt.Items.Add(lvi);
                }
            }
            reader.Close();
            lbl_tt.Text = $"Montant total : {prix_total} €";
        }

        private void Fm_details_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
                Environment.Exit(1);
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            string sql = null;
            if (bt_update.Text != "Enregistrer client")
            {
                sql = $"UPDATE client SET " +
                 $"nom = '{tb_nom.Text}', " +
                 $"prenom = '{tb_prenom.Text}', " +
                 $"adresse = '{tb_adresse.Text}', " +
                 $"mail = '{tb_mail.Text}', " +
                 $"tel = '{tb_tel.Text}' " +
                 $"WHERE num_client = {tb_id.Text};";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Program.BDDcnx;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery(); // permet d'executer la requete
            }
            else
            {
                sql = $"INSERT INTO client VALUES ({tb_id.Text}, '{tb_nom.Text}', '{tb_prenom.Text}', '{tb_adresse.Text}', '{tb_mail.Text}', '{tb_tel.Text}');";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Program.BDDcnx;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery(); // permet d'executer la requete
            }
            Bt_retour_Click(sender, e);
        }
        private void load_id()
        {
            string sql = "SELECT MAX(num_client) FROM client;";
            string str_id = null;
            int id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    str_id = reader.GetString(0);
                }
            }
            id = int.Parse(str_id);
            id++;
            reader.Close();
            tb_id.Text = id.ToString();
            bt_update.Text = "Enregistrer client";
        }
    }
}
