namespace Relictify
{
    public class RelicsContainer
    {
        public RelicSet CavernSet2pc1 { get; private set; }
        public RelicSet CavernSet2pc2 { get; private set; }
        public RelicSet CavernSet4pc { get; private set; }
        public RelicSet PlanarSet { get; private set; }
        public Relic HeadRelic { get; private set; }
        public Relic HandsRelic { get; private set; }
        public Relic BodyRelic { get; private set; }
        public Relic FeetRelic { get; private set; }
        public Relic SphereRelic { get; private set; }
        public Relic RopeRelic { get; private set; }
        public List<MiscStat> MiscStats { get; private set; }

        public RelicsContainer()
        {
            this.CavernSet2pc1 = RelicSet.None;
            this.CavernSet2pc2 = RelicSet.None;
            this.CavernSet4pc = RelicSet.None;
            this.PlanarSet = RelicSet.None;

            this.HeadRelic = RelicBuilderDirector.BuildHeadRelic();
            this.HandsRelic = RelicBuilderDirector.BuildHandsRelic();
            this.BodyRelic = RelicBuilderDirector.BuildBodyRelic(StatType.None);
            this.FeetRelic = RelicBuilderDirector.BuildFeetRelic(StatType.None);
            this.SphereRelic = RelicBuilderDirector.BuildSphereRelic(StatType.None);
            this.RopeRelic = RelicBuilderDirector.BuildRopeRelic(StatType.None);
            this.MiscStats = new List<MiscStat>();
        }

        public double GetStatSum(StatType statType)
        {
            double statSum = 0;
            statSum += HeadRelic.GetStat(statType);
            statSum += HandsRelic.GetStat(statType);
            statSum += BodyRelic.GetStat(statType);
            statSum += FeetRelic.GetStat(statType);
            statSum += SphereRelic.GetStat(statType);
            statSum += RopeRelic.GetStat(statType);
            return statSum;
        }
    }

}