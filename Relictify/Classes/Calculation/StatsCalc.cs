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
        public static double CalculateAdditiveStats(Relic[] relics, double startingValue, StatType statType, List<CalcModifier> CalcModifiers)
        {//use for CR, CDMG, Break Effect, Outgoing Healing, EHR, Effect RES, and elemental damage.
            //startingValue == 5 for CR, 50 for CDMG, 0 for Break Effect, Outgoing Healing, EHR, Effect RES and Elemental Damage.

            List<double> statList = PrepareStatsList(relics, statType, CalcModifiers);
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
                if(relic.MainStat.StatType == statType) statsList.Add(relic.MainStat.Value);
                if (relic.SubStat1.StatType == statType) statsList.Add(relic.SubStat1.Value);
                if (relic.SubStat2.StatType == statType) statsList.Add(relic.SubStat2.Value);
                if (relic.SubStat3.StatType == statType) statsList.Add(relic.SubStat3.Value);
                if (relic.SubStat4.StatType == statType) statsList.Add(relic.SubStat4.Value);
            }
            foreach (CalcModifier modifier in CalcModifiers) if (modifier.StatModified == statType) statsList.Add(modifier.Value);
            return statsList;
        }

        public static double CalculateBaseStat(Relic[] relics, double charStat, double lightConeStat, StatType percentStat, StatType flatStat, List<CalcModifier> CalcModifiers)
        {
            List<double> percentList = PrepareStatsList(relics, percentStat, CalcModifiers);
            List<double> flatList = PrepareStatsList(relics, flatStat, CalcModifiers);

            double baseStat = charStat + lightConeStat;
            double percent = 0;
            foreach (double percentBonus in percentList)
            {
                percent += percentBonus;
            }
            double flat = 0;
            foreach (double flatBonus in flatList)
            {
                flat += flatBonus;
            }
            return (baseStat * (1 + percent / 100)) + flat;
        }
    }
}