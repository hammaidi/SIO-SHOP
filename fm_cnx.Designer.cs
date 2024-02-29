namespace sio_shop
{
    partial class fm_cnx
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(339, 199);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(193, 20);
            this.tb_login.TabIndex = 0;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(339, 241);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(193, 20);
            this.tb_mdp.TabIndex = 1;
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Transparent;
            this.bt_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ok.FlatAppearance.BorderSize = 0;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.Color.Transparent;
            this.bt_ok.Location = new System.Drawing.Point(339, 287);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(193, 34);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = ">";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre.Font = new System.Drawing.Font("Castellar", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(340, 128);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(192, 41);
            this.lbl_titre.TabIndex = 3;
            this.lbl_titre.Text = "SIO-SHOP";
            // 
            // fm_cnx
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sio_shop.Properties.Resources.abstract_geometric_background__cold_colors;
            this.ClientSize = new System.Drawing.Size(884, 548);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_login);
            this.Name = "fm_cnx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIO-SHOP - Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fm_cnx_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label lbl_titre;
    }
}

