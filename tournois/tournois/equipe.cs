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

        #endregion
    }
}
