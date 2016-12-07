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
            this.lsbTeams = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblMj = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lsbResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbTeams
            // 
            this.lsbTeams.FormattingEnabled = true;
            this.lsbTeams.Location = new System.Drawing.Point(12, 25);
            this.lsbTeams.Name = "lsbTeams";
            this.lsbTeams.Size = new System.Drawing.Size(288, 368);
            this.lsbTeams.TabIndex = 0;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(9, 9);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(51, 13);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Équipes :";
            // 
            // lblMj
            // 
            this.lblMj.AutoSize = true;
            this.lblMj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMj.Location = new System.Drawing.Point(12, 396);
            this.lblMj.Name = "lblMj";
            this.lblMj.Size = new System.Drawing.Size(133, 24);
            this.lblMj.TabIndex = 2;
            this.lblMj.Text = "Map Jockey :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 424);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(284, 58);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Commencer le tournoi!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lsbResults
            // 
            this.lsbResults.FormattingEnabled = true;
            this.lsbResults.Location = new System.Drawing.Point(306, 25);
            this.lsbResults.Name = "lsbResults";
            this.lsbResults.Size = new System.Drawing.Size(420, 368);
            this.lsbResults.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Résultat des matchs :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMj);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lsbTeams);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournoi MK Wii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTeams;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblMj;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lsbResults;
        private System.Windows.Forms.Label label1;
    }
}

