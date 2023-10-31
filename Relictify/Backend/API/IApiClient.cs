using Relictify.Backend.Characters;
using Relictify.Backend.Relics;

namespace Relictify.Backend.API;

public interface IApiClient
{
    public Dictionary<string, Character> GetCharacterManifest();
    public Dictionary<int, string> GetRelicManifest();
    
}