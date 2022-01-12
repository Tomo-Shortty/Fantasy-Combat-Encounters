using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Weapons
{
    internal class ShieldBash : IWeapon
    {
        private string _message;
        private bool _advantage;
        private bool _disadvantage;

        public ShieldBash(int damage, int attackBonus, int save)
        {
            Name = "Shield Bash";
            Type = WeaponType.Melee;
            Ammunition = 1;
            IsTwoHanded = false;
            Damage = damage;
            DamageType = DamageType.Bludgeoning;
            AttackBonus = attackBonus;
            Save = save;
            SecondDamage = 0;
            SecondDamageType = DamageType.None;
            _message = "";
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
        public string Message => _message;
        public bool Advantage => _advantage;
        public bool Disadvantage => _disadvantage;

        public void ApplyBonusEffect(ICombatant enemy)
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
            int saveResult = diceRoll + enemy.StrengthSave;
            if (saveResult < Save)
            {
                if (!enemy.CurrentConditions.Contains(Condition.Prone))
                {
                    enemy.CurrentConditions.Add(Condition.Prone);
                }
                _message = enemy.Name + " has been knocked prone!";
            }
        }
    }
}
