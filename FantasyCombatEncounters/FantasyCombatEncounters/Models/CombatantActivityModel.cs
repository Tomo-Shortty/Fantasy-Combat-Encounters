namespace FantasyCombatEncounters.Models
{
    public class CombatantActivityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Effect { get; set; }
        public bool UnlimitedUses { get; set; }
        public int UsesPerTurn { get; set; }
        public int UsesPerGame { get; set; }
    }
}
