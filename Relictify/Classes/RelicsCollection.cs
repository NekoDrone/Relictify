namespace Relictify
{
    public class RelicsCollection
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
        public List<CalcModifier> CalcModifiers { get; private set; }

        public RelicsCollection()
        {
            this.CavernSet2pc1 = RelicSet.None;
            this.CavernSet2pc2 = RelicSet.None;
            this.CavernSet4pc = RelicSet.None;
            this.PlanarSet = RelicSet.None;

            RelicBuilder builder = new RelicBuilder();
            this.HeadRelic = builder.ToRelic();
            this.HandsRelic = builder.ToRelic();
            this.BodyRelic = builder.ToRelic();
            this.FeetRelic = builder.ToRelic();
            this.SphereRelic = builder.ToRelic();
            this.RopeRelic = builder.ToRelic();
            this.CalcModifiers = new List<CalcModifier>();
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

        public void GetCalcModifiers()
        {
            RelicSet[] bonuses = new RelicSet[3];
            if
        }
    }

}