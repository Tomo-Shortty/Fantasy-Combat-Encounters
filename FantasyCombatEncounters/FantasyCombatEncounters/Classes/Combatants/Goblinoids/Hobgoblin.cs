using FantasyCombatEncounters.Classes.Actions;
using FantasyCombatEncounters.Classes.Types;
using FantasyCombatEncounters.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Combatants.Goblinoids
{
    internal class Hobgoblin : ICombatant
    {
        private bool _martialAdvantageActive;

        public Hobgoblin(int id, Faction faction)
        {
            Id = id;
            Name = "Hobgoblin";
            Type = CombatantType.Humanoid;
            Size = CombatantSize.Medium;
            CombatantFaction = faction;
            Armour = 18;
            HasShield = true;
            ShieldIsActive = true;
            MaxHitPoints = 11;
            CurrentHitPoints = MaxHitPoints;
            TempHitPoints = 0;
            IsFlying = false;
            IsEngaged = false;
            IsDodging = false;
            IsHidden = false;
            IsSurprised = false;
            EngagedEnemies = new List<ICombatant>();
            EnemyReceivingHelpAgainst = null;
            Weapons = new List<IWeapon>
            {
                new Longsword(5, 3),
                new Longbow(5, 3)
            };
            ActiveWeapon = Weapons[0];
            MeleeAttacks = 1;
            RangedAttacks = 1;
            Actions = new List<IAction>
            {
                new EngageAction(),                
                new DisengageAction(),
                new MoveAwayAction(),
                new WeaponAttack("Longsword Attack", ActionType.Action),
                new WeaponAttack("Longbow Attack", ActionType.Action),
                new ChangeWeaponAction(),
                new DodgeAction(),
                new HideAction(),
                new SearchAction(),
                new HelpAction(),
            };
            StrengthSave = 1;
            DexteritySave = 1;
            ConstitutionSave = 1;
            IntelligenceSave = 0;
            WisdomSave = 0;
            CharismaSave = -1;
            Vulnerabilities = new List<DamageType>();
            DamageResistances = new List<DamageType>();
            DamageImmunities = new List<DamageType>();
            ConditionImmunities = new List<Condition>();
            InitiativeBonus = 1;
            StealthBonus = -4;
            PassiveStealth = 11;
            PerceptionBonus = 0;
            PassivePerception = 10;
            CurrentConditions = new List<Condition>();
            Status = CombatantStatus.Alive;
            MovementUsed = false;
            ActionUsed = false;
            BonusActionUsed = false;
            ReactionUsed = false;
            DamageJustTaken = 0;
            SecondDamageJustTaken = 0;
            Message = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CombatantType Type { get; set; }
        public CombatantSize Size { get; set; }
        public Faction CombatantFaction { get; set; }
        public int Armour { get; set; }
        public bool HasShield { get; set; }
        public bool ShieldIsActive { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TempHitPoints { get; set; }
        public bool IsFlying { get; set; }
        public bool IsEngaged { get; set; }
        public bool IsDodging { get; set; }
        public bool IsHidden { get; set; }
        public bool IsSurprised { get; set; }
        public List<ICombatant> EngagedEnemies { get; set; }
        public ICombatant? EnemyReceivingHelpAgainst { get; set; }
        public List<IWeapon> Weapons { get; set; }
        public IWeapon ActiveWeapon { get; set; }
        public int MeleeAttacks { get; set; }
        public int RangedAttacks { get; set; }
        public List<IAction> Actions { get; set; }
        public int StrengthSave { get; set; }
        public int DexteritySave { get; set; }
        public int ConstitutionSave { get; set; }
        public int IntelligenceSave { get; set; }
        public int WisdomSave { get; set; }
        public int CharismaSave { get; set; }
        public List<DamageType> Vulnerabilities { get; set; }
        public List<DamageType> DamageResistances { get; set; }
        public List<DamageType> DamageImmunities { get; set; }
        public List<Condition> ConditionImmunities { get; set; }
        public int InitiativeBonus { get; set; }
        public int StealthBonus { get; set; }
        public int PassiveStealth { get; set; }
        public int PerceptionBonus { get; set; }
        public int PassivePerception { get; set; }
        public List<Condition> CurrentConditions { get; set; }
        public CombatantStatus Status { get; set; }
        public bool MovementUsed { get; set; }
        public bool ActionUsed { get; set; }
        public bool BonusActionUsed { get; set; }
        public bool ReactionUsed { get; set; }
        public int DamageJustTaken { get; set; }
        public int SecondDamageJustTaken { get; set; }
        public string Message { get; set; }
        public bool MartialAdvantageActive => _martialAdvantageActive;

        public void TakeDamage(int damage, int secondDamage, int multiplier)
        {
            CurrentHitPoints = CurrentHitPoints - ((damage + secondDamage) * multiplier);
            if (CurrentHitPoints <= 0)
            {
                Status = CombatantStatus.Deceased;
                Message = Name + " has been slain!";
            }
        }
        public void RecoverHitPoints(int hitPoints)
        {
            CurrentHitPoints += hitPoints;
            if (CurrentHitPoints > MaxHitPoints)
            {
                CurrentHitPoints = MaxHitPoints;
            }
        }
        public void GainTempHitPoints(int tempHitPoints)
        {
            TempHitPoints = tempHitPoints;
        }
        public bool ToggleShield(bool status)
        {
            if (status && !ShieldIsActive)
            {
                ShieldIsActive = true;
                Armour += 2;
                return true;
            }
            else if (!status && ShieldIsActive)
            {
                ShieldIsActive = false;
                Armour -= 2;
                return false;
            }
            else
            {
                return false;
            }
        }
        public void ResetAbilities()
        {
            _martialAdvantageActive = true;
        }

        public void MartialAdvantage(ICombatant enemy)
        {
            foreach (ICombatant ally in CombatantFaction.Combatants)
            {
                if (ally.EngagedEnemies.Contains(enemy) && _martialAdvantageActive)
                {                   
                    Message = enemy.Name + " took an additional " + enemy.DamageJustTaken + " damage from martial advantage!";
                    enemy.TakeDamage(7, 0, 1);
                    _martialAdvantageActive = false;
                }
            }
        }
    }
}
