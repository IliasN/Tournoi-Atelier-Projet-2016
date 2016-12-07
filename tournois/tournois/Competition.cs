using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tournois
{
    public class Competition
    {
        #region Fields
        private string[] _player;
        private List<equipe> _teams;
        #endregion

        #region Properties
        public string[] Player
        {
            get { return _player; }
            set { _player = value; }
        }
        public List<equipe> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }
        #endregion

        #region Methods

        #region Constructor

        public Competition()
        {

        }

        #endregion

        public void GenerateTeams()
        {
            if (this.Teams.Count == 0)
            {
                
            }
        }

        #endregion
    }
}
