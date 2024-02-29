namespace sio_shop
{
    partial class fm_vente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ht = new System.Windows.Forms.TextBox();
            this.tb_tva = new System.Windows.Forms.TextBox();
            this.tb_ttc = new System.Windows.Forms.TextBox();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.cb_produit = new System.Windows.Forms.ComboBox();
            this.lbl_devise = new System.Windows.Forms.Label();
            this.bt_vente = new System.Windows.Forms.Button();
            this.bt_retour = new System.Windows.Forms.Button();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 221);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client (ID)\r\n\r\n\r\nProduit (REF)\r\n\r\n\r\nPRIX (HT)\r\n\r\n\r\nTVA (20%)\r\n\r\n\r\nPRIX TTC ";
            // 
            // tb_ht
            // 
            this.tb_ht.Enabled = false;
            this.tb_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ht.Location = new System.Drawing.Point(140, 124);
            this.tb_ht.Name = "tb_ht";
            this.tb_ht.Size = new System.Drawing.Size(211, 20);
            this.tb_ht.TabIndex = 3;
            this.tb_ht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_tva
            // 
            this.tb_tva.Enabled = false;
            this.tb_tva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tva.Location = new System.Drawing.Point(140, 177);
            this.tb_tva.Name = "tb_tva";
            this.tb_tva.Size = new System.Drawing.Size(211, 20);
            this.tb_tva.TabIndex = 4;
            this.tb_tva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_ttc
            // 
            this.tb_ttc.Enabled = false;
            this.tb_ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ttc.Location = new System.Drawing.Point(140, 224);
            this.tb_ttc.Name = "tb_ttc";
            this.tb_ttc.Size = new System.Drawing.Size(211, 20);
            this.tb_ttc.TabIndex = 5;
            this.tb_ttc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(140, 23);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(583, 21);
            this.cb_client.TabIndex = 6;
            this.cb_client.SelectedIndexChanged += new System.EventHandler(this.Cb_client_SelectedIndexChanged);
            // 
            // cb_produit
            // 
            this.cb_produit.FormattingEnabled = true;
            this.cb_produit.Location = new System.Drawing.Point(140, 75);
            this.cb_produit.Name = "cb_produit";
            this.cb_produit.Size = new System.Drawing.Size(583, 21);
            this.cb_produit.TabIndex = 7;
            this.cb_produit.SelectedIndexChanged += new System.EventHandler(this.Cb_produit_SelectedIndexChanged);
            // 
            // lbl_devise
            // 
            this.lbl_devise.AutoSize = true;
            this.lbl_devise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_devise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devise.Location = new System.Drawing.Point(357, 127);
            this.lbl_devise.Name = "lbl_devise";
            this.lbl_devise.Size = new System.Drawing.Size(14, 117);
            this.lbl_devise.TabIndex = 8;
            this.lbl_devise.Text = "€\r\n\r\n\r\n\r\n€\r\n\r\n\r\n\r\n€";
            // 
            // bt_vente
            // 
            this.bt_vente.Location = new System.Drawing.Point(30, 279);
            this.bt_vente.Name = "bt_vente";
            this.bt_vente.Size = new System.Drawing.Size(181, 28);
            this.bt_vente.TabIndex = 9;
            this.bt_vente.Text = "Saisir vente";
            this.bt_vente.UseVisualStyleBackColor = true;
            this.bt_vente.Click += new System.EventHandler(this.Bt_vente_Click);
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(30, 503);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 10;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.Bt_retour_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(30, 328);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(153, 17);
            this.lbl_stock.TabIndex = 11;
            this.lbl_stock.Text = "Stock avant vente : ";
            // 
            // fm_vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 553);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.bt_vente);
            this.Controls.Add(this.lbl_devise);
            this.Controls.Add(this.cb_produit);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.tb_ttc);
            this.Controls.Add(this.tb_tva);
            this.Controls.Add(this.tb_ht);
            this.Controls.Add(this.label1);
            this.Name = "fm_vente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Saisir une vente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_vente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ht;
        private System.Windows.Forms.TextBox tb_tva;
        private System.Windows.Forms.TextBox tb_ttc;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.ComboBox cb_produit;
        private System.Windows.Forms.Label lbl_devise;
        private System.Windows.Forms.Button bt_vente;
        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.Label lbl_stock;
    }
}