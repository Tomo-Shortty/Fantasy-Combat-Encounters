using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class HelpAction : IAction
    {
        public HelpAction()
        {
            Name = "Help";
            Type = ActionType.Action;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string Help(ICombatant combatant, ICombatant ally, ICombatant enemy)
        {
            ally.EnemyReceivingHelpAgainst = enemy;
            return combatant.Name + " is helping " + ally.Name + " against " + enemy.Name;
        }
    }
}
