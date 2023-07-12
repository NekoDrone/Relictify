namespace Relictify
{
    public class CharacterEntry
    {
        public bool IsActive { get; set; }
        public Character Character { get; set; }
        public LightCone? LightCone { get; set; }
        public Relics Relics { get; set; }

        public CharacterEntry(Character Character)
        {
            this.IsActive = false;
            this.Character = Character;
            this.Relics = new Relics();
        }

    }
}