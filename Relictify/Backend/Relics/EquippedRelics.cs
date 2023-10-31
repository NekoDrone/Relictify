using Relictify.Backend.Relics.Builder;
using Relictify.Backend.Stats;

namespace Relictify.Backend.Relics
{
    public class EquippedRelics
    {
        public RelicSet CavernSet2Pc1 { get; private set; } = RelicSet.None;
        public RelicSet CavernSet2Pc2 { get; private set; } = RelicSet.None;
        public RelicSet CavernSet4Pc { get; private set; } = RelicSet.None;
        public RelicSet PlanarSet { get; private set; } = RelicSet.None;
        public Relic HeadRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Head);
        public Relic HandsRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Hands);
        public Relic BodyRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Body);
        public Relic FeetRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Feet);
        public Relic SphereRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Sphere);
        public Relic RopeRelic { get; private set; } = RelicBuilderDirector.NewBlankRelic(RelicType.Rope);
        public List<MiscStat> MiscStats { get; private set; } = new(); //TODO: Relic set to MiscStat mapping.

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
            switch (relic.RelicType)
            {
                case RelicType.Head:
                    this.HeadRelic = relic;
                    break;
                case RelicType.Hands:
                    this.HandsRelic = relic;
                    break;
                case RelicType.Feet:
                    this.FeetRelic = relic;
                    break;
                case RelicType.Body:
                    this.BodyRelic = relic;
                    break;
                case RelicType.Rope:
                    this.RopeRelic = relic;
                    break;
                case RelicType.Sphere:
                    this.SphereRelic = relic;
                    break;
                case RelicType.Blank:
                    throw new ArgumentException("Not allowed to equip relic of type 'Blank'", nameof(relic));
                    break;
                default:
                    throw new ArgumentException("Provided relic did not have valid relic type.", nameof(relic));
            }
        }
    }

}