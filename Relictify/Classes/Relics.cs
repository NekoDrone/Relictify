namespace Relictify
{

    public class Relic
    {
        public RelicType RelicType { get; private set; }
        public string RelicSet { get; private set; }
        public Stat MainStat { get; private set; }
        public Stat SubStat1 { get; private set; }
        public Stat SubStat2 { get; private set; }
        public Stat SubStat3 { get; private set; }
        public Stat SubStat4 { get; private set; }
        public int Level { get; private set; }

        public Relic(RelicType relicType, Stat mainStat)
        {
            this.RelicType = relicType;
            this.RelicSet = "Empty Relic";
            this.MainStat = mainStat;
            this.SubStat1 = new Stat(StatType.None);
            this.SubStat2 = new Stat(StatType.None);
            this.SubStat3 = new Stat(StatType.None);
            this.SubStat4 = new Stat(StatType.None);
            this.Level = 0;
        }

        public double GetAllStatSum(StatType statType)
        {
            if (MainStat.StatType == statType) return MainStat.Value;
            if (SubStat1.StatType == statType) return SubStat1.Value;
            if (SubStat2.StatType == statType) return SubStat2.Value;
            if (SubStat3.StatType == statType) return SubStat3.Value;
            if (SubStat4.StatType == statType) return SubStat4.Value;
            return 0;
        }

        public void SetStat(int index, StatType statType)
        {
            if (statType == this.MainStat.StatType
                || statType == this.SubStat1.StatType
                || statType == this.SubStat2.StatType
                || statType == this.SubStat3.StatType
                || statType == this.SubStat4.StatType //prevent dupes
                || this.Level > 2) return; 

            if (index == 0) this.MainStat.StatType = statType;
            else if (index == 1) this.SubStat1.StatType = statType;
            else if (index == 2) this.SubStat2.StatType = statType;
            else if (index == 3) this.SubStat3.StatType = statType;
            else if (index == 4) this.SubStat4.StatType = statType;
            ReloadStats();
        }

        private void ReloadStats()
        {
            MainStat.ReloadStat();
            SubStat1.ReloadStat();
            SubStat2.ReloadStat();
            SubStat3.ReloadStat();
            SubStat4.ReloadStat();
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
        public string CavernSet2pc1 { get; private set; }
        public string CavernSet2pc2 { get; private set; }
        public string CavernSet4pc { get; private set; }
        public string PlanarSet { get; private set; }
        public Relic HeadRelic { get; private set; }
        public Relic HandsRelic { get; private set; }
        public Relic BodyRelic { get; private set; }
        public Relic FeetRelic { get; private set; }
        public Relic SphereRelic { get; private set; }
        public Relic RopeRelic { get; private set; }
        public List<CalcModifier> CalcModifiers { get; private set; }

        public Relics()
        {
            this.CavernSet2pc1 = "";
            this.CavernSet2pc2 = "";
            this.CavernSet4pc = "";
            this.PlanarSet = "";
            this.HeadRelic = new Relic(RelicType.Head, new Stat());
            this.HandsRelic = new Relic(RelicType.Hands, new Stat());
            this.BodyRelic = new Relic(RelicType.Body, new Stat());
            this.FeetRelic = new Relic(RelicType.Feet, new Stat());
            this.SphereRelic = new Relic(RelicType.Sphere, new Stat());
            this.RopeRelic = new Relic(RelicType.Rope, new Stat());
            this.CalcModifiers = new List<CalcModifier>();
        }

        public double GetStatSum(StatType statType)
        {
            double statSum = 0;
            statSum += HeadRelic.GetAllStatSum(statType);
            statSum += HandsRelic.GetAllStatSum(statType);
            statSum += BodyRelic.GetAllStatSum(statType);
            statSum += FeetRelic.GetAllStatSum(statType);
            statSum += SphereRelic.GetAllStatSum(statType);
            statSum += RopeRelic.GetAllStatSum(statType);
            return statSum;
        }

        public void AssignCalcModifiers()
        {

        }
    }

}