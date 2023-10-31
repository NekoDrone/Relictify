using Relictify.Backend.Characters;

namespace Relictify.Backend.API;

public interface IApiClient
{
    public Dictionary<string, Character> GetCharacterManifest();
    public Dictionary<int, string> GetRelicManifest();
}