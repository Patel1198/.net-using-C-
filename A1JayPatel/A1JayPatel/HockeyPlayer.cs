using System;
using System.Collections.Generic;
using System.Text;

namespace A1JayPatel
{
    // HockeyPlayer class that extends Player
    public class HockeyPlayer : Player
    {
        // private fields
        private int _assists;
        private int _goals;

        // properties
        public int Assists
        {
            get { return _assists; }

            set
            {
                if (value < 0)
                    throw new Exception(" Assists cannot be less than 0");
                else
                    _assists = value;
            }
        }
        public int Goals
        {
            get { return _goals; }

            set
            {
                if (value < 0)
                    throw new Exception(" Goals cannot be less than 0");
                else
                    _goals = value;
            }
        }

        // constructor
        public HockeyPlayer(int playerId, PlayerType playerType, String playerName, String teamName, int gamesPlayed, int assists, int goals) : base(playerId, playerType, playerName, teamName, gamesPlayed)
        {
            Assists = assists;
            Goals = goals;
        }

        //  override abstract method Points in Player
        public override int Points()
        {
            return (Assists + (2 * Goals));
        }

        // return string representation of HockeyPlayer object
        public override string ToString()
        {
            return $"{base.ToString()}{Assists,-15}{Goals}";
        }

    }
}

