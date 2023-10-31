using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics.Builder;

public class RelicBuilder : IRelicBuilder
{
    private Relic? _relic;

    public RelicBuilder()
    {
        this.Start();
    }
    
    public void Start()
    {
        this._relic = new Relic();
    }

    public void SetRelicType(RelicType relicType)
    {
        if(this._relic is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._relic.RelicType = relicType;
    }

    public void SetMainStat(StatType statType)
    {
        if(this._relic is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._relic.SetMainStat(statType);
    }

    public Relic Build()
    {
        if(this._relic is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        return this._relic;
    }

    public void Reset()
    {
        this.Start();
    }
}