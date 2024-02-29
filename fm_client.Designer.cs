namespace sio_shop
{
    partial class fm_client
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
            this.lv_clients = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_retour = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_clients
            // 
            this.lv_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Telephone,
            this.Mail,
            this.Adresse});
            this.lv_clients.FullRowSelect = true;
            this.lv_clients.GridLines = true;
            this.lv_clients.HideSelection = false;
            this.lv_clients.Location = new System.Drawing.Point(0, 0);
            this.lv_clients.MultiSelect = false;
            this.lv_clients.Name = "lv_clients";
            this.lv_clients.Size = new System.Drawing.Size(880, 480);
            this.lv_clients.TabIndex = 1;
            this.lv_clients.UseCompatibleStateImageBehavior = false;
            this.lv_clients.View = System.Windows.Forms.View.Details;
            this.lv_clients.DoubleClick += new System.EventHandler(this.Lv_clients_DoubleClick);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 46;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 85;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenom.Width = 93;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Telephone";
            this.Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telephone.Width = 109;
            // 
            // Mail
            // 
            this.Mail.Text = "Email";
            this.Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mail.Width = 220;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adresse.Width = 318;
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(12, 504);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 2;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.Bt_retour_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(187, 507);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(160, 17);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Recherche par nom :";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(354, 507);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(237, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.Tb_search_TextChanged);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(695, 495);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(185, 41);
            this.bt_new.TabIndex = 5;
            this.bt_new.Text = "Nouveau client";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.Bt_new_Click);
            // 
            // fm_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.lv_clients);
            this.Name = "fm_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Gestion des clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv_clients;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_new;
    }
}