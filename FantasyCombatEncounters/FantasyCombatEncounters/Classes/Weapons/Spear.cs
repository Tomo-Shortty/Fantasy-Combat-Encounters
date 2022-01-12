using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class Spear : IWeapon
    {
        public Spear(int damage, int attackBonus)
        {
            Name = "Spear";
            Type = WeaponType.MeleeOrRanged;
            Ammunition = 4;
            IsTwoHanded = false;
            Damage = damage;
            DamageType = DamageType.Piercing;
            AttackBonus = attackBonus;
            Save = 0;
            SecondDamage = 0;
            SecondDamageType = 0;
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
