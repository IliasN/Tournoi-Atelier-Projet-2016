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
        private List<string> _player;
        private List<equipe> _teams;
        private List<Course> _courses;
        private int _currentCourse;
        #endregion

        #region Properties
        public int CurrentCourse
        {
            get { return _currentCourse; }
            set { _currentCourse = value; }
        }
        public List<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
        public List<string> Player
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
            this.Player = new List<string>();
            this.Teams = new List<equipe>();
            this.Courses = new List<Course>();
            this.CurrentCourse = 0;
        }

        #endregion

        public void GenerateTeams()
        {
            Random rnd = new Random();
            if (this.Teams.Count == 0)
            {
                while (this.Player.Count() > 0)
                {
                    int p1 = 0;
                    int p2 = 0;
                    while (p1 == p2)
                    {
                        p1 = rnd.Next(0, this.Player.Count());
                        p2 = rnd.Next(0, this.Player.Count());
                    }
                    this.Teams.Add(new equipe(this.Player[p1], this.Player[p2]));
                    if (p1 > p2)
                    {
                        this.Player.RemoveAt(p1);
                        this.Player.RemoveAt(p2);
                    }
                    else
                    {
                        this.Player.RemoveAt(p2);
                        this.Player.RemoveAt(p1);
                    }
                }
            }
        }

        public void GenerateMatchs()
        {
            if (this.Courses.Count == 0)
            {
                this.Courses.Add(new Course(this.Teams[0], this.Teams[1]));
                this.Courses.Add(new Course(this.Teams[2], this.Teams[3]));
                this.Courses.Add(new Course(this.Teams[4], this.Teams[0]));
                this.Courses.Add(new Course(this.Teams[1], this.Teams[2]));
                this.Courses.Add(new Course(this.Teams[3], this.Teams[4]));
                this.Courses.Add(new Course(this.Teams[0], this.Teams[2]));
                this.Courses.Add(new Course(this.Teams[1], this.Teams[3]));
                this.Courses.Add(new Course(this.Teams[2], this.Teams[4]));
                this.Courses.Add(new Course(this.Teams[0], this.Teams[3]));
                this.Courses.Add(new Course(this.Teams[1], this.Teams[4]));
            }
        }

        #endregion
    }
}
