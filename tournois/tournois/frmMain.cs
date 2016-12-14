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
using System.IO;

namespace tournois
{
    public partial class frmMain : Form
    {
        #region Fields
        private StreamReader _reader;
        private Competition _tournament;
        #endregion

        #region Properties
        private StreamReader Reader
        {
            get { return _reader; }
            set { _reader = value; }
        }
        public Competition Tournament
        {
            get { return _tournament; }
            set { _tournament = value; }
        }
        #endregion

        #region Methods

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            this.Reader = new StreamReader("players.txt",Encoding.Default);
            this.Tournament = new Competition();
            GetPlayers();
            this.lblMj.Text = "Map Jockey : " + this.Tournament.GetMJ();
            this.Tournament.GenerateTeams();
            this.Tournament.GenerateMatchs();
            this.lsbTeams.DataSource = this.Tournament.Teams;
        }

        #endregion

        /// <summary>
        /// Get the players name from the text file "players.txt"
        /// </summary>
        public void GetPlayers()
        {
            List<string> tmpPlayers = new List<string>();
            string line = this.Reader.ReadLine();
            while(line != null)
            {
                tmpPlayers.Add(line);
                line = this.Reader.ReadLine();
            }
            this.Tournament.Player = tmpPlayers;
            this.lsbTeams.DataSource = this.Tournament.Player;
        }

        /// <summary>
        /// Verify that the user meant to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Êtes vous sur ?",MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Go through all the matchs and show a window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Course match = this.Tournament.StartPools();
            while (match != null)
            {
                frmMatch matchWindow = new frmMatch(match);
                matchWindow.ShowDialog();
                lsbResults.Items.Add(match);
                this.Tournament.Courses[this.Tournament.CurrentCourse] = matchWindow.CurrentMatch;
                match = this.Tournament.NextCourse();
                this.lsbTeams.DataSource = null;
                this.lsbTeams.DataSource = this.Tournament.Teams;
            }
            this.lsbTeams.DataSource = null;
            this.lsbTeams.DataSource = this.Tournament.Teams;
            btnStartFinals.Enabled = true;
        }

        /// <summary>
        /// Start the final round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartFinals_Click(object sender, EventArgs e)
        {
            frmTree tree = new frmTree(this.Tournament);
            tree.ShowDialog();
        }

        #endregion

        

       
    }
}
