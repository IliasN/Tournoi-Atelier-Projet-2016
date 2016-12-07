namespace tournois
{
    partial class frmMain
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
            this.lsbPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbPlayers
            // 
            this.lsbPlayers.FormattingEnabled = true;
            this.lsbPlayers.Location = new System.Drawing.Point(12, 25);
            this.lsbPlayers.Name = "lsbPlayers";
            this.lsbPlayers.Size = new System.Drawing.Size(169, 368);
            this.lsbPlayers.TabIndex = 0;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(9, 9);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(50, 13);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Joueurs :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 470);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lsbPlayers);
            this.Name = "frmMain";
            this.Text = "Tournoi MK Wii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPlayers;
        private System.Windows.Forms.Label lblPlayers;
    }
}

