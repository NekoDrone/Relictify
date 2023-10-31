using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics.Builder;

public static class RelicBuilderDirector
{
    private static readonly IRelicBuilder Builder;

    static RelicBuilderDirector()
    {
        Builder = new RelicBuilder();
    }

    public static Relic NewBlankRelic()
    {
        Builder.Start();
        return Builder.Build();
    }

    public static Relic NewBlankRelic(RelicType relicType)
    {
        Builder.Start();
        Builder.SetRelicType(relicType);
        if (relicType == RelicType.Head) Builder.SetMainStat(StatType.HpFlat);
        if (relicType == RelicType.Hands) Builder.SetMainStat(StatType.AtkFlat);
        return Builder.Build();
    }
}