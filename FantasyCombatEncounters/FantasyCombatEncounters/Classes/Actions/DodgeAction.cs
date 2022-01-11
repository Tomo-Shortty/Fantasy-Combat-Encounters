using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class DodgeAction : IAction
    {
        public DodgeAction()
        {
            Name = "Dodge";
            Type = ActionType.Action;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string Dodge(ICombatant combatant)
        {
            combatant.IsDodging = true;
            return combatant.Name + " is now attempting to dodge attacks!";
        }
    }
}
