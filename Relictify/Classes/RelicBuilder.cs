namespace Relictify
{
	public class RelicBuilder
	{
        private Relic Relic { get; set; }

        public RelicBuilder()
		{
			this.Relic = new Relic();
		}

		public RelicBuilder NewRelic(RelicType relicType)
		{
			this.Relic = new Relic(relicType, new MainStat());
			return this;
		}

		public RelicBuilder SetMainStat(StatType statType)
		{
			this.Relic.SetMainStat(statType);
			return this;
		}

		public Relic ToRelic()
		{
			Relic result = this.Relic;
			this.Relic = new Relic();
			return result;
		}
	}
}

