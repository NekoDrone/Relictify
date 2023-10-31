using Relictify.Backend.Relics.Builder;
using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics
{
    public class EquippedRelics
    {
        public RelicSet CavernSet2Pc1 { get; private set; }
        public RelicSet CavernSet2Pc2 { get; private set; }
        public RelicSet CavernSet4Pc { get; private set; }
        public RelicSet PlanarSet { get; private set; }
        public Relic HeadRelic { get; private set; }
        public Relic HandsRelic { get; private set; }
        public Relic BodyRelic { get; private set; }
        public Relic FeetRelic { get; private set; }
        public Relic SphereRelic { get; private set; }
        public Relic RopeRelic { get; private set; }
        public List<MiscStat> MiscStats { get; private set; }

        public EquippedRelics()
        {
            this.CavernSet2Pc1 = RelicSet.None;
            this.CavernSet2Pc2 = RelicSet.None;
            this.CavernSet4Pc = RelicSet.None;
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
            statSum += this.HeadRelic.GetStat(statType);
            statSum += this.HandsRelic.GetStat(statType);
            statSum += this.BodyRelic.GetStat(statType);
            statSum += this.FeetRelic.GetStat(statType);
            statSum += this.SphereRelic.GetStat(statType);
            statSum += this.RopeRelic.GetStat(statType);
            return statSum;
        }

        public void EquipRelic(Relic relic)
        {
            if (relic.RelicType == RelicType.Head) this.HeadRelic = relic;
            if (relic.RelicType == RelicType.Hands) this.HandsRelic = relic;
            if (relic.RelicType == RelicType.Feet) this.FeetRelic = relic;
            if (relic.RelicType == RelicType.Body) this.BodyRelic = relic;
            if (relic.RelicType == RelicType.Rope) this.RopeRelic = relic;
            if (relic.RelicType == RelicType.Sphere) this.SphereRelic = relic;
        }
    }

}