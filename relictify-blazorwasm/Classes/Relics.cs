namespace Relictify
{
    public class CharacterEntry
    {
        public bool IsActive { get; set; }
        public Character Character { get; set; }
        public LightCone LightCone { get; set; }
        public Relics Relics { get; set; }
        public double HP { get; set; } //put the stats here because characters provide base stats only. Use the StatsCalc static class to calculate from base.
        public double Atk { get; set; }
        public double Def { get; set; }
        public double Spd { get; set; }
        public double CritRate { get; set; }
        public double CritDmg { get; set; }
        public double BreakEffect { get; set; }
        public double OutgoingHealing { get; set; }
        public double ERR { get; set; }
        public double EHR { get; set; }
        public double EffectRes { get; set; }
        public double ElementalDamage { get; set; } //don't need to make lists because you just use the prepare function to insert it in. (i love method chaining)?? WHY?? you need to store the list for additional calcs...
        public List<CalcModifier> CalcModifiers { get; set; }

        public CharacterEntry(Character Character)
        {
            this.IsActive = false;
            this.Character = Character;
            this.Relics = new Relics();
            this.CalcModifiers = new List<CalcModifier>();
            this.LightCone = new LightCone("Blank LC");
        }

        private bool HasLightCone()
        {
            return this.LightCone != null;
        }
        public Relic[] LoadRelics()
        {
            Relics relics = this.Relics;
            Relic[] allRelics = new Relic[6];
            allRelics[0] = relics.HeadRelic;
            allRelics[1] = relics.HandsRelic;
            allRelics[2] = relics.BodyRelic;
            allRelics[3] = relics.HandsRelic;
            allRelics[4] = relics.SphereRelic;
            allRelics[5] = relics.RopeRelic;
            return allRelics;
        }

        public void LoadCalcModifiers()
        {
            foreach (CalcModifier modifier in this.Character.CalcModifiers) this.CalcModifiers.Add(modifier);
            foreach (CalcModifier modifier in this.Relics.CalcModifiers) this.CalcModifiers.Add(modifier);
            if (HasLightCone()) foreach (CalcModifier modifier in LightCone.CalcModifiers) this.CalcModifiers.Add(modifier);
        }

        public void CalculateAllStats()
        {
            Relic[] relics = LoadRelics();
            this.HP = StatsCalc.CalculateBaseStat(relics, this.Character.BaseHP, this.LightCone.LightConeHP, StatType.HPPercent, StatType.HP);
            this.Atk = StatsCalc.CalculateBaseStat(relics, this.Character.BaseAtk, this.LightCone.LightConeAtk, StatType.AtkPercent, StatType.Atk);
            this.Def = StatsCalc.CalculateBaseStat(relics, this.Character.BaseDef, this.LightCone.LightConeDef, StatType.DefPercent, StatType.Def);
            this.Spd = StatsCalc.CalculateBaseStat(relics, this.Character.BaseSpd, 0, StatType.SpdPercent, StatType.Spd);
            this.CritRate = StatsCalc.CalculateAdditiveStats();
            this.CritDmg = CalculateCritDmg(relics);
            this.BreakEffect = CalculateBreakEffect(relics);
            this.OutgoingHealing = CalculateOutgoingHealing(relics);
            this.ERR = CalculateERR(relics);
        }
    }
}