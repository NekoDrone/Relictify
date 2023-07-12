namespace Relictify
{
    public class Character
    {
        public int Rarity { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public string Path { get; set; }
        public int? Level { get; set; }
        public int? Ascension { get; set; }
        public List<CalcModifier> CalcModifiers { get; set; }
        public double BaseHP { get; set; }
        public double BaseAtk { get; set; }
        public double BaseDef { get; set; }
        public double BaseSpd { get; set; }

        public Character(int rarity, string name, string element, string path)
        {
            this.Rarity = rarity;
            this.Name = name;
            this.Element = element;
            this.Path = path;
            this.CalcModifiers = new List<CalcModifier>();
        }
    }
}