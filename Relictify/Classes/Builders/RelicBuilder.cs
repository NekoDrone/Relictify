namespace Relictify
{
    public class RelicBuilder : IRelicBuilder
    {
        private Relic? Relic { get; set; }

        public void StartBuildingNewRelic()
        {
            Relic = new Relic();
        }

        public void SetRelicType(RelicType relicType)
        {
            if (Relic is null) throw new ArgumentNullException(nameof(Relic), "Relic not instantiated. Call StartBuildingNewRelic() before accessing this method.");
            Relic.SetRelicType(relicType);
        }

        public void SetMainStat(StatType statType)
        {
            if(Relic is null) throw new ArgumentNullException(nameof(Relic), "Relic not instantiated. Call StartBuildingNewRelic() before accessing this method.");
            Relic.SetMainStat(statType);
        }

        public Relic FinishRelic()
        {
            if (Relic is null) throw new ArgumentNullException(nameof(Relic), "Relic not instantiated. Call StartBuildingNewRelic() before accessing this method.");
            Relic result = Relic;
            StartBuildingNewRelic();
            return result;
        }
    }
}
