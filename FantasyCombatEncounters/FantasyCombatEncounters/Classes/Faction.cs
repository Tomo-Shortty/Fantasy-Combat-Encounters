using FantasyCombatEncounters.Classes.Combatants;
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
        private List<ICombatant> _combatants;

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
            _combatants = new List<ICombatant>();
        }

        public string Name => _name;
        public List<ICombatant> Combatants => _combatants;
    }
}
