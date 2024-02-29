using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sio_shop
{
    public partial class fm_produit : Form
    {
        bool flag = true;
        public fm_produit()
        {
            InitializeComponent();
            info_produit(null);
            data_cb_marque();
        }

        private void info_produit(string p_marque)
        {
            int nb_pdt = 0;
            string sql = null;
            if (p_marque == null)
                sql = "SELECT * FROM produit order by 1";
            else
                sql = $"SELECT * FROM produit WHERE marque = '{p_marque}' order by 1";
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
                    //insertion listView
                    string[] row = new string[] { p1.Reference, p1.Marque, p1.Nom, p1.Prix.ToString() + " €", p1.Stock.ToString() };
                    var lvi = new ListViewItem(row);
                    // si stock à 0 on met une aide visuelle
                    if (p1.Stock == 0)
                        lvi.BackColor = Color.Red;
                    lv_produit.Items.Add(lvi);
                    nb_pdt++;
                }
            }
            lbl_nb.Text = $"Nombre de références : {nb_pdt}";
            reader.Close();
        }
        private void data_cb_marque()
        {
            string sql = "SELECT distinct marque from produit";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Program.BDDcnx;
            cmd.CommandText = sql;
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string bmarque = reader.GetString(0); // une seule colonne
                    cb_marque.Items.Add(bmarque);
                }
            }
            reader.Close();
        }
        private void Fm_produit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
                Environment.Exit(1);
        }

        private void Cb_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_produit.Items.Clear();
            info_produit(cb_marque.GetItemText(cb_marque.SelectedItem));
        }

        private void Bt_retour_Click(object sender, EventArgs e)
        {
            fm_menu fmm = new fm_menu();
            fmm.Show();
            flag = false;
            Close();
        }

        private void Lv_produit_DoubleClick(object sender, EventArgs e)
        {
            if (lv_produit.SelectedItems.Count != 0)
            {
                fm_details_pdt fmd = new fm_details_pdt(lv_produit.SelectedItems[0].SubItems[0].Text); // recupere le texte de la premiere colonne de la ligne selectionnée
                fmd.Show();
                flag = false;
                Close();
            }
        }

        private void Bt_new_Click(object sender, EventArgs e)
        {
            fm_details_pdt fmd = new fm_details_pdt(null); // recupere le texte de la premiere colonne de la ligne selectionnée
            fmd.Show();
            flag = false;
            Close();
        }
    }
}
