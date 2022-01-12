using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class Greataxe : IWeapon
    {
        public Greataxe(int damage, int attackBonus)
        {
            Name = "Greataxe";
            Type = WeaponType.Melee;
            Ammunition = 1;
            IsTwoHanded = true;
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
