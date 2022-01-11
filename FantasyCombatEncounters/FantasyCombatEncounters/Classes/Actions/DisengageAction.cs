using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class DisengageAction : IAction
    {
        public DisengageAction()
        {
            Name = "Disengage";
            Type = ActionType.Action;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string Disengage(ICombatant combatant)
        {
            foreach (ICombatant enemy in combatant.EngagedEnemies)
            {
                enemy.EngagedEnemies.Remove(combatant);
            }
            combatant.EngagedEnemies.Clear();
            combatant.IsEngaged = false;
            return combatant.Name + " has disengaged.";
        }
    }
}
