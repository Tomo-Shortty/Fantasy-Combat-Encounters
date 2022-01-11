using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class EngageAction : IAction
    {
        public EngageAction()
        {
            Name = "Engage";
            Type = ActionType.Move;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string Engage(ICombatant combatant, ICombatant enemy)
        {
            if (combatant.IsEngaged)
            {
                foreach (ICombatant creature in combatant.EngagedEnemies)
                {
                    creature.EngagedEnemies.Remove(combatant);
                }
                combatant.EngagedEnemies.Clear();
            }
            combatant.EngagedEnemies.Add(enemy);
            enemy.EngagedEnemies.Add(combatant);
            combatant.IsEngaged = true;
            enemy.IsEngaged = true;
            return combatant.Name + " has engaged " + enemy.Name + "!";
        }
    }
}
