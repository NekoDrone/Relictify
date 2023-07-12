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

*/
namespace Relictify
{
    using System.Collections.Generic;

    public static class StatsCalc
    {
        public static double CalculateStat(double baseStat, List<double> relicStatPercentBonusList, List<double> relicStatFlatBonusList)
        {
            double relicStatPercentBonus = 0;
            foreach (double statPercentBonus in relicStatPercentBonusList)
            {
                relicStatPercentBonus += statPercentBonus;
            }
            double relicStatFlatBonus = 0;
            foreach (double statFlatBonus in relicStatFlatBonusList)
            {
                relicStatFlatBonus += statFlatBonus;
            }
            return (baseStat * (1 + relicStatPercentBonus / 100)) + relicStatFlatBonus;
        }
        public static double CalculateAdditiveStats(List<double> statList, double startingValue) //use for CR, CDMG, Break Effect, Outgoing Healing, EHR, Effect RES, and elemental damage.
        {
            //startingValue == 5 for CR, 50 for CDMG, 0 for Break Effect, Outgoing Healing, EHR, Effect RES and Elemental Damage.
            double res = startingValue;
            foreach (double stat in statList)
            {
                res += stat;
            }
            return res;
        }



        public static List<double> PrepareStatsList(Relic[] relics, StatType statType, List<CalcModifier> CalcModifiers)
        {
            List<double> statsList = new();
            foreach (Relic relic in relics)
            {
                statsList.Add(relic.MainStat.Value);
                statsList.Add(relic.SubStat1.Value);
                statsList.Add(relic.SubStat2.Value);
                statsList.Add(relic.SubStat3.Value);
                statsList.Add(relic.SubStat4.Value);
            }
            foreach (CalcModifier modifier in CalcModifiers) if (modifier.StatModified == statType) statsList.Add(modifier.Value);
            return statsList;
        }

        private static double CalculateBaseStat(Relic[] relics, double charStat, double lightConeStat, StatType percent, StatType flat, List<CalcModifier> CalcModifiers)
        {
            List<double> PercentList = StatsCalc.PrepareStatsList(relics, percent, CalcModifiers);
            List<double> FlatList = StatsCalc.PrepareStatsList(relics, flat, CalcModifiers);

            double baseHP = charStat + lightConeStat;
            return StatsCalc.CalculateStat(baseHP, PercentList, FlatList);
        }
    }
}