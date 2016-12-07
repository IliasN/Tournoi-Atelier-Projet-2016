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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.CurrentMatch.Team1Score = (int)nudTeam1.Value;
            this.CurrentMatch.Team2Score = (int)nudTeam2.Value;
            this.CurrentMatch.Map = cmbMap.Text;
            this.Close();
        }

        #endregion
    }
}
