using System;
using System.Collections.Generic;
using System.Text;

namespace A1JayPatel
{
    public enum PlayerType
    {
        HockeyPlayer, BasketballPlayer, BaseballPlayer
    }

    // Player abstract base class
    public abstract class Player
    {
        // private fields
        private int _playerId;
        private PlayerType _playerType;
        private String _playerName;
        private String _teamName;
        private int _gamesPlayed;


        // properties
        public int PlayerId
        {
            get { return _playerId; }
            set { _playerId = value; }
        }

        public PlayerType TypeOfPlayer
        {
            get { return _playerType; }
            set { _playerType = value; }
        }

        public String PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public String TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set { _gamesPlayed = value; }
        }

        //constructor
        public Player(int playerId, PlayerType playerType, String playerName, String teamName,int gamesPlayed)
        {
            PlayerId = playerId;
            TypeOfPlayer = playerType;
            PlayerName = playerName;
            TeamName = teamName;
            GamesPlayed = gamesPlayed;
        }

        // abstract method overridden by derived classes
        public abstract int Points();

        // overridden ToString method -- string representation of Player object
        public override string ToString() 
        {
            return $"{TypeOfPlayer, -20}{PlayerId, -14}{PlayerName, -20}{TeamName,-20}{GamesPlayed,-16}";
        }
    }
}
