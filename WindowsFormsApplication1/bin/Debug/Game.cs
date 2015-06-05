using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Game
    {
        private string Name;
        private Team TeamA;
        private Team TeamB;
        private bool Extra;
        private bool First;
        private DateTime Date;
        private int Time = 45;
        public int Recovery;

        public string getScore() {
            return "[" + TeamA.getScore() + "-" + TeamB.getScore() + "]";
        }

        public Game()
        {
            TeamA = null;
            TeamB = null;
            Extra = false;
            First = true;


        }
        public void addTeamA(Team a) { TeamA = a; }
        public void addTeamB(Team b) { TeamB = b; }
        public void goToExtra() { Extra = true; First = true; Time += 15; }
        public void goToSecond()
        {
            First = false;
            if (Extra)
                Time += 15 + Recovery;
            else
                Time += getRealTime();
        }
        public void setRecovery(int x) { Recovery = x; }
        public void setTime(int x) { Time = x; }

        public Team getTeamA() { return TeamA; }
        public Team getTeamB() { return TeamB; }
        public string getName() { return Name; }
        public bool getExtra() { return Extra; }
        public bool getFirst() { return First; }
        public int getTiempo() { return Time; }
        public string getDate() { return Date.ToString("dd/MM/yyyy"); }
        public int getRecovery() { return Recovery; }
        public int getRealTime() { return Time + Recovery; }

        public void startGame()
        {
            if (TeamA != null && TeamB != null)
            {

                Date = DateTime.Now;
                Name = TeamA.getName().Substring(0, 3) + "vs" + TeamB.getName().Substring(0, 3) + "-" + Date.ToString("ddMMhhmm");
                First = true;
            }
        }

        public void gol(Team x,Player y)
        {
            x.scGoal(y);
        }

        public bool isTie()
        {
            return TeamA.getScore().Equals(TeamB.getScore());
        }
    }
}
