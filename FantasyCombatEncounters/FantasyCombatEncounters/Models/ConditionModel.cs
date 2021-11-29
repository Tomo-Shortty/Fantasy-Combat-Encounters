namespace FantasyCombatEncounters.Models
{
    public class ConditionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CombatantModel combatant { get; set; }
        public int Duration { get; set; }
        public bool CanExitEarly { get; set; }
        public int Save { get; set; }
    }
}
