using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class SearchAction : IAction
    {
        private bool _advantage;
        private bool _disadvantage;

        public SearchAction()
        {
            Name = "Search";
            Type = ActionType.Action;
            Message = "";
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }
        public string Message { get; set; }
        public bool Advantage => _advantage;
        public bool Disadvantage => _disadvantage;

        public void Search(ICombatant combatant, ICombatant hiddenEnemy)
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
            int searchResult = diceRoll + combatant.PerceptionBonus;
            if (searchResult >= hiddenEnemy.PassiveStealth)
            {
                hiddenEnemy.IsHidden = false;
                Message = combatant.Name + " has spotted " + hiddenEnemy.Name + "! " + hiddenEnemy.Name + " is no longer hidden!";
            }
            else
            {
                Message = combatant.Name + " searched for " + hiddenEnemy.Name + " and could not find them.";
            }
        }
    }
}
