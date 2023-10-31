using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics.Builder;

public interface IRelicBuilder
{
    public void Start();
    public void SetRelicType(RelicType relicType);
    public void SetMainStat(StatType statType);
    public Relic Build();
    public void Reset();
}