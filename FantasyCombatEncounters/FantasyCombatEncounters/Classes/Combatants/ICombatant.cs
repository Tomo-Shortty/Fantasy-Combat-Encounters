﻿using FantasyCombatEncounters.Classes.Weapons;
using FantasyCombatEncounters.Classes.Actions;
using System.Collections.Generic;
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
        bool Shielded { get; set; }
        int HitPoints { get; set; }
        bool Flying { get; set; }
        bool Engaged { get; set; }
        List<ICombatant> EngagedEnemies { get; set; }
        List<IWeapon> Weapons { get; set; }
        int MeleeAttacks { get; set; }
        int RangedAttacks { get; set; }
        List<IAction> Actions { get; set; }
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
        CombatantStatus Status { get; set; }
        bool MovementUsed { get; set; }
        bool ActionUsed { get; set; }
        bool BonusActionUsed { get; set; }
        bool ReactionUsed { get; set; }
        int DamageJustTaken { get; set; }
        int SecondDamageJustTaken { get; set; }

        void UseMovement(string movement);
        void UseAction(string action);
        void UseBonusAction(string bonusAction);
        void UseReaction(string reaction);
        void TakeDamage(int damage, int secondDamage, int multiplier);
    }
}
