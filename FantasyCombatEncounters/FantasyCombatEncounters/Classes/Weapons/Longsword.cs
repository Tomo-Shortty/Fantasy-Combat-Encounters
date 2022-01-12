using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class Longsword : IWeapon
    {
        public Longsword(int damage, int attackBonus)
        {
            Name = "Longsword";
            Type = WeaponType.Melee;
            Ammunition = 1;
            IsTwoHanded = false;
            Damage = damage;
            DamageType = DamageType.Slashing;
            AttackBonus = attackBonus;
            Save = 0;
            SecondDamage = 0;
            SecondDamageType = DamageType.None;
        }

        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public int Ammunition { get; set; }
        public bool IsTwoHanded { get; set; }
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public int AttackBonus { get; set; }
        public int Save { get; set; }
        public int SecondDamage { get; set; }
        public DamageType SecondDamageType { get; set; }
    }
}
