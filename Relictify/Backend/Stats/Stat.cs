namespace Relictify.Backend.Stats
{
    public class Stat
    {
        public StatType StatType { get; set; }
        public double Value { get; set; } //All % values are listed as whole numbers e.g. 100.00% in game = 100.00, 84.4% = 84.4.
        public Stat(StatType statType = StatType.None, double value = 0)
        {
            this.StatType = statType;
            this.Value = value;
        }
    }
}