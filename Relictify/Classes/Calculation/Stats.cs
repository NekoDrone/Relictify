﻿namespace Relictify
{
    public enum StatType
    {
        HpFlat,
        HpPercent,
        AtkFlat,
        AtkPercent,
        DefFlat,
        DefPercent,
        SpdFlat,
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

    public enum BaseStat
    {
        Hp,
        Atk,
        Def,
        Spd
    }

    public class Stat
    {
        public StatType StatType { get; set; }
        public int TimesEnhanced { get; private set; }
        public double Value { get; private set; } //All % values are listed as whole numbers e.g. 100.00% in game = 100.00, 84.4% = 84.4.
        public Stat(StatType StatType = StatType.None, double Value = 0, int TimesEnhanced = 0)
        {
            this.StatType = StatType;
            this.Value = Value;
            this.TimesEnhanced = TimesEnhanced;
        }

        public void ReloadStat()
        {
            //need to implement the level mapping eventually...
        }
    }
}