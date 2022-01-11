using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class MoveAway : IAction
    {
        public MoveAway()
        {
            Name = "Move Away";
            Type = ActionType.Move;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string MoveFromEngagement(ICombatant combatant)
        {
            foreach (ICombatant enemy in combatant.EngagedEnemies)
            {
                if (!enemy.ReactionUsed)
                {
                    enemy.UseReaction("");
                }
                enemy.EngagedEnemies.Remove(combatant);
            }
            combatant.EngagedEnemies.Clear();
            combatant.Engaged = false;
            return combatant.Name + " has moved away.";
        }
    }
}
