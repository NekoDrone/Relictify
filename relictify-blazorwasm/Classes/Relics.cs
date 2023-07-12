namespace Relictify
{
    public class Relic
    {
        public RelicType RelicType { get; set; }
        public string RelicSet { get; set; }
        public Stat MainStat { get; set; }
        public Stat SubStat1 { get; set; }
        public Stat SubStat2 { get; set; }
        public Stat SubStat3 { get; set; }
        public Stat SubStat4 { get; set; }
        public int Level { get; set; }

        public Relic(RelicType relicType, string relicSet, Stat mainStat)
        {
            this.RelicType = relicType;
            this.RelicSet = relicSet;
            this.MainStat = mainStat;
            this.SubStat1 = new Stat(StatType.None);
            this.SubStat2 = new Stat(StatType.None);
            this.SubStat3 = new Stat(StatType.None);
            this.SubStat4 = new Stat(StatType.None);
            this.Level = 0;
        }

    }

    public enum RelicType
    {
        Head,
        Hands,
        Body,
        Feet,
        Sphere,
        Rope
    }

    public class Relics
    {
        public string CavernSet2pc { get; set; }
        public string CavernSet4pc { get; set; }
        public string PlanarSet { get; set; }
        public Relic HeadRelic { get; set; }
        public Relic HandsRelic { get; set; }
        public Relic BodyRelic { get; set; }
        public Relic FeetRelic { get; set; }
        public Relic SphereRelic { get; set; }
        public Relic RopeRelic { get; set; }
        public List<CalcModifier> CalcModifiers { get; set; }

        public Relics()
        {
            this.CavernSet2pc = "";
            this.CavernSet4pc = "";
            this.PlanarSet = "";
            this.HeadRelic = new Relic(RelicType.Head, "Empty Relic", new Stat(StatType.HP));
            this.HandsRelic = new Relic(RelicType.Hands, "Empty Relic", new Stat(StatType.Atk));
            this.BodyRelic = new Relic(RelicType.Body, "Empty Relic", new Stat(StatType.None));
            this.FeetRelic = new Relic(RelicType.Feet, "Empty Relic", new Stat(StatType.None));
            this.SphereRelic = new Relic(RelicType.Sphere, "Empty Relic", new Stat(StatType.None));
            this.RopeRelic = new Relic(RelicType.Rope, "Empty Relic", new Stat(StatType.None));
            this.CalcModifiers = new List<CalcModifier>();
        }
    }

}