using FantasyCombatEncounters.Classes.Abilities;
using FantasyCombatEncounters.Classes.Types;
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
        WeaponType Type { get; set; }
        bool IsTwoHanded { get; set; }
        int Damage { get; set; }
        DamageType DamageType { get; set; }
        int AttackBonus { get; set; }
        int Save { get; set; }
        int SecondDamage { get; set; }
        DamageType SecondDamageType { get; set; }
        IAbility? BonusEffect { get; set; }
    }
}
