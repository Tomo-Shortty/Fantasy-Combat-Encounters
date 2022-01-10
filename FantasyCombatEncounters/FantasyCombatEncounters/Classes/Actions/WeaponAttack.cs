using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using FantasyCombatEncounters.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class WeaponAttack : IAction
    {
        public WeaponAttack(int id, string name, ActionType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ActionType Type { get; set; }

        public string Attack(IWeapon weapon, ICombatant defender)
        {
            Random random = new Random();
            int diceroll = random.Next(0, 21);
            int hitResult = diceroll + weapon.AttackBonus;
            if (hitResult == 1 || hitResult < defender.Armour)
            {
                return weapon.Name + " attack missed!";
            }
            else if (hitResult == 20)
            {
                defender.TakeDamage((weapon.Damage + weapon.SecondDamage) * 2);
                return weapon.Name + " attack scored a critical hit!";
            }
            else
            {
                defender.TakeDamage(weapon.Damage + weapon.SecondDamage);
                return weapon.Name + " attack hit!";
            }
        }
    }
}
