namespace Relictify
{
    public enum StatType
    {
        HP,
        HPPercent,
        Atk,
        AtkPercent,
        Def,
        DefPercent,
        Spd,
        SpdPercent,
        CritRate,
        CritDmg,
        EHR,
        EffectRes,
        BreakEffect,
        OutgoingHealing,
        ERR,
        ElementalDamage,
        None
    }

    public class Stat
    {
        public StatType TypeOfStat { get; set; }
        public int TimesEnhanced { get; set; }
        public double Value { get; set; } //All % values are listed as whole numbers e.g. 100.00% in game = 100.00, 84.4% = 84.4.
        public Stat(StatType TypeOfStat)
        {
            this.TypeOfStat = TypeOfStat;
            this.Value = 0;
            this.TimesEnhanced = 1;
        }
    }
}