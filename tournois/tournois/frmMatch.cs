﻿/*
 * Nom : Ilias N'hairi, Dylan Schito
 * Date : 14.12.2016
 * Version : 1.0
 * Description : Application de gestion de tournoi dans le cadre de l'atelier projet
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tournois
{
    public partial class frmMatch : Form
    {
        #region Fields
        private Course _match;
        #endregion

        #region Properties
        public Course CurrentMatch
        {
            get { return _match; }
            set { _match = value; }
        }
        #endregion

        #region Methods

        #region Constructor

        public frmMatch(Course m)
        {
            InitializeComponent();
            this.CurrentMatch = m;
            lblTeam1.Text = this.CurrentMatch.Team1.ToString();
            lblTeam2.Text = this.CurrentMatch.Team2.ToString();
        }

        #endregion

        /// <summary>
        /// Close the application and set the scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (nudTeam1.Value > 0 && nudTeam2.Value > 0 && cmbMap.Text != "" && nudTeam1.Value != nudTeam2.Value)
            {
                this.CurrentMatch.Team1Score = (int)nudTeam1.Value;
                this.CurrentMatch.Team2Score = (int)nudTeam2.Value;
                this.CurrentMatch.Map = cmbMap.Text;
                this.Close();
            }
        }

        /// <summary>
        /// Verify if data is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Le résultat du match est-il correcte ?", "Êtes vous sur ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion        
    }
}
