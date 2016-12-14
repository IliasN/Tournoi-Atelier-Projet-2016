/*
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
    public partial class frmTree : Form
    {
        #region Fields
        private Competition _tournament;
        private List<equipe> _results;
        private List<Course> _matches;
        #endregion

        #region properties
        public Competition Tournament
        {
            get { return _tournament; }
            set { _tournament = value; }
        }
        public List<equipe> Results
        {
            get { return _results; }
            set { _results = value; }
        }
        public List<Course> Matches
        {
            get { return _matches; }
            set { _matches = value; }
        }
        #endregion

        #region Methods

        #region Constructor

        public frmTree(Competition tour)
        {
            InitializeComponent();
            this.Tournament = tour;
            this.Results = this.Tournament.Teams;
            this.Matches = new List<Course>();
            if (this.Results.Count == 5)
            {
                lblTeamQ1.Text = this.Results[4].GetName();
                lblTeamQ3.Text = this.Results[2].GetName();
                lblTeamQ5.Text = this.Results[0].GetName();
                lblTeamQ2.Text = this.Results[3].GetName();
                lblTeamQ4.Text = this.Results[1].GetName();
            }
            if (this.Results.Count() == 4)
            {
                gbRnd1.Hide();
                lblTeamWon1.Text = this.Results[3].GetName();
                lblTeamWon2.Text = this.Results[1].GetName();
                lblTeamWon3.Text = this.Results[2].GetName();
                lblTeamP2.Text = this.Results[0].GetName();
            }
        }

        #endregion

        /// <summary>
        /// Start the matchs of the final phase for 8 or 10 players
        /// </summary>
        public void StartTree()
        {
            if (this.Results.Count == 5)
            {
                Course match1 = new Course(this.Results[4],this.Results[2]);
                frmMatch matchWindow = new frmMatch(match1);
                matchWindow.ShowDialog();
                lblTeamWon1.Text = match1.GetWinner().GetName();
                lblTeamP1.Text = match1.GetLooser().GetName();
                Course match4 = new Course();
                match4.Team1 = match1.GetWinner();
                Course match3 = new Course(this.Results[0],match1.GetLooser());
                Course match2 = new Course(this.Results[3], this.Results[1]);
                matchWindow = new frmMatch(match2);
                matchWindow.ShowDialog();
                lblTeamWon2.Text = match2.GetWinner().GetName();
                lblTeamP2.Text = match2.GetLooser().GetName();
                match4.Team2 = match2.GetWinner();
                Course match5 = new Course();
                match5.Team2 = match2.GetLooser();
                matchWindow = new frmMatch(match3);
                matchWindow.ShowDialog();
                lblTeamWon3.Text = match3.GetWinner().GetName();
                match5.Team1 = match3.GetWinner();
                matchWindow = new frmMatch(match4);
                matchWindow.ShowDialog();
                lblTeamWon4.Text = match4.GetWinner().GetName();
                Course match6 = new Course();
                match6.Team1 = match4.GetWinner();
                matchWindow = new frmMatch(match5);
                matchWindow.ShowDialog();
                lblTeamWon5.Text = match5.GetWinner().GetName();
                match6.Team2 = match5.GetWinner();
                matchWindow = new frmMatch(match6);
                matchWindow.ShowDialog();
                lblWinner.Text = match6.GetWinner().GetName();
                MessageBox.Show(match6.GetWinner().GetName() + " Gagnent !");
            }
            if(this.Results.Count() == 4)
            {
                Course match1 = new Course(this.Results[3], this.Results[1]);
                frmMatch matchWindow = new frmMatch(match1);
                matchWindow.ShowDialog();
                lblTeamWon4.Text = match1.GetWinner().GetName();
                Course match3 = new Course();
                match3.Team1 = match1.GetWinner();
                Course match2 = new Course(this.Results[2], this.Results[0]);
                matchWindow = new frmMatch(match2);
                matchWindow.ShowDialog();
                lblTeamWon5.Text = match2.GetWinner().GetName();
                match3.Team2 = match2.GetWinner();
                matchWindow = new frmMatch(match3);
                matchWindow.ShowDialog();
                lblWinner.Text = match3.GetWinner().GetName();
                MessageBox.Show(match3.GetWinner().GetName() + " Gagnent !"); 
            }
        }

        /// <summary>
        /// Ask the user if he wants to quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Êtes vous sur ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Start the matchs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTree();
            btnStart.Enabled = false;
        }

        #endregion
    }
}
