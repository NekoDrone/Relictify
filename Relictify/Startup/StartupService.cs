using Relictify.Backend.API;

namespace Relictify.Startup;

public class StartupService : IStartupService
{
    private IApiClient ApiClient;
    private CharacterManifest _characterManifest;
    private RelicManifest _relicManifest;

    public StartupService()
    {
        this.ApiClient = new ApiClient();
        this._characterManifest = this.ApiClient.GetCharacterManifestAsync().Result;
        this._relicManifest = this.ApiClient.GetRelicManifestAsync().Result;

    }
    
    public CharacterManifest GetCharacterManifest()
    {
        return this._characterManifest;
    }

    public RelicManifest GetRelicManifest()
    {
        return this._relicManifest;
    }

    public CharacterManifestItem GetCharacterFromManifest(string name)
    {
        return this._characterManifest.Manifest.Find(item => item.Name == name) ??
               throw new NullReferenceException($"A character by the name of '{name}' could not be found.");
    }

    public RelicManifestItem GetRelicFromManifest(int id)
    {
        return this._relicManifest.Manifest.Find(item => item.TypeId == id) ??
               throw new NullReferenceException($"A relic set with ID '{id}' could not be found.");
    }
}