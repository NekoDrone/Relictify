using System.Text.Json;
using Relictify.Backend.Characters;

namespace Relictify.Backend.WebStorage;

public class EntryStore : IEntryStore
{
    private const string EntryStartingIdentifier = "Entry: ";
    private readonly IWebStorage _webStore;

    public EntryStore(IWebStorage webStore)
    {
        this._webStore = webStore;
    }

    public void SaveEntry(CharacterEntry entry)
    {
        string jsonString = JsonSerializer.Serialize(entry);
        string identifier = EntryStartingIdentifier + entry.Character.Name;
        this._webStore.SetItem(identifier, jsonString);
    }

    public CharacterEntry GetEntry(string identifier)
    {
        string jsonString = this._webStore.GetItem(identifier);
        CharacterEntry? entry = JsonSerializer.Deserialize<CharacterEntry>(jsonString);
        if (entry is null) throw new InvalidOperationException("Entry json conversion failed.");
        return entry;
    }

    public List<CharacterEntry> GetAllEntriesList()
    {
        Dictionary<string, string> storageRef = this._webStore.GetStorageRef();
        List<CharacterEntry> relicList = new();
        foreach (string key in storageRef.Keys)
        {
            if (!key.StartsWith(EntryStartingIdentifier)) continue;
            string jsonString = storageRef[key];
            CharacterEntry? listItem = JsonSerializer.Deserialize<CharacterEntry>(jsonString);
            if (listItem == null)
                throw new InvalidOperationException("Entry json conversion failed while loading all entries");
            relicList.Add(listItem);
        }

        return relicList;
    }
}