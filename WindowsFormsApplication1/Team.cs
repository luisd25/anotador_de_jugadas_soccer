using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Team
    {

        private string Name;
        private int Score;
        private int Subs;
        private List<Player> inCourt;
        private List<Player> atBench;
        private int inC;


        public Team()
        {
            Name = "Team";
            inC = 0;
            Score = 0;
            Subs = 0;
            inCourt = new List<Player>();
            atBench = new List<Player>();
        }


        public string getName() { return Name; }
        public int getScore() { return Score; }
        public int getINC() { return inC; }
        public Player getPlayer(string s)
        {
            Player x = null;

            foreach (Player item in inCourt)
            {
                if (item.getName().Equals(s))
                    x = item;
            }

            if (x == null)
            {
                foreach (Player item in atBench)
                {
                    if (item.getName().Equals(s))
                        x = item;
                }
            }
            return x;

        }


        public void setName(string name) { Name = name; }
        public void scGoal(Player x) { Score++; x.scGoal(); }

        public void inPlayer(Player x)
        {
            inCourt.Add(x);
            atBench.Remove(x);
            x.inPlayer();
        }

        public void sitPlayer(Player x)
        {
            atBench.Add(x);
            inCourt.Remove(x);
            x.sitPlayer();
        }

        public void goToBench(Player x)
        {
            atBench.Add(x);
        }

        public string goToCourt(Player x)
        {
            if (inC < 11)
            {
                inCourt.Add(x);
                x.inPlayer();
                return "En Cancha.";
            }
            else
                return "Ya tiene 11 jugadores en cancha.";
        }

        public string subsPlayer(Player x, Player y)
        {
            if (Subs < 3)
            {
                if (y.getAvailability() && !y.getState())
                {
                    inPlayer(y);
                    sitPlayer(x);
                    Subs++;
                    return "Sustitucion exitosa.";
                }
                else
                    if (y.getAvailability() && y.getState())
                        return "No se puede sustituir por un jugador que esta en juego.";
                    else
                        return "El jugador " + y.getName() + "no esta disponible para jugar.";
            }
            else
                return "Este equipo ha agotado la cantidad maxima de sustituciones";
        }

        public Player[] getInCourt() { return inCourt.ToArray(); }
        public Player[] getAtBench() { return atBench.ToArray(); }




    }
}
