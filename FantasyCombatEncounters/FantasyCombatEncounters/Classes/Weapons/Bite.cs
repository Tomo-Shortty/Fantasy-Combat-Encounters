using FantasyCombatEncounters.Classes.Abilities;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class Bite : IWeapon
    {
        public Bite(int id, int damage, int attackBonus)
        {
            Id = id;
            Name = "Bite";
            Type = WeaponType.Melee;
            RangedAmmunition = 0;
            IsTwoHanded = false;
            Damage = damage;
            DamageType = DamageType.Piercing;
            AttackBonus = attackBonus;
            Save = 0;
            SecondDamage = 0;
            SecondDamageType = DamageType.None;
            BonusEffect = null;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public int RangedAmmunition { get; set; }
        public bool IsTwoHanded { get; set; }
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public int AttackBonus { get; set; }
        public int Save { get; set; }
        public int SecondDamage { get; set; }
        public DamageType SecondDamageType { get; set; }
        public IAbility? BonusEffect { get; set; }
    }
}
