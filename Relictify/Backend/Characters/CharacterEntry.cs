using Relictify.Backend.Relics;
using Relictify.Backend.Stats;

namespace Relictify.Backend.Characters;

public class CharacterEntry
{
    public CharacterEntry(Character character)
    {
        this.Character = character;
        this.LightCone = new LightCone("Blank LC");
        this.EquippedRelics = new EquippedRelics();
        this.CharStats = new CharStats();
        this.MiscStats = new List<MiscStat>();
    }

    public Character Character { get; }
    public LightCone LightCone { get; }
    public EquippedRelics EquippedRelics { get; }
    public CharStats CharStats { get; }
    public List<MiscStat> MiscStats { get; }

    public void ConsolidateMiscStatsFromEquipment()
    {
        foreach (MiscStat modifier in this.Character.MiscStats) this.MiscStats.Add(modifier);
        foreach (MiscStat modifier in this.LightCone.MiscStats) this.MiscStats.Add(modifier);
        foreach (MiscStat modifier in this.EquippedRelics.MiscStats) this.MiscStats.Add(modifier);
    }

    public void RefreshStats()
    {
        this.ConsolidateMiscStatsFromEquipment();

        this.CharStats.Hp.Value = StatsCalc.CalculateBaseStat(this, BaseStat.Hp);
        this.CharStats.Atk.Value = StatsCalc.CalculateBaseStat(this, BaseStat.Atk);
        this.CharStats.Def.Value = StatsCalc.CalculateBaseStat(this, BaseStat.Def);
        this.CharStats.Spd.Value = StatsCalc.CalculateBaseStat(this, BaseStat.Spd);

        this.CharStats.CritRate.Value =
            StatsCalc.CalculateAdditiveStats(this, StatType.CritRate) + 5; //Base CR is always 5.0;
        this.CharStats.CritDmg.Value =
            StatsCalc.CalculateAdditiveStats(this, StatType.CritDmg) + 50; //Base CDMG is always 50.0;
        this.CharStats.BreakEffect.Value = StatsCalc.CalculateAdditiveStats(this, StatType.BreakEffect);
        this.CharStats.OutgoingHealing.Value = StatsCalc.CalculateAdditiveStats(this, StatType.OutgoingHealing);
        this.CharStats.ERR.Value = StatsCalc.CalculateAdditiveStats(this, StatType.ERR);
        this.CharStats.EHR.Value = StatsCalc.CalculateAdditiveStats(this, StatType.EHR);
        this.CharStats.EffectRes.Value = StatsCalc.CalculateAdditiveStats(this, StatType.EffectRes);
        this.CharStats.ElementalDamage.Value = StatsCalc.CalculateAdditiveStats(this, StatType.ElementalDamage);
    }

    public double GetRelicStatSum(StatType statType)
    {
        return this.EquippedRelics.GetStatSum(statType);
    }

    public double GetCharacterStat(StatType statType)
    {
        return this.Character.GetBaseStat(statType);
    }

    public double GetLightConeStat(StatType statType)
    {
        return this.LightCone.GetBaseStat(statType);
    }

    public static CharacterEntry LoadCharacterEntry(Character character)
    {
        //TODO: Add loading mechanism.
        //Actually, might be better to separate it into it's own class, then inject the dependency here.
        throw new NotImplementedException();
    }
}