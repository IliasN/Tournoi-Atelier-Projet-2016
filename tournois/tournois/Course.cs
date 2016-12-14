/*
 * Nom : Ilias N'hairi, Dylan Schito
 * Date : 14.12.2016
 * Version : 1.0
 * Description : Application de gestion de tournoi dans le cadre de l'atelier projet
 */
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

        public Course(equipe t1, equipe t2)
        {
            this.Team1 = t1;
            this.Team2 = t2;
        }

        public Course():this(null,null)
        {

        }

        #endregion

        public override string ToString()
        {
            return string.Format(this.Team1Score + " pts : " + this.Team1.GetName() + " VS " + this.Team2.GetName() + " : " + this.Team2Score + " pts sur la carte : " + this.Map);
        }

        public equipe GetWinner()
        {
            if (this.Team1Score > this.Team2Score)
                return this.Team1;
            return this.Team2;
        }

        public equipe GetLooser()
        {
            if (this.Team1Score < this.Team2Score)
                return this.Team1;
            return this.Team2;
        }

        #endregion
    }
}
