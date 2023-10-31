using Relictify.Backend.Stats;

namespace Relictify.Backend.Characters
{
    public class Character
    {
        public int Rarity { get; set; }
        public string Name { get; set; }
        public CombatElement CombatElement { get; set; }
        public CharPath CharPath { get; set; }
        public int Level { get; set; }
        public int Ascension { get; set; }
        public List<MiscStat> MiscStats { get; set; }
        public Stat BaseHp { get; set; }
        public Stat BaseAtk { get; set; }
        public Stat BaseDef { get; set; }
        public Stat BaseSpd { get; set; }

        public Character(int rarity, string name, CombatElement combatElement, CharPath charPath)
        //NEVER call the constructor manually, always let the builder call it for you.
        {
            this.Rarity = rarity;
            this.Name = name;
            this.CombatElement = combatElement;
            this.CharPath = charPath;
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