using System;
using System.Collections.Generic;
using System.Text;

namespace MTJayPatel
{
    // BasketballPlayer class that extends Player
    public class BasketballPlayer : Player
    {
        // private fields
        private int _fieldGoals;
        private int _threePointers;

        // properties
        public int FieldGoals
        {
            get { return _fieldGoals; }

            set
            {
                if (value < 0)
                    throw new Exception(" FieldGoals cannot be less than 0");
                else
                    _fieldGoals = value;
            }
        }
        public int ThreePointers
        {
            get { return _threePointers; }

            set
            {
                if (value < 0)
                    throw new Exception(" ThreePointers cannot be less than 0");
                else
                    _threePointers = value;
            }
        }

        // constructor
        public BasketballPlayer(int playerId, PlayerType playerType, String playerName, String teamName, int gamesPlayed, int fieldGoals, int threePointers) : base(playerId, playerType, playerName, teamName, gamesPlayed)
        {
            FieldGoals = fieldGoals;
            ThreePointers = threePointers;
        }

        //  override abstract method Points in Player
        public override int Points()
        {
            return ((FieldGoals - ThreePointers) + (2 * ThreePointers));
        }

     
    }
}
