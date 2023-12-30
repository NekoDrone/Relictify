using Relictify.Backend.API;

namespace Relictify.Startup;

public interface IStartupService
{
    public CharacterManifest GetCharacterManifest();
    public RelicManifest GetRelicManifest();
    public CharacterManifestItem GetCharacterFromManifest(string name);
    public RelicManifestItem GetRelicFromManifest(int id);
}