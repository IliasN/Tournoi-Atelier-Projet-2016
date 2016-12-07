using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tournois
{
    public class Course
    {
        #region Fields
        private equipe _team1;
        private equipe _team2;
        private int _team1Score;
        private int _team2Score;
        private string _map;
        #endregion

        #region Properties
        public equipe Team1
        {
            get { return _team1; }
            set { _team1 = value; }
        }
        public string Map
        {
            get { return _map; }
            set { _map = value; }
        }
        public int Team2Score
        {
            get { return _team2Score; }
            set { _team2Score = value; }
        }
        public int Team1Score
        {
            get { return _team1Score; }
            set { _team1Score = value; }
        }
        public equipe Team2
        {
            get { return _team2; }
            set { _team2 = value; }
        }
        #endregion

        #region Methods

        #region Constructor

        public Course(equipe t1,equipe t2)
        {
            this.Team1 = t1;
            this.Team2 = t2;
        }

        #endregion

        public override string ToString()
        {
            return string.Format(this.Team1.ToString() + " VS " + this.Team2.ToString());
        }

        #endregion
    }
}
