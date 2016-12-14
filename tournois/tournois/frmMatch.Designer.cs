namespace tournois
{
    partial class frmMatch
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
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTeam1 = new System.Windows.Forms.NumericUpDown();
            this.nudTeam2 = new System.Windows.Forms.NumericUpDown();
            this.cmbMap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(12, 9);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(63, 25);
            this.lblTeam1.TabIndex = 0;
            this.lblTeam1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score équipe 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score équipe 2 :";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(164, 116);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(132, 40);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Valider";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(319, 9);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(63, 25);
            this.lblTeam2.TabIndex = 7;
            this.lblTeam2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "VS";
            // 
            // nudTeam1
            // 
            this.nudTeam1.Location = new System.Drawing.Point(17, 51);
            this.nudTeam1.Name = "nudTeam1";
            this.nudTeam1.Size = new System.Drawing.Size(120, 20);
            this.nudTeam1.TabIndex = 0;
            // 
            // nudTeam2
            // 
            this.nudTeam2.Location = new System.Drawing.Point(324, 51);
            this.nudTeam2.Name = "nudTeam2";
            this.nudTeam2.Size = new System.Drawing.Size(120, 20);
            this.nudTeam2.TabIndex = 1;
            // 
            // cmbMap
            // 
            this.cmbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Items.AddRange(new object[] {
            "Luigi Circuit\t",
            "Mario Circuit\t",
            "Daisy Circuit\t",
            "Dry Dry Ruins",
            "Moo Moo Meadows\t",
            "Coconut Mall\t",
            "Koopa Cape\t",
            "Moonview Highway",
            "Mushroom Gorge\t",
            "DK Summit",
            "Maple Treeway\t",
            "Bowser\'s Castle",
            "Toad\'s Factory\t ",
            "Wario\'s Gold Mine\t",
            "Grumble Volcano\t",
            "Rainbow Road",
            "GCN Peach Beach",
            "N64 Sherbet Land",
            "DS Desert Hills",
            "DS Yoshi Falls",
            "GBA Shy Guy Beach",
            "GBA Bowser Castle 3",
            "SNES Ghost Valley 2",
            "DS Delfino Square",
            "N64 DS\'s Jungle Parkway",
            "N64 Mario RaceWay",
            "GCN Waluigi Stadium",
            "GCN Mario Circuit"});
            this.cmbMap.Location = new System.Drawing.Point(164, 89);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.Size = new System.Drawing.Size(132, 21);
            this.cmbMap.TabIndex = 9;
            // 
            // frmMatch
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 187);
            this.Controls.Add(this.cmbMap);
            this.Controls.Add(this.nudTeam2);
            this.Controls.Add(this.nudTeam1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeam1);
            this.Name = "frmMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match";
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTeam1;
        private System.Windows.Forms.NumericUpDown nudTeam2;
        private System.Windows.Forms.ComboBox cmbMap;
    }
}