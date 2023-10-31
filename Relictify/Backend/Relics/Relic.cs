using System.Text;
using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics;

public class Relic
{
    public readonly string Identifier;
    public RelicType RelicType { get; set; }
    public RelicSet RelicSet { get; set; }
    public MainStat MainStat { get; }
    public SubStat SubStat1 { get; }
    public SubStat SubStat2 { get; }
    public SubStat SubStat3 { get; }
    public SubStat SubStat4 { get; }
    public int Level { get; }

    public Relic()
    {
        this.RelicType = RelicType.Blank;
        this.RelicSet = RelicSet.None;
        this.MainStat = new MainStat();
        this.SubStat1 = new SubStat();
        this.SubStat2 = new SubStat();
        this.SubStat3 = new SubStat();
        this.SubStat4 = new SubStat();
        this.Level = 0;
        this.Identifier = this.ConstructIdentifier();
    }

    public Relic(RelicType relicType, MainStat mainStat)
    {
        this.RelicType = relicType;
        this.RelicSet = RelicSet.None;
        this.MainStat = mainStat;
        this.SubStat1 = new SubStat();
        this.SubStat2 = new SubStat();
        this.SubStat3 = new SubStat();
        this.SubStat4 = new SubStat();
        this.Level = 0;
        this.Identifier = this.ConstructIdentifier();
    }
    
    private string ConstructIdentifier()
    {
        string epochTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        string relicSet = this.RelicSet.ToString();
        string relicType = this.RelicType.ToString();
        string id = $"{epochTime}-{relicSet}-{relicType}";
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(id)).Substring(0, 10);
    }

    public double GetStat(StatType statType)
    {
        if (this.MainStat.StatType == statType) return this.MainStat.Value;
        if (this.SubStat1.StatType == statType) return this.SubStat1.Value;
        if (this.SubStat2.StatType == statType) return this.SubStat2.Value;
        if (this.SubStat3.StatType == statType) return this.SubStat3.Value;
        if (this.SubStat4.StatType == statType) return this.SubStat4.Value;
        return 0;
    }

    public void SetSubStat(int index, StatType statType)
    {
        if (statType == this.MainStat.StatType)
            throw new InvalidOperationException(
                "A relic's substat type cannot be a duplicate of it's main stat type.");

        if (statType == this.SubStat1.StatType
            || statType == this.SubStat2.StatType
            || statType == this.SubStat3.StatType
            || statType == this.SubStat4.StatType // Prevent dupes. Only one substat of that type is allowed.
            || this.Level > 2) return;

        switch (index)
        {
            case 1:
                this.SubStat1.StatType = statType;
                break;
            case 2:
                this.SubStat2.StatType = statType;
                break;
            case 3:
                this.SubStat3.StatType = statType;
                break;
            case 4:
                this.SubStat4.StatType = statType;
                break;
        }
    }

    public void SetMainStat(StatType statType)
    {
        if (statType == this.MainStat.StatType) return;
        if (statType == this.SubStat1.StatType
            || statType == this.SubStat2.StatType
            || statType == this.SubStat3.StatType
            || statType == this.SubStat4.StatType)
            throw new InvalidOperationException(
                "A relic's main stat type cannot be a duplicate of it's substat types.");
        this.MainStat.StatType = statType;
    }

    public void ReloadStats()
    {
        this.MainStat.ReloadMainStat();
        this.SubStat1.ReloadSubStat();
        this.SubStat2.ReloadSubStat();
        this.SubStat3.ReloadSubStat();
        this.SubStat4.ReloadSubStat();
    }
}