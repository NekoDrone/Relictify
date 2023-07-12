namespace Relictify
{
    public class LightCone
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Ascension { get; set; }
        public List<CalcModifier> CalcModifiers { get; set; }
        public double LightConeHP { get; set; }
        public double LightConeAtk { get; set; }
        public double LightConeDef { get; set; }

        public LightCone(string name)
        {
            this.Name = name;
            this.Level = 1;
            this.Ascension = 0;
            this.CalcModifiers = new List<CalcModifier>();
        }
    }

}