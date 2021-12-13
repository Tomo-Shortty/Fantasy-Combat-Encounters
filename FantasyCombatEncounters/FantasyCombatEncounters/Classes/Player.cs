using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes
{
    internal class Player
    {
        private int Id;
        private string _name;
        private Faction _faction;

        public Player(int Id, string Name, Faction Faction)
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

            if (Faction == null)
            {
                throw new Exception("Please enter a faction.");
            }
            else
            {
                _faction = Faction;
            }
        }

        public string Name => _name;
        public Faction Faction => _faction;
    }
}
