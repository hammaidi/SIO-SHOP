namespace sio_shop
{
    partial class fm_details
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
            this.lbl_names = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.lbl_names2 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.bt_retour = new System.Windows.Forms.Button();
            this.lv_pdt = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_tt = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_names
            // 
            this.lbl_names.AutoSize = true;
            this.lbl_names.BackColor = System.Drawing.Color.Transparent;
            this.lbl_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_names.Location = new System.Drawing.Point(12, 9);
            this.lbl_names.Name = "lbl_names";
            this.lbl_names.Size = new System.Drawing.Size(49, 91);
            this.lbl_names.TabIndex = 0;
            this.lbl_names.Text = "ID\r\n\r\n\r\nNom\r\n\r\n\r\nPrénom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(78, 45);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(165, 20);
            this.tb_nom.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(78, 6);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(52, 20);
            this.tb_id.TabIndex = 3;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(78, 80);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(165, 20);
            this.tb_prenom.TabIndex = 4;
            // 
            // lbl_names2
            // 
            this.lbl_names2.AutoSize = true;
            this.lbl_names2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_names2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_names2.Location = new System.Drawing.Point(326, 9);
            this.lbl_names2.Name = "lbl_names2";
            this.lbl_names2.Size = new System.Drawing.Size(67, 91);
            this.lbl_names2.TabIndex = 5;
            this.lbl_names2.Text = "Téléphone\r\n\r\n\r\nEmail\r\n\r\n\r\nAdresse";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(404, 80);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(400, 20);
            this.tb_adresse.TabIndex = 8;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(404, 6);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(199, 20);
            this.tb_tel.TabIndex = 7;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(404, 45);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(400, 20);
            this.tb_mail.TabIndex = 6;
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(15, 514);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 9;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.Bt_retour_Click);
            // 
            // lv_pdt
            // 
            this.lv_pdt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.reference,
            this.marque,
            this.nomart,
            this.Prix});
            this.lv_pdt.GridLines = true;
            this.lv_pdt.HideSelection = false;
            this.lv_pdt.Location = new System.Drawing.Point(15, 220);
            this.lv_pdt.Name = "lv_pdt";
            this.lv_pdt.Size = new System.Drawing.Size(857, 275);
            this.lv_pdt.TabIndex = 10;
            this.lv_pdt.UseCompatibleStateImageBehavior = false;
            this.lv_pdt.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 102;
            // 
            // reference
            // 
            this.reference.Text = "Référence";
            this.reference.Width = 218;
            // 
            // marque
            // 
            this.marque.Text = "Marque";
            this.marque.Width = 269;
            // 
            // nomart
            // 
            this.nomart.Text = "Article";
            this.nomart.Width = 165;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            this.Prix.Width = 99;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 187);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(221, 20);
            this.lbl_titre.TabIndex = 11;
            this.lbl_titre.Text = "Liste des produits achetés";
            // 
            // lbl_tt
            // 
            this.lbl_tt.AutoSize = true;
            this.lbl_tt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tt.Location = new System.Drawing.Point(712, 514);
            this.lbl_tt.Name = "lbl_tt";
            this.lbl_tt.Size = new System.Drawing.Size(90, 13);
            this.lbl_tt.TabIndex = 12;
            this.lbl_tt.Text = "Montant total : 0€";
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(635, 132);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(169, 29);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "Enregistrer modifications";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // fm_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 548);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.lbl_tt);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lv_pdt);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.lbl_names2);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lbl_names);
            this.Name = "fm_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Détails client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_details_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_names;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label lbl_names2;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.ListView lv_pdt;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.ColumnHeader marque;
        private System.Windows.Forms.ColumnHeader nomart;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.Label lbl_tt;
        private System.Windows.Forms.Button bt_update;
    }
}