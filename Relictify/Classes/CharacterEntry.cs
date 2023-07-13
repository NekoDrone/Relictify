namespace Relictify
{
    public class CharacterEntry
    {
        public bool IsActive { get; private set; }
        public Character Character { get; private set; }
        public LightCone LightCone { get; private set; }
        public Relics Relics { get; private set; }
        public double HP { get; private set; }
        public double Atk { get; private set; }
        public double Def { get; private set; }
        public double Spd { get; private set; }
        public double CritRate { get; private set; }
        public double CritDmg { get; private set; }
        public double BreakEffect { get; private set; }
        public double OutgoingHealing { get; private set; }
        public double ERR { get; private set; }
        public double EHR { get; private set; }
        public double EffectRes { get; private set; }
        public double ElementalDamage { get; private set; }
        public List<CalcModifier> CalcModifiers { get; private set; }

        public CharacterEntry(Character Character)
        {
            this.IsActive = false;
            this.Character = Character;
            this.Relics = new Relics();
            this.CalcModifiers = new List<CalcModifier>();
            this.LightCone = new LightCone("Blank LC");
            CalculateAllStats();
        }

        public void LoadCalcModifiers()
        {
            foreach (CalcModifier modifier in this.Character.CalcModifiers) this.CalcModifiers.Add(modifier);
            foreach (CalcModifier modifier in this.LightCone.CalcModifiers) this.CalcModifiers.Add(modifier);
            foreach (CalcModifier modifier in this.Relics.CalcModifiers) this.CalcModifiers.Add(modifier);
        }

        public void CalculateAllStats()
        {
            LoadCalcModifiers();

            this.HP = StatsCalc.CalculateBaseStat(this, BaseStat.Hp);
            this.Atk = StatsCalc.CalculateBaseStat(this, BaseStat.Atk);
            this.Def = StatsCalc.CalculateBaseStat(this, BaseStat.Def);
            this.Spd = StatsCalc.CalculateBaseStat(this, BaseStat.Spd);

            this.CritRate = StatsCalc.CalculateAdditiveStats(this, StatType.CritRate) + 5;
            this.CritDmg = StatsCalc.CalculateAdditiveStats(this, StatType.CritDmg) + 50;
            this.BreakEffect = StatsCalc.CalculateAdditiveStats(this, StatType.BreakEffect);
            this.OutgoingHealing = StatsCalc.CalculateAdditiveStats(this, StatType.OutgoingHealing);
            this.ERR = StatsCalc.CalculateAdditiveStats(this, StatType.ERR);
            this.EHR = StatsCalc.CalculateAdditiveStats(this, StatType.EHR);
            this.EffectRes = StatsCalc.CalculateAdditiveStats(this, StatType.EffectRes);
            this.ElementalDamage = StatsCalc.CalculateAdditiveStats(this, StatType.ElementalDamage);
        }
    }
}