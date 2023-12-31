﻿using Relictify.Backend.Stats;

namespace Relictify.Backend.Characters;

public class LightCone
{
    public LightCone(string name)
    {
        this.Name = name;
        this.CharPath = CharPath.None;
        this.Level = 1;
        this.Ascension = 0;
        this.MiscStats = new List<MiscStat>();
        this.LightConeHp = new Stat(StatType.HpFlat);
        this.LightConeAtk = new Stat(StatType.AtkFlat);
        this.LightConeDef = new Stat(StatType.DefFlat);
    }

    public string Name { get; private set; }
    public CharPath CharPath { get; private set; }
    public int Level { get; private set; }
    public int Ascension { get; private set; }
    public int Rarity { get; }
    public List<MiscStat> MiscStats { get; private set; }
    public Stat LightConeHp { get; }
    public Stat LightConeAtk { get; }
    public Stat LightConeDef { get; }

    public double GetBaseStat(StatType statType)
    {
        if (statType == StatType.HpFlat) return this.LightConeHp.Value;
        if (statType == StatType.AtkFlat) return this.LightConeAtk.Value;
        if (statType == StatType.DefFlat) return this.LightConeDef.Value;
        throw new ArgumentException("Invalid Stat Type provided. Stat Type must be HpFlat, AtkFlat, or DefFlat.",
            statType.ToString());
    }
}