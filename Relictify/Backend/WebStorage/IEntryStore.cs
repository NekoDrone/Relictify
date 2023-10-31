using Relictify.Backend.Characters;

namespace Relictify.Backend.WebStorage;

public interface IEntryStore
{
    public void SaveEntry(CharacterEntry entry);
    public CharacterEntry GetEntry(string identifier);
    public List<CharacterEntry> GetAllEntriesList();
}