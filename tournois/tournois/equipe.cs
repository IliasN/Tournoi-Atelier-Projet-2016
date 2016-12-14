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
    public class equipe
    {
        #region Fields
        private int _points;
        private string _player1;
        private string _player2;
        #endregion

        #region Properties
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public string Player1
        {
            get { return _player1; }
            set { _player1 = value; }
        }
        public string Player2
        {
            get { return _player2; }
            set { _player2 = value; }
        }
        #endregion

        #region Methods

        #region Constructor
        public equipe(string p1, string p2)
        {
            this.Player1 = p1;
            this.Player2 = p2;
            this.Points = 0;
        }
        #endregion

        public override string ToString()
        {
            return string.Format(this.Player1 + " + " + this.Player2 + " : " + this.Points.ToString() + " pts");
        }

        /// <summary>
        /// Return the name
        /// </summary>
        /// <returns>The name</returns>
        public string GetName()
        {
            return string.Format(this.Player1 + " + " + this.Player2);
        }

        #endregion
    }
}
