namespace sio_shop
{
    partial class fm_produit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_retour = new System.Windows.Forms.Button();
            this.lv_produit = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_marque = new System.Windows.Forms.ComboBox();
            this.lbl_marque = new System.Windows.Forms.Label();
            this.lbl_recherche = new System.Windows.Forms.Label();
            this.lbl_nb = new System.Windows.Forms.Label();
            this.bt_new = new System.Windows.Forms.Button();
            this.FD_open = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(12, 497);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 4;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.Bt_retour_Click);
            // 
            // lv_produit
            // 
            this.lv_produit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Marque,
            this.Modele,
            this.prix,
            this.Stock});
            this.lv_produit.FullRowSelect = true;
            this.lv_produit.GridLines = true;
            this.lv_produit.HideSelection = false;
            this.lv_produit.Location = new System.Drawing.Point(12, 47);
            this.lv_produit.Name = "lv_produit";
            this.lv_produit.Size = new System.Drawing.Size(535, 421);
            this.lv_produit.TabIndex = 5;
            this.lv_produit.UseCompatibleStateImageBehavior = false;
            this.lv_produit.View = System.Windows.Forms.View.Details;
            this.lv_produit.DoubleClick += new System.EventHandler(this.Lv_produit_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 43;
            // 
            // Marque
            // 
            this.Marque.Text = "Marque";
            this.Marque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marque.Width = 109;
            // 
            // Modele
            // 
            this.Modele.Text = "Modele";
            this.Modele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Modele.Width = 144;
            // 
            // prix
            // 
            this.prix.Text = "Prix";
            this.prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prix.Width = 128;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stock.Width = 105;
            // 
            // cb_marque
            // 
            this.cb_marque.FormattingEnabled = true;
            this.cb_marque.Location = new System.Drawing.Point(684, 103);
            this.cb_marque.Name = "cb_marque";
            this.cb_marque.Size = new System.Drawing.Size(188, 21);
            this.cb_marque.TabIndex = 6;
            this.cb_marque.SelectedIndexChanged += new System.EventHandler(this.Cb_marque_SelectedIndexChanged);
            // 
            // lbl_marque
            // 
            this.lbl_marque.AutoSize = true;
            this.lbl_marque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marque.Location = new System.Drawing.Point(587, 104);
            this.lbl_marque.Name = "lbl_marque";
            this.lbl_marque.Size = new System.Drawing.Size(66, 15);
            this.lbl_marque.TabIndex = 7;
            this.lbl_marque.Text = "MARQUE";
            // 
            // lbl_recherche
            // 
            this.lbl_recherche.AutoSize = true;
            this.lbl_recherche.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recherche.Location = new System.Drawing.Point(632, 58);
            this.lbl_recherche.Name = "lbl_recherche";
            this.lbl_recherche.Size = new System.Drawing.Size(183, 18);
            this.lbl_recherche.TabIndex = 8;
            this.lbl_recherche.Text = "Recherche approfondie";
            // 
            // lbl_nb
            // 
            this.lbl_nb.AutoSize = true;
            this.lbl_nb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb.Location = new System.Drawing.Point(9, 18);
            this.lbl_nb.Name = "lbl_nb";
            this.lbl_nb.Size = new System.Drawing.Size(47, 15);
            this.lbl_nb.TabIndex = 10;
            this.lbl_nb.Text = "label2";
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(635, 224);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(170, 36);
            this.bt_new.TabIndex = 11;
            this.bt_new.Text = "Nouveau produit";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.Bt_new_Click);
            // 
            // fm_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.lbl_nb);
            this.Controls.Add(this.lbl_recherche);
            this.Controls.Add(this.lbl_marque);
            this.Controls.Add(this.cb_marque);
            this.Controls.Add(this.lv_produit);
            this.Controls.Add(this.bt_retour);
            this.Name = "fm_produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Gestion produits";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_produit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.ListView lv_produit;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Modele;
        private System.Windows.Forms.ColumnHeader prix;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ComboBox cb_marque;
        private System.Windows.Forms.Label lbl_marque;
        private System.Windows.Forms.Label lbl_recherche;
        private System.Windows.Forms.Label lbl_nb;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.OpenFileDialog FD_open;
    }
}