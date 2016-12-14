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

        /// <summary>
        /// Generate the teams from the list of players name
        /// </summary>
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

        /// <summary>
        /// Generate the matchs for 8 or 10 players
        /// </summary>
        public void GenerateMatchs()
        {
            if (this.Courses.Count == 0 && this.Teams.Count == 5)
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
            if (this.Courses.Count == 0 && this.Teams.Count == 4)
            {
                this.Courses.Add(new Course(this.Teams[0], this.Teams[1]));
                this.Courses.Add(new Course(this.Teams[2], this.Teams[3]));
                this.Courses.Add(new Course(this.Teams[1], this.Teams[2]));
                this.Courses.Add(new Course(this.Teams[0], this.Teams[2]));
                this.Courses.Add(new Course(this.Teams[1], this.Teams[3]));
                this.Courses.Add(new Course(this.Teams[0], this.Teams[3]));
            }
        }

        /// <summary>
        /// Return a random player to be the mapJockey
        /// </summary>
        /// <returns></returns>
        public string GetMJ()
        {
            Random rnd = new Random();
            return this.Player[rnd.Next(0, this.Player.Count)];
        }

        /// <summary>
        /// Set the current match to the first one and returns it
        /// </summary>
        /// <returns>The first match</returns>
        public Course StartPools()
        {
            this.CurrentCourse = 0;
            return this.Courses[this.CurrentCourse];
        }

        /// <summary>
        /// Increment the current match and returns it, sort the list of team when all matchs are done
        /// </summary>
        /// <returns>The current match or null if the pool match are over</returns>
        public Course NextCourse()
        {
            UpdateTeamScore();
            if (this.CurrentCourse < this.Courses.Count - 1)
            {
                Course tmp = this.Courses[this.CurrentCourse];
                this.CurrentCourse++;
                return tmp;
            }
            else
            {
                this.Teams = this.Teams.OrderBy(equipe => equipe.Points).ToList();
                return null;
            }
        }

        /// <summary>
        /// Add the result of a match to the score of a team
        /// </summary>
        public void UpdateTeamScore()
        {
            this.Courses[this.CurrentCourse].Team1.Points += this.Courses[this.CurrentCourse].Team1Score;
            this.Courses[this.CurrentCourse].Team2.Points += this.Courses[this.CurrentCourse].Team2Score;
        }

        #endregion
    }
}
