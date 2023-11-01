using Relictify.Backend.Characters;

namespace Relictify.Backend.API;

public interface IApiClient
{
    public Task<CharacterManifest> GetCharacterManifestAsync();
    public Task<RelicManifest> GetRelicManifestAsync();
}