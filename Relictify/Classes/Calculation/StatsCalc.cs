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

        public static double CalculateAdditiveStats(CharacterEntry characterEntry, StatType additiveStat)
        {
            //reminder to add 5 for CR, 50 for CDMG

            characterEntry.LoadCalcModifiers();
            double statSum = characterEntry.Relics.GetStatSum(additiveStat);
            foreach (CalcModifier modifier in characterEntry.CalcModifiers)
                if (modifier.StatModified == additiveStat)
                    statSum += modifier.Value;
            return statSum;

        }

        public static double CalculateBaseStat(CharacterEntry characterEntry, BaseStat baseStat)
        {
            StatType percent = StatType.None;
            StatType flat = StatType.None;

            if (baseStat == BaseStat.Hp) { percent = StatType.HpPercent; flat = StatType.HpFlat; }
            else if (baseStat == BaseStat.Atk) { percent = StatType.AtkPercent; flat = StatType.AtkFlat; }
            else if (baseStat == BaseStat.Def) { percent = StatType.DefPercent; flat = StatType.DefFlat; }
            else if (baseStat == BaseStat.Spd) { percent = StatType.SpdPercent; flat = StatType.SpdFlat; }
            else return 0; //case switch bad >:( | i just prefer using if-elses unless its super performance heavy

            double percentSum = characterEntry.Relics.GetStatSum(percent);
            double flatSum = characterEntry.Relics.GetStatSum(flat);

            characterEntry.LoadCalcModifiers();
            foreach (CalcModifier modifier in characterEntry.CalcModifiers)
            {
                if (modifier.StatModified == percent) percentSum += modifier.Value;
                else if (modifier.StatModified == flat) flatSum += modifier.Value;
            }

            double baseStatValue = characterEntry.Character.GetBaseStat(flat) + characterEntry.LightCone.GetBaseStat(flat);

            return (baseStatValue * (1 + percentSum / 100)) + flatSum;
        }
    }
}