using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Player
    {

        private string Name;
        private int No;
        private string Pos;
        private int Goals;
        private bool State;
        private bool Availability;

        public Player(string name, int no, string pos)
        {
            Name = name;
            No = no;
            Pos = pos;
            Goals = 0;
            State = false;
            Availability = true;

        }

        public string getName() { return Name; }
        public int getNo() { return No; }
        public string getPos() { return Pos; }
        public bool getState() { return State; }
        public bool getAvailability() { return Availability; }
        public int getGoals() { return Goals; }


        public void sitPlayer() { State = false; Availability = false; }
        public void inPlayer() { State = true; }

        public void setName(string name) { Name = name; }
        public void setNo(int no) { No = no; }
        public void setPos(string pos) { Pos = pos; }
        public void scGoal() { Goals++; }


    }
}
