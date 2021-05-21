using System;
using System.Collections.Generic;
using System.Text;

namespace A1JayPatel
{
    // BaseballPlayer class that extends Player
    public class BaseballPlayer : Player
    {
            // private fields
            private int _runs;
            private int _homeRuns;

            // properties
            public int Runs
            {
                get { return _runs; }

                set
                {
                    if (value < 0)
                        throw new Exception(" Runs cannot be less than 0");
                    else
                        _runs = value;
                }
            }
            public int HomeRuns
            {
                get { return _homeRuns; }

                set
                {
                    if (value < 0)
                        throw new Exception(" HomeRuns cannot be less than 0");
                    else
                        _homeRuns = value;
                }
            }

            // constructor
            public BaseballPlayer(int playerId, PlayerType playerType, String playerName, String teamName, int gamesPlayed, int runs, int homeRuns) : base(playerId, playerType, playerName, teamName, gamesPlayed)
            {
                Runs = runs;
                HomeRuns = homeRuns;
            }

            //  override abstract method Points in Player
            public override int Points()
            {
                return ((Runs - HomeRuns) + (2 * HomeRuns));
            }

            // return string representation of Baseball Player object
            public override string ToString()
            {
                return $"{base.ToString()}{Runs,-15}{HomeRuns,-15}";
        }

        
    }
}
