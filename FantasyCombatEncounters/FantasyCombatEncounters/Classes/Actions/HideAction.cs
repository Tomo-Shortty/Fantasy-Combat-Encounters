using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class HideAction : IAction
    {
        private bool _advantage;
        private bool _disadvantage;
        public HideAction()
        {
            Name = "Hide";
            Type = ActionType.Action;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }
        public bool Advantage => _advantage;
        public bool Disadvantage => _disadvantage;

        public string Hide(ICombatant combatant, List<ICombatant> enemies)
        {
            Random random = new Random();
            int diceRoll;
            if (_advantage == true && _disadvantage == false)
            {
                diceRoll = random.Next(0, 21) + 5;
            }
            else if (_advantage == false && _disadvantage == true)
            {
                diceRoll = random.Next(0, 21) - 5;
            }
            else
            {
                diceRoll = random.Next(0, 21);
            }
            int hideResult = diceRoll + combatant.StealthBonus;
            int enemiesNotHiddenFrom = 0;
            foreach(ICombatant enemy in enemies)
            {
                if (hideResult < enemy.PassivePerception && enemy.Status == CombatantStatus.Alive)
                {
                    enemiesNotHiddenFrom++;
                }
            }
            if (enemiesNotHiddenFrom == 0)
            {
                return combatant.Name + " tried to hide but failed.";
            }
            else
            {
                return combatant.Name + " is now hiding.";
            }
        }
    }
}
