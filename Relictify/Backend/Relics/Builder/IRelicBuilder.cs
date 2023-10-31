using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics.Builder;

public interface IRelicBuilder
{
    public void StartBuildingNewRelic();
    public void SetRelicType(RelicType relicType);
    public void SetMainStat(StatType statType);
    public Relic Build();
}