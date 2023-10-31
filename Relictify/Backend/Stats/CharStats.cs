namespace Relictify.Backend.Stats
{
    public class CharStats
    {
        public Stat Hp;
        public Stat Atk;
        public Stat Def;
        public Stat Spd;
        public Stat CritRate;
        public Stat CritDmg;
        public Stat BreakEffect;
        public Stat OutgoingHealing;
        public Stat ERR;
        public Stat EHR;
        public Stat EffectRes;
        public Stat ElementalDamage;

        public CharStats()
        {
            this.Hp = new Stat(StatType.HpFlat);
            this.Atk = new Stat(StatType.AtkFlat);
            this.Def = new Stat(StatType.DefFlat);
            this.Spd = new Stat(StatType.SpdFlat);
            this.CritRate = new Stat(StatType.CritRate);
            this.CritDmg = new Stat(StatType.CritDmg);
            this.BreakEffect = new Stat(StatType.BreakEffect);
            this.OutgoingHealing = new Stat(StatType.OutgoingHealing);
            this.ERR = new Stat(StatType.ERR);
            this.EHR = new Stat(StatType.EHR);
            this.EffectRes = new Stat(StatType.EffectRes);
            this.ElementalDamage = new Stat(StatType.ElementalDamage);
        }
    }

}
