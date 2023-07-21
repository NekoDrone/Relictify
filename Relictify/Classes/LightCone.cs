namespace Relictify
{
    public class LightCone
    {
        public string Name { get; private set; }
        public Path Path { get; private set; }
        public int Level { get; private set; }
        public int Ascension { get; private set; }
        public int Rarity { get; private set; }
        public List<MiscStat> MiscStats { get; private set; }
        public Stat LightConeHp { get; private set; }
        public Stat LightConeAtk { get; private set; }
        public Stat LightConeDef { get; private set; }

        public LightCone(string name)
        {
            this.Name = name;
            this.Path = Path.None;
            this.Level = 1;
            this.Ascension = 0;
            this.MiscStats = new List<MiscStat>();
            this.LightConeHp = new Stat(StatType.HpFlat);
            this.LightConeAtk = new Stat(StatType.AtkFlat);
            this.LightConeDef = new Stat(StatType.DefFlat);
        }

        public double GetBaseStat(StatType statType)
        {
            if (statType == StatType.HpFlat) return this.LightConeHp.Value;
            else if (statType == StatType.AtkFlat) return this.LightConeAtk.Value;
            else if (statType == StatType.DefFlat) return this.LightConeDef.Value;
            else throw new ArgumentException("Invalid Stat Type provided. Stat Type must be HpFlat, AtkFlat, or DefFlat.", statType.ToString());
        }
    }

}