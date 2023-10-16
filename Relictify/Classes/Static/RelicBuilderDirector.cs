namespace Relictify
{
    public static class RelicBuilderDirector
    {
        public static Relic BuildHeadRelic()
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Head);
            relicBuilder.SetMainStat(StatType.HpFlat);
            return relicBuilder.FinishRelic();
        }
        public static Relic BuildHandsRelic()
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Hands);
            relicBuilder.SetMainStat(StatType.AtkFlat);
            return relicBuilder.FinishRelic();
        }
        public static Relic BuildFeetRelic(StatType statType)
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Feet);
            relicBuilder.SetMainStat(statType);
            return relicBuilder.FinishRelic();
        }
        public static Relic BuildBodyRelic(StatType statType)
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Body);
            relicBuilder.SetMainStat(statType);
            return relicBuilder.FinishRelic();
        }
        public static Relic BuildRopeRelic(StatType statType)
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Rope);
            relicBuilder.SetMainStat(statType);
            return relicBuilder.FinishRelic();
        }
        public static Relic BuildSphereRelic(StatType statType)
        {
            RelicBuilder relicBuilder = new RelicBuilder();
            relicBuilder.StartBuildingNewRelic();
            relicBuilder.SetRelicType(RelicType.Sphere);
            relicBuilder.SetMainStat(statType);
            return relicBuilder.FinishRelic();
        }

    }
}
