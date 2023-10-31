namespace Relictify.StateManagement
{
    //Technically this is not an enum, but it's as good
    //as an enum, and behaves almost like an enum.
    public class Page
    {
        private Page(string value)
        {
            this.Value = value;
        }
        private string Value { get; set; }
        public static Page None => new("None");
        public static Page Details => new("Details");
        public static Page LightCone => new("Light Cone");
        public static Page Relics => new("Relics");
        public override string ToString()
        {
            return this.Value;
        }
    }
}