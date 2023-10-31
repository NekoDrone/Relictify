/*
how to calculate, and what to calculate?

what:
- hp
- atk
- def
- spd
- crit rate
- crit dmg
- break effect
- outgoing healing boost
- err
- ehr
- effect res
- elemental damage boost

how:
user has to key in base stats for char + LC.
e.g. my seele's attack = 3245 = 1169 + 2075
1169 is base => LC gives 529 (Cruising @ 80/80) ==> base atk is 1169-529=640
can I auto-calculate the base stat from the given number instead?
*/

// TODO: Think about user flow and interaction.
// TODO 31/10/23: I hate the way that this works. Redo this whole thing, but it's useful for reference.
using Relictify.Backend.Characters;

namespace Relictify.Backend.Stats;

public static class StatsCalc
{
    public static double CalculateAdditiveStats(CharacterEntry characterEntry, StatType additiveStat)
    {
        double statSum = characterEntry.EquippedRelics.GetStatSum(additiveStat);
        statSum += TallyApplicableMiscStats(additiveStat, characterEntry.MiscStats);
        return statSum;
    }

    public static double CalculateBaseStat(CharacterEntry characterEntry, BaseStat baseStat)
    {
        StatType percentStat = ConvertBaseToStat(baseStat, "Percent");
        StatType flatStat = ConvertBaseToStat(baseStat, "Flat");

        double percentSum = characterEntry.GetRelicStatSum(percentStat);
        double flatSum = characterEntry.GetRelicStatSum(flatStat);

        percentSum += TallyApplicableMiscStats(percentStat, characterEntry.MiscStats);
        flatSum += TallyApplicableMiscStats(flatStat, characterEntry.MiscStats);

        double baseStatValue = characterEntry.GetCharacterStat(flatStat) + characterEntry.GetLightConeStat(flatStat);

        return baseStatValue * (1 + percentSum / 100) + flatSum;
    }

    private static double TallyApplicableMiscStats(StatType statType, List<MiscStat> MiscStats)
    {
        double total = 0;
        foreach (MiscStat modifier in MiscStats)
            if (modifier.StatType == statType)
                total += modifier.Value;
        return total;
    }

    private static StatType ConvertBaseToStat(BaseStat baseStat, string arg)
    {
        if (arg == "Percent")
        {
            if (baseStat == BaseStat.Hp) return StatType.HpPercent;
            if (baseStat == BaseStat.Atk) return StatType.AtkPercent;
            if (baseStat == BaseStat.Def) return StatType.DefPercent;
            if (baseStat == BaseStat.Spd) return StatType.SpdPercent;
        }

        if (arg == "Flat")
        {
            if (baseStat == BaseStat.Hp) return StatType.HpFlat;
            if (baseStat == BaseStat.Atk) return StatType.AtkFlat;
            if (baseStat == BaseStat.Def) return StatType.DefFlat;
            if (baseStat == BaseStat.Spd) return StatType.SpdFlat;
        }

        throw new ArgumentException("arg must be \"Percent\" or \"Flat\"", nameof(arg));
    }
}