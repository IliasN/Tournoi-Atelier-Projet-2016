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
            this.Tournament.GenerateTeams();
            this.Tournament.GenerateMatchs();
            this.lsbPlayers.DataSource = this.Tournament.Courses;
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
            this.lsbPlayers.DataSource = this.Tournament.Player;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Êtes vous sur ?",MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
