namespace FantasyCombatEncounters.Models
{
    public class WeaponModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public int AttackBonus { get; set; }
        public int Save { get; set; }
        public int SecondDamage { get; set; }
        public string? SecondDamageType { get; set; }
        public string? BonusEffect { get; set; }
    }
}
