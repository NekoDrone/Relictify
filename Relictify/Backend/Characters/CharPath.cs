namespace Relictify.Backend.Characters
{
    //Technically this is not an enum, but it's as good
    //as an enum, and behaves almost like an enum.
    public class CharPath
    {
        private CharPath(string value)
        {
            this.Value = value;
        }
        private string Value { get; set; }
        public static CharPath None => new("None");
        public static CharPath Destruction => new("Destruction");
        public static CharPath Preservation => new("Preservation");
        public static CharPath TheHunt => new("The Hunt");
        public static CharPath Erudition => new("Erudition");
        public static CharPath Harmony => new("Harmony");
        public static CharPath Nihility => new("Nihility");
        public static CharPath Abundance => new("Abundance");
        public override string ToString()
        {
            return this.Value;
        }
    }
}
