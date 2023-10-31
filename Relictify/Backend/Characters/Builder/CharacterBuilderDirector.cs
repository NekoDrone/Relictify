namespace Relictify.Backend.Characters.Builder;

public static class CharacterBuilderDirector
{
    private static readonly ICharacterBuilder Builder;

    static CharacterBuilderDirector()
    {
        Builder = new CharacterBuilder();
    }

    public static Character NewEmptyCharacter()
    {
        Builder.Start();
        return Builder.Build();
    }
}