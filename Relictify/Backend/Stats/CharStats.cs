namespace Relictify.Backend.Stats;

public class CharStats
{
    public Stat Atk;
    public Stat BreakEffect;
    public Stat CritDmg;
    public Stat CritRate;
    public Stat Def;
    public Stat EffectRes;
    public Stat EHR;
    public Stat ElementalDamage;
    public Stat ERR;
    public Stat Hp;
    public Stat OutgoingHealing;
    public Stat Spd;

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