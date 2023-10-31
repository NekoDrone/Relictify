namespace Relictify.Backend.Stats
{
    public class Stat
    {
        public StatType StatType { get; set; }
        public double Value { get; set; } //All % values are listed as whole numbers e.g. 100.00% in game = 100.00, 84.4% = 84.4.
        public Stat(StatType StatType = StatType.None, double Value = 0)
        {
            this.StatType = StatType;
            this.Value = Value;
        }
    }
}