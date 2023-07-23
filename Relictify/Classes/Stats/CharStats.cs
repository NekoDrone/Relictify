namespace Relictify
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
            Hp = new Stat(StatType.HpFlat);
            Atk = new Stat(StatType.AtkFlat);
            Def = new Stat(StatType.DefFlat);
            Spd = new Stat(StatType.SpdFlat);
            CritRate = new Stat(StatType.CritRate);
            CritDmg = new Stat(StatType.CritDmg);
            BreakEffect = new Stat(StatType.BreakEffect);
            OutgoingHealing = new Stat(StatType.OutgoingHealing);
            ERR = new Stat(StatType.ERR);
            EHR = new Stat(StatType.EHR);
            EffectRes = new Stat(StatType.EffectRes);
            ElementalDamage = new Stat(StatType.ElementalDamage);
        }
    }

}
