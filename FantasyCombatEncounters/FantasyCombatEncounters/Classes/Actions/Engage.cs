using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class Engage : IAction
    {
        public Engage()
        {
            Name = "Engage";
            Type = ActionType.Move;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string EngageEnemy(ICombatant combatant, ICombatant enemy)
        {
            if (combatant.Engaged)
            {
                foreach (ICombatant creature in combatant.EngagedEnemies)
                {
                    if (!creature.ReactionUsed)
                    {
                        creature.UseReaction("");
                    }
                    creature.EngagedEnemies.Remove(combatant);
                }
                combatant.EngagedEnemies.Clear();
            }
            combatant.EngagedEnemies.Add(enemy);
            enemy.EngagedEnemies.Add(combatant);
            combatant.Engaged = true;
            enemy.Engaged = true;
            return combatant.Name + " has engaged " + enemy.Name;
        }
    }
}
