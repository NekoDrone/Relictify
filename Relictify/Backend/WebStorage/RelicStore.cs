using System.Text.Json;
using Relictify.Backend.Relics;

namespace Relictify.Backend.WebStorage;

public class RelicStore : IRelicStore
{
    private readonly IWebStorage _webStore;
    private const string RelicStartingIdentifier = "Relic: ";

    public RelicStore(IWebStorage webStore)
    {
        this._webStore = webStore;
    }

    public void SaveRelic(Relic relic)
    {
        string jsonString = JsonSerializer.Serialize(relic);
        string identifier = RelicStartingIdentifier + relic.Identifier;
        this._webStore.SetItem(identifier,jsonString);
    }

    public Relic GetRelic(string identifier)
    {
        string jsonString = this._webStore.GetItem(identifier);
        Relic? relic = JsonSerializer.Deserialize<Relic>(jsonString);
        if (relic is null) throw new InvalidOperationException("Relic json conversion failed.");
        return relic;
    }

    public List<Relic> GetAllRelicsList()
    {
        Dictionary<string, string> storageRef = this._webStore.GetStorageRef();
        List<Relic> relicList = new();
        foreach (string key in storageRef.Keys)
        {
            if (!key.StartsWith(RelicStartingIdentifier)) continue;
            
            string jsonString = storageRef[key];
            Relic? listItem = JsonSerializer.Deserialize<Relic>(jsonString);
            if (listItem == null)
                throw new InvalidOperationException("Relic json conversion failed while loading all relics");
            
            relicList.Add(listItem);
        }
        // You might be tempted to convert the above to a LINQ expression,
        // but the LINQ expression is extremely complex due to the deserializer.

        return relicList;
    }
}