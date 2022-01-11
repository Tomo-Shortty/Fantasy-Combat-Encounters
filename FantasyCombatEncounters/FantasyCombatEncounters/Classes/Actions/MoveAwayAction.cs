using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class MoveAwayAction : IAction
    {
        public MoveAwayAction()
        {
            Name = "Move Away";
            Type = ActionType.Move;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string MoveAway(ICombatant combatant)
        {
            foreach (ICombatant enemy in combatant.EngagedEnemies)
            {
                enemy.EngagedEnemies.Remove(combatant);
            }
            combatant.EngagedEnemies.Clear();
            combatant.IsEngaged = false;
            return combatant.Name + " has moved away.";
        }
    }
}
