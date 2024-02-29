using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sio_shop
{
    public partial class fm_menu : Form
    {
        bool flag = true;
        public fm_menu()
        {
            InitializeComponent();
            lbl_emp.Text = Program.emp.Nom + "\nMATRICULE : " + Program.emp.Identifiant;
        }

        private void Fm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                Environment.Exit(1);
            }
        }

        private void Bt_client_Click(object sender, EventArgs e)
        {
            fm_client fmc = new fm_client();
            fmc.Show();
            flag = false;
            Close();
        }

        private void Bt_produit_Click(object sender, EventArgs e)
        {
            fm_produit fmp = new fm_produit();
            fmp.Show();
            flag = false;
            Close();
        }

        private void Bt_dcnx_Click(object sender, EventArgs e)
        {
            fm_cnx fmc = new fm_cnx();
            fmc.Show();
            flag = false;
            Close();
        }

        private void Bt_vente_Click(object sender, EventArgs e)
        {
            fm_vente fmv = new fm_vente();
            fmv.Show();
            flag = false;
            Close();
        }
    }
}
