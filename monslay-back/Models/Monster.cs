namespace monslay_back.Models
{
    public class Monster
    {
        public int MonsterId { get; set; }
        public string? Name { get; set; }
        public int DamageMultiplier { get; set; }
        public int Resistance { get; set; }
    }
}
