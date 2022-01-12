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
            Message = "";
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }
        public string Message { get; set; }

        public void Dodge(ICombatant combatant)
        {
            combatant.IsDodging = true;
            Message = combatant.Name + " is now attempting to dodge attacks!";
        }
    }
}
