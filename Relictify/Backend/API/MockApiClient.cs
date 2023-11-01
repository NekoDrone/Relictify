namespace Relictify.Backend.API;

public class MockApiClient : IApiClient
{
    public Task<CharacterManifest> GetCharacterManifestAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RelicManifest> GetRelicManifestAsync()
    {
        throw new NotImplementedException();
    }
}