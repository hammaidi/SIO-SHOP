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
    public partial class fm_details_pdt : Form
    {
        bool flag = true;
        public fm_details_pdt(string p_ref)
        {
            InitializeComponent();
            if (p_ref != null)
            {
                load_pdt(p_ref);
            }
            else
                load_id();
        }

        private void load_pdt(string p_ref)
        {
            string sql = $"Select * from produit where reference = {p_ref} ;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //creation d'objet produit // creation tuple // ajout liste
                    Produit p1 = new Produit(reader);
                    tb_ref.Text = p1.Reference;
                    tb_marque.Text = p1.Marque;
                    tb_modele.Text = p1.Nom;
                    tb_prix.Text = p1.Prix.ToString();
                    num_stock.Value = p1.Stock;
                    if (p1.Stock == 0)
                        num_stock.BackColor = Color.Red;
                }
            }
            reader.Close();
        }

        private void Bt_retour_Click(object sender, EventArgs e)
        {
            fm_produit fmp = new fm_produit();
            flag = false;
            fmp.Show();
            Close();
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            string sql = null;
            if (bt_save.Text != "Enregistrer produit")
            {
                sql = $"UPDATE produit SET " +
                    $"marque = '{tb_marque.Text}', " +
                    $"nom = '{tb_modele.Text}', " +
                    $"prix = {tb_prix.Text}, " +
                    $"stock = {num_stock.Value} " +
                    $"WHERE reference = {tb_ref.Text};";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Program.BDDcnx;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery(); // permet d'executer la requete
            }
            else
            {
                sql = $"INSERT INTO produit VALUES ({tb_ref.Text}, '{tb_marque.Text}', '{tb_modele.Text}', {tb_prix.Text}, {num_stock.Value});";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Program.BDDcnx;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery(); // permet d'executer la requete
            }
            Bt_retour_Click(sender, e);
        }
        private void load_id()
        {
            string sql = "SELECT MAX(reference) FROM produit;";
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
            tb_ref.Text = id.ToString();
            bt_save.Text = "Enregistrer produit";
        }

        private void Fm_details_pdt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
                Environment.Exit(1);
        }
    }
}
