namespace sio_shop
{
    partial class fm_details_pdt
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
            this.tb_modele = new System.Windows.Forms.TextBox();
            this.tb_ref = new System.Windows.Forms.TextBox();
            this.tb_marque = new System.Windows.Forms.TextBox();
            this.lbl_names = new System.Windows.Forms.Label();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_modele
            // 
            this.tb_modele.Location = new System.Drawing.Point(84, 84);
            this.tb_modele.Name = "tb_modele";
            this.tb_modele.Size = new System.Drawing.Size(201, 20);
            this.tb_modele.TabIndex = 8;
            // 
            // tb_ref
            // 
            this.tb_ref.Enabled = false;
            this.tb_ref.Location = new System.Drawing.Point(84, 6);
            this.tb_ref.Name = "tb_ref";
            this.tb_ref.ReadOnly = true;
            this.tb_ref.Size = new System.Drawing.Size(88, 20);
            this.tb_ref.TabIndex = 7;
            // 
            // tb_marque
            // 
            this.tb_marque.Location = new System.Drawing.Point(84, 44);
            this.tb_marque.Name = "tb_marque";
            this.tb_marque.Size = new System.Drawing.Size(201, 20);
            this.tb_marque.TabIndex = 6;
            // 
            // lbl_names
            // 
            this.lbl_names.AutoSize = true;
            this.lbl_names.BackColor = System.Drawing.Color.Transparent;
            this.lbl_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_names.Location = new System.Drawing.Point(12, 9);
            this.lbl_names.Name = "lbl_names";
            this.lbl_names.Size = new System.Drawing.Size(66, 169);
            this.lbl_names.TabIndex = 5;
            this.lbl_names.Text = "Référence\r\n\r\n\r\nMarque\r\n\r\n\r\nModele\r\n\r\n\r\nPrix (€)\r\n\r\n\r\nStock";
            // 
            // tb_prix
            // 
            this.tb_prix.Location = new System.Drawing.Point(84, 123);
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(119, 20);
            this.tb_prix.TabIndex = 9;
            // 
            // num_stock
            // 
            this.num_stock.Location = new System.Drawing.Point(84, 158);
            this.num_stock.Name = "num_stock";
            this.num_stock.Size = new System.Drawing.Size(72, 20);
            this.num_stock.TabIndex = 11;
            this.num_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(56, 223);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(170, 30);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Enregistrer modifications";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(15, 503);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 13;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.Bt_retour_Click);
            // 
            // fm_details_pdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 551);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.num_stock);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.tb_modele);
            this.Controls.Add(this.tb_ref);
            this.Controls.Add(this.tb_marque);
            this.Controls.Add(this.lbl_names);
            this.Name = "fm_details_pdt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Détails produit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_details_pdt_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_modele;
        private System.Windows.Forms.TextBox tb_ref;
        private System.Windows.Forms.TextBox tb_marque;
        private System.Windows.Forms.Label lbl_names;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.NumericUpDown num_stock;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_retour;
    }
}