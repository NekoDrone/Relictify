using Relictify.Backend.API;

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

    public static Character BuildFromManifest(CharacterManifestItem manifestItem)
    {
        Builder.Start();
        Builder.SetPath(manifestItem.Path);
        Builder.SetElement(manifestItem.Element);
        Builder.SetName(manifestItem.Name);
        Builder.SetRarity(manifestItem.Rarity);
        Builder.SetStartingAtk(manifestItem.StartingAtk);
        Builder.SetStartingDef(manifestItem.StartingDef);
        Builder.SetStartingHp(manifestItem.StartingHp);
        Builder.SetStartingSpd(manifestItem.StartingSpd);
        return Builder.Build();
    }
}