using Relictify.Backend.Characters;
using Relictify.Backend.Relics;

namespace Relictify.Backend.API;

public class ApiClient : IApiClient
{
    private const string BaseUrl = "https://relictify.com/api/v1/";
    private static readonly HttpClient Client = new ();

    public ApiClient()
    {
        Client.BaseAddress = new Uri(BaseUrl);
    }

    public Dictionary<string, Character> GetCharacterManifest()
    {
        throw new NotImplementedException();
    }

    public Dictionary<int, string> GetRelicManifest()
    {
        throw new NotImplementedException();
    }

    private Task<TValue> GetExternalResource<TValue>()
    {
        throw new NotImplementedException();
    }
}