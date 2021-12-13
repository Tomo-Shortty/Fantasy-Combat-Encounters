using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes
{
    internal class Faction
    {
        private int Id;
        private string _name;

        public Faction(int Id, string Name)
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
        }

        public string Name => _name;
    }
}
