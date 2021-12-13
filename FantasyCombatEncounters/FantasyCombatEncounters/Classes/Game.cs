using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes
{
    internal class Game
    {
        private int Id;
        private string _name;
        private Player _playerOne;
        private Player _playerTwo;
        private Player? VictoriousPlayer;
        private int _pointsLimit;
        private int _turns;

        public Game(int Id, string Name, Player PlayerOne, Player PlayerTwo, int PointsLimit)
        {
            this.Id = Id;
            if (Name == null)
            {
                throw new Exception("Please enter a name.");
            }
            else
            {
                _name = Name;
            }

            if (PlayerOne == null)
            {
                throw new Exception("Please enter the 1st player.");
            }
            else
            {
                _playerOne = PlayerOne;
            }
            
            if (PlayerTwo == null)
            {
                throw new Exception("Please enter the 2nd player.");
            }
            else
            {
                _playerTwo = PlayerTwo;
            }

            _pointsLimit = PointsLimit;
            _turns = 0;
        }

        public string Name => _name;
        public Player PlayerOne => _playerOne;
        public Player PlayerTwo => _playerTwo;
        public int PointsLimit => _pointsLimit;
        public int Turns => _turns;

        public Player SetVictoriousPlayer(Player player)
        {
            VictoriousPlayer = player;
            return VictoriousPlayer;
        }
    }
}
