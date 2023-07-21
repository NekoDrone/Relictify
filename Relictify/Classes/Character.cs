namespace Relictify
{
    public class Character
    {
        public int Rarity { get; private set; }
        public string Name { get; private set; }
        public Element Element { get; private set; }
        public Path Path { get; private set; }
        public int Level { get; private set; }
        public int Ascension { get; private set; }
        public List<MiscStat> MiscStats { get; private set; }
        public Stat BaseHp { get; private set; }
        public Stat BaseAtk { get; private set; }
        public Stat BaseDef { get; private set; }
        public Stat BaseSpd { get; private set; }

        public Character(int rarity, string name, Element element, Path path)
        {
            this.Rarity = rarity;
            this.Name = name;
            this.Element = element;
            this.Path = path;
            this.MiscStats = new List<MiscStat>();
            this.BaseHp = new Stat(StatType.HpFlat);
            this.BaseAtk = new Stat(StatType.AtkFlat);
            this.BaseDef = new Stat(StatType.DefFlat);
            this.BaseSpd = new Stat(StatType.SpdFlat);
        }

        public double GetBaseStat(StatType statType)
        {
            if (statType == StatType.HpFlat) return this.BaseHp.Value;
            else if (statType == StatType.AtkFlat) return this.BaseAtk.Value;
            else if (statType == StatType.DefFlat) return this.BaseDef.Value;
            else if (statType == StatType.SpdFlat) return this.BaseSpd.Value;
            else return 0;
        }
    }
}