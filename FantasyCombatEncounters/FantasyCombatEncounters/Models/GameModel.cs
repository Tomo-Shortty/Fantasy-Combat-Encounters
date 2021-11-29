namespace FantasyCombatEncounters.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public string VictoriousPlayer { get; set; }
        public int PointsLimit { get; set; }
        public int Turns { get; set; }
    }
}
