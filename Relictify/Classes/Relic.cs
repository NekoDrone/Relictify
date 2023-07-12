namespace Relictify
{
    public class Relic
    {
        public RelicType RelicType { get; private set; }
        public RelicSet RelicSet { get; private set; }
        public MainStat MainStat { get; private set; }
        public SubStat SubStat1 { get; private set; }
        public SubStat SubStat2 { get; private set; }
        public SubStat SubStat3 { get; private set; }
        public SubStat SubStat4 { get; private set; }
        public int Level { get; private set; }

        public Relic(RelicType relicType, MainStat mainStat)
        {
            this.RelicType = relicType;
            this.RelicSet = RelicSet.None;
            this.MainStat = mainStat;
            this.SubStat1 = new SubStat();
            this.SubStat2 = new SubStat();
            this.SubStat3 = new SubStat();
            this.SubStat4 = new SubStat();
            this.Level = 0;
        }

        public Relic()
        {
            this.RelicType = RelicType.Blank;
            this.RelicSet = RelicSet.None;
            this.MainStat = new MainStat();
            this.SubStat1 = new SubStat();
            this.SubStat2 = new SubStat();
            this.SubStat3 = new SubStat();
            this.SubStat4 = new SubStat();
            this.Level = 0;

        }

        public double GetStat(StatType statType)
        {
            if (MainStat.StatType == statType) return MainStat.Value;
            if (SubStat1.StatType == statType) return SubStat1.Value;
            if (SubStat2.StatType == statType) return SubStat2.Value;
            if (SubStat3.StatType == statType) return SubStat3.Value;
            if (SubStat4.StatType == statType) return SubStat4.Value;
            return 0;
        }

        public void SetSubStat(int index, StatType statType)
        {
            if (statType == this.SubStat1.StatType
                || statType == this.SubStat2.StatType
                || statType == this.SubStat3.StatType
                || statType == this.SubStat4.StatType //prevent dupes
                || this.Level > 2) return;

            if (index == 1) this.SubStat1.StatType = statType;
            else if (index == 2) this.SubStat2.StatType = statType;
            else if (index == 3) this.SubStat3.StatType = statType;
            else if (index == 4) this.SubStat4.StatType = statType;
            ReloadStats();
        }

        public void SetMainStat(StatType statType)
        {
            if (statType == this.MainStat.StatType) return;
            this.MainStat.StatType = statType;
            ReloadStats();
        }

        private void ReloadStats()
        {
            MainStat.ReloadMainStat();
            SubStat1.ReloadSubStat();
            SubStat2.ReloadSubStat();
            SubStat3.ReloadSubStat();
            SubStat4.ReloadSubStat();
        }
    }

    public enum RelicType
    {
        Head,
        Hands,
        Body,
        Feet,
        Sphere,
        Rope,
        Blank
    }
}

