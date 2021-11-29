namespace FantasyCombatEncounters.Models
{
    public class CombatantModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public int Armour { get; set; }
        public bool Shield { get; set; }
        public int HP { get; set; }
        public int InitiativeBonus { get; set; }
        public int StrengthSave { get; set; }
        public int DexteritySave { get; set; }
        public int ConstitutionSave { get; set; }
        public int IntelligenceSave { get; set; }
        public int WisdomSave { get; set; }
        public int CharismaSave { get; set; }
        public string[]? DamageResistances { get; set; }
        public string[]? DamageImmunities { get; set; }
        public string[]? ConditionImmunities { get; set; }
        public List<CombatantModel>? EngagedEnemies { get; set; }
        public List<WeaponModel>? MeleeWeapons { get; set; }
        public int MeleeAttacks { get; set; }
        public List<WeaponModel>? RangedWeapons { get; set; }
        public int RangedAttacks { get; set; }
        public List<CombatantActivityModel>? Abilities { get; set; }
        public List<CombatantActivityModel> Actions { get; set; }
        public List<CombatantActivityModel>? Reactions { get; set; }
        public List<CombatantActivityModel>? BonusActions { get; set; }
        public List<ConditionModel>? Conditions { get; set; }
    }
}
