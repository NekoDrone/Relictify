namespace Relictify.Backend.API;

public class MockApiClient : IApiClient
{
    // Mock API client is provided to mock API connections. This is a local copy and returns simple JSON for testing.
    // This class does not make any external calls.
    // The provided dev mock for the manifests are updated as of HSR v1.4, and will likely not shift
    // since it's for development purposes.
    public async Task<CharacterManifest> GetCharacterManifestAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<RelicManifest> GetRelicManifestAsync()
    {
        throw new NotImplementedException();
    }
}