namespace Relictify.Backend.Characters.Builder;

public class CharacterBuilderDirector
{
    private readonly ICharacterBuilder _builder;

    public CharacterBuilderDirector(ICharacterBuilder builder)
    {
        this._builder = builder;
    }

    public Character EmptyCharacter()
    {
        this._builder.Start();
        return this._builder.Build();
    }
}