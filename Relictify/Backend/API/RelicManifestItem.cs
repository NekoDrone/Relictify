using System.Text.Json.Serialization;

namespace Relictify.Backend.API;

public class RelicManifestItem
{
    public string RelicName;
    public int Id;

    [JsonConstructor]
    public RelicManifestItem(string relicName, int id)
    {
        this.RelicName = relicName;
        this.Id = id;
    }
}