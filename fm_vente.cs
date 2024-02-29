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
    public partial class fm_vente : Form
    {
        bool flag = true;
        Produit pdt_achete;
        Client acheteur;
        public fm_vente()
        {
            InitializeComponent();
            load_combobox();
        }

        private void Bt_client_Click(object sender, EventArgs e)
        {
            fm_client fmc = new fm_client();
            fmc.ShowDialog();
        }
        private void load_combobox()
        {
            string sql = "SELECT * from client";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Client cli_generique = new Client(reader);
                    cb_client.Items.Add(cli_generique.print());
                }
            }
            reader.Close();
            sql = "SELECT * FROM produit;";
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {                    
                    Produit p1 = new Produit(reader); // creation objet grace aux données du reader
                    cb_produit.Items.Add(p1.print());
                }
            }
            reader.Close();
        }

        private void Cb_produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produit = cb_produit.GetItemText(cb_produit.SelectedItem);
            string reference = produit.Substring(0, produit.IndexOf('-')-1);
            string sql = $"SELECT * FROM produit where reference = {reference};";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Produit p1 = new Produit(reader); // creation objet grace aux données du reader
                    pdt_achete = p1;
                }
            }
            if (pdt_achete.Stock == 0)
            {
                bt_vente.Enabled = false;
                MessageBox.Show($"Le stock concernant {pdt_achete.Marque} {pdt_achete.Nom} est de zéro.\nVente impossible.", "Stock vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                bt_vente.Enabled = true;
            lbl_stock.Text = $"Stock avant vente : {pdt_achete.Stock}";
            tb_ht.Text = pdt_achete.Prix.ToString();
            tb_tva.Text = (double.Parse(tb_ht.Text) / 5).ToString();
            tb_ttc.Text = (double.Parse(tb_tva.Text) + double.Parse(tb_ht.Text)).ToString();
            reader.Close();
        }

        private void Fm_vente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
                Environment.Exit(1);
        }

        private void Bt_vente_Click(object sender, EventArgs e)
        {
            try
            {
                // RECUPERER ID MAX VENTE
                string sql = "SELECT MAX(id_achat) FROM pdt_achete;";
                string str_id = null;
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
                reader.Close();
                int id = int.Parse(str_id);
                id++;
                DateTime bdate = DateTime.Today;
                sql = $"INSERT INTO pdt_achete VALUES ({id}, {acheteur.Identifiant}, {pdt_achete.Reference}, '{bdate.Year.ToString()}-{bdate.Month}-{bdate.Day.ToString()}');";//DATE ACHAT
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery(); // permet d'executer la requete INSERT
                                       //***********************************************************
                sql = $"UPDATE produit SET stock = {pdt_achete.Stock - 1} WHERE reference = {pdt_achete.Reference};";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                //*********A REMPLACER PAR UN TRIGGER ***********************
                pdf.GeneratePDF(acheteur, pdt_achete, Program.emp, id);
                MessageBox.Show("Une facture a été générée.", "Vente saisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bt_retour_Click(sender, e);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Veillez à remplir tous les champs.\nErreur : {exc.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Bt_retour_Click(object sender, EventArgs e)
        {
            fm_menu fmm = new fm_menu();
            flag = false;
            fmm.Show();
            Close();
        }

        private void Cb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cli = cb_client.GetItemText(cb_client.SelectedItem);
            string id = cli.Substring(0, cli.IndexOf('-') - 1);
            string sql = $"SELECT * FROM client where num_client = {id};";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    acheteur = new Client(reader);
                }
            }
            reader.Close();
        }
    }
}
