namespace sio_shop
{
    partial class fm_menu
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
            this.bt_client = new System.Windows.Forms.Button();
            this.lbl_emp = new System.Windows.Forms.Label();
            this.bt_produit = new System.Windows.Forms.Button();
            this.bt_dcnx = new System.Windows.Forms.Button();
            this.bt_vente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_client
            // 
            this.bt_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_client.Location = new System.Drawing.Point(341, 196);
            this.bt_client.Name = "bt_client";
            this.bt_client.Size = new System.Drawing.Size(173, 56);
            this.bt_client.TabIndex = 1;
            this.bt_client.Text = "Gestion clients";
            this.bt_client.UseVisualStyleBackColor = true;
            this.bt_client.Click += new System.EventHandler(this.Bt_client_Click);
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp.Location = new System.Drawing.Point(28, 23);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(134, 17);
            this.lbl_emp.TabIndex = 1;
            this.lbl_emp.Text = "LABEL EMPLOYE";
            // 
            // bt_produit
            // 
            this.bt_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produit.Location = new System.Drawing.Point(341, 285);
            this.bt_produit.Name = "bt_produit";
            this.bt_produit.Size = new System.Drawing.Size(173, 56);
            this.bt_produit.TabIndex = 2;
            this.bt_produit.Text = "Gestion produits";
            this.bt_produit.UseVisualStyleBackColor = true;
            this.bt_produit.Click += new System.EventHandler(this.Bt_produit_Click);
            // 
            // bt_dcnx
            // 
            this.bt_dcnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dcnx.Location = new System.Drawing.Point(341, 378);
            this.bt_dcnx.Name = "bt_dcnx";
            this.bt_dcnx.Size = new System.Drawing.Size(173, 56);
            this.bt_dcnx.TabIndex = 3;
            this.bt_dcnx.Text = "Déconnexion";
            this.bt_dcnx.UseVisualStyleBackColor = true;
            this.bt_dcnx.Click += new System.EventHandler(this.Bt_dcnx_Click);
            // 
            // bt_vente
            // 
            this.bt_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vente.Location = new System.Drawing.Point(341, 97);
            this.bt_vente.Name = "bt_vente";
            this.bt_vente.Size = new System.Drawing.Size(173, 56);
            this.bt_vente.TabIndex = 0;
            this.bt_vente.Text = "Saisir vente";
            this.bt_vente.UseVisualStyleBackColor = true;
            this.bt_vente.Click += new System.EventHandler(this.Bt_vente_Click);
            // 
            // fm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.bt_vente);
            this.Controls.Add(this.bt_dcnx);
            this.Controls.Add(this.bt_produit);
            this.Controls.Add(this.lbl_emp);
            this.Controls.Add(this.bt_client);
            this.Name = "fm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fm_menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_client;
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Button bt_produit;
        private System.Windows.Forms.Button bt_dcnx;
        private System.Windows.Forms.Button bt_vente;
    }
}