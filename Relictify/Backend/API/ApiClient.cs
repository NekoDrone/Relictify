using System.Text.Json;

namespace Relictify.Backend.API;

public class ApiClient : IApiClient
{
    private const string BaseUrl = "https://relictify.com/api/v1/";
    private static readonly HttpClient Client = new();

    public ApiClient()
    {
        Client.BaseAddress = new Uri(BaseUrl);
    }

    public async Task<CharacterManifest> GetCharacterManifestAsync()
    {
        string jsonString = await GetExternalResource("characters");
        CharacterManifest? manifest = JsonSerializer.Deserialize<CharacterManifest>(jsonString);
        return manifest ?? throw new InvalidOperationException(
            $"JSON deserialization of API manifest data was invalid. Check the API: {BaseUrl}/characters");

    }

    public async Task<RelicManifest> GetRelicManifestAsync()
    {
        string jsonString = await GetExternalResource("relics");
        RelicManifest? manifest = JsonSerializer.Deserialize<RelicManifest>(jsonString);
        return manifest ?? throw new InvalidOperationException(
            $"JSON deserialization of API manifest data was invalid. Check the API: {BaseUrl}/relics");
    }

    private static async Task<string> GetExternalResource(string resource)
    {
        return await Client.GetStringAsync(resource);
    }
}