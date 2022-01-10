using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class MartialAdvantage : IAction
    {
        private int _damage;
        private bool _usedThisTurn;
        public MartialAdvantage(int id, int damage)
        {
            Id = id;
            Name = "Martial Advantage";
            Type = ActionType.Ability;
            _damage = damage;
            _usedThisTurn = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ActionType Type { get; set; }
        public bool UsedThisTurn => _usedThisTurn;

        public void ApplyMartialAdvantage(ICombatant combatant)
        {
            if (_usedThisTurn == false)
            {
                combatant.TakeDamage(_damage);
            }
        }
    }
}
