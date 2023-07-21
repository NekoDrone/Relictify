namespace Relictify
{
	public interface IRelicBuilder
	{
		public void StartBuildingNewRelic();
		public void SetRelicType(RelicType relicType);
        public void SetMainStat(StatType statType);
		public Relic FinishRelic();
	}
}

