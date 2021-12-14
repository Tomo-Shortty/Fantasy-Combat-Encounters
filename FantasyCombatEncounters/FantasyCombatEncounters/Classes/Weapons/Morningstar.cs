using FantasyCombatEncounters.Classes.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class Morningstar : IWeapon
    {
        public Morningstar(int id, int damage, int attackBonus)
        {
            Id = id;
            Name = "Morningstar";
            Type = "Melee";
            Damage = damage;
            DamageType = "Piercing";
            AttackBonus = attackBonus;
            Save = 0;
            SecondDamage = 0;
            SecondDamageType = "";
            BonusEffect = null;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public int AttackBonus { get; set; }
        public int Save { get; set; }
        public int SecondDamage { get; set; }
        public string SecondDamageType { get; set; }
        public IAbility? BonusEffect { get; set; }
    }
}
