using System.Text.Json;

namespace Relictify.Backend.API;

public class MockApiClient : IApiClient
{
    // Mock API client is provided to mock API connections. This is a local copy and returns simple JSON for testing.
    // This class does not make any external calls.
    // The provided dev mock for the manifests are updated as of HSR v1.4, and will likely not shift
    // since it's for development purposes.
    public async Task<CharacterManifest> GetCharacterManifestAsync()
    {
        string jsonData = await File.ReadAllTextAsync("wwwroot/data/characters.json");
        CharacterManifest? manifest = JsonSerializer.Deserialize<CharacterManifest>(jsonData);
        return manifest ?? throw new InvalidOperationException(
            "JSON deserialization of Mock API data failed. Did you load data into 'wwwroot/data/characters.json' ?");
    }

    public async Task<RelicManifest> GetRelicManifestAsync()
    {
        string jsonData = await File.ReadAllTextAsync("wwwroot/data/relics.json");
        RelicManifest? manifest = JsonSerializer.Deserialize<RelicManifest>(jsonData);
        return manifest ?? throw new InvalidOperationException(
            "JSON deserialization of Mock API data failed. Did you load data into 'wwwroot/data/relics.json' ?");
    }
}