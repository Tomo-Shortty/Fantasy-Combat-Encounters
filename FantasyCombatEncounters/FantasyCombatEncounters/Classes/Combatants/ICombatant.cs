using FantasyCombatEncounters.Classes.Weapons;
using FantasyCombatEncounters.Classes.Abilities;
using FantasyCombatEncounters.Classes.Actions;
using FantasyCombatEncounters.Classes.Reactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyCombatEncounters.Classes.Types;

namespace FantasyCombatEncounters.Classes.Combatants
{
    internal interface ICombatant
    {
        int Id { get; set; }
        string Name { get; set; }
        CombatantType Type { get; set; }
        CombatantSize Size { get; set; }
        Faction Faction { get; set; }
        int Armour { get; set; }
        bool HasShield { get; set; }
        int HitPoints { get; set; }
        bool IsEngaged { get; set; }
        List<ICombatant> EngagedEnemies { get; set; }
        List<IWeapon> MeleeWeapons { get; set; }
        int MeleeAttacks { get; set; }
        List<IWeapon> RangedWeapons { get; set; }
        int RangedAttacks { get; set; }
        List<IAbility> Abilities { get; set; }
        List<IAction> Actions { get; set; }
        List<IReaction> Reactions { get; set; }
        int StrengthSave { get; set; }
        int DexteritySave { get; set; }
        int ConstitutionSave { get; set; }
        int IntelligenceSave { get; set; }
        int WisdomSave { get; set; }
        int CharismaSave { get; set; }
        List<DamageType> Vulnerabilities { get; set; }
        List<DamageType> DamageResistances { get; set; }
        List<DamageType> DamageImmunities { get; set; }
        List<Condition> ConditionImmunities { get; set; }
        int InitiativeBonus { get; set; }       
        int StealthBonus { get; set; }
        int PerceptionBonus { get; set; }
        int PassivePerception { get; set; }
        bool IsHidden { get; set; }
        bool IsSurprised { get; set; }
        List<Condition> CurrentConditions { get; set; }
    }
}
