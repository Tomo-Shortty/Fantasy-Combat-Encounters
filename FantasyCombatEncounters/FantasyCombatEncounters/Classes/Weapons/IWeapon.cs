using FantasyCombatEncounters.Classes.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal interface IWeapon
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        int Damage { get; set; }
        string DamageType { get; set; }
        int AttackBonus { get; set; }
        int Save { get; set; }
        int SecondDamage { get; set; }
        string SecondDamageType { get; set; }
        IAbility? BonusEffect { get; set; }
    }
}
