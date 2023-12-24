using Relictify.Backend.Characters;
using Relictify.Backend.WebStorage;

namespace Relictify.StateManagement;

public class StateService : IStateService
{
    private IEntryStore _entryStore;
    private IWebStorage _webStorage;
    private IRelicStore _relicStore;
    private CharacterEntry _currentEntry;
    private Page _currentPage;

    public StateService(IEntryStore entryStore, IWebStorage webStorage, IRelicStore relicStore)
    {
        this._entryStore = entryStore;
        this._webStorage = webStorage;
        this._relicStore = relicStore;
        this._currentPage = Page.Details;
        this.InitializeStateService();
        this._currentEntry = this._entryStore.GetEntry("Entry: Trailblazer - Destruction");
        // TODO: Replace with better empty entry. 
    }

    private void InitializeStateService()
    {
        // on very first load (aka a new user), initialize the app with empty entry.
        // TODO: Only do this if there is no existing data in localstorage.
        Character destructionTb =
            new Character(5, "Trailblazer - Destruction", CombatElement.Physical, CharPath.Destruction);
        CharacterEntry firstEntry = new CharacterEntry(destructionTb);
        this._entryStore.SaveEntry(firstEntry);
    }
    public void ChangeEntry(CharacterEntry newEntry)
    {
        this._currentEntry = newEntry;
        this.RaiseStateChange();
    }

    public void ChangePage(Page newPage)
    {
        this._currentPage = newPage;
        this.RaiseStateChange();
    }

    private void RaiseStateChange()
    {
        this.OnAppStateChange?.Invoke();
    }

    public event Action? OnAppStateChange;

    public CharacterEntry GetCurrentEntry()
    {
        return this._currentEntry;
    }

    public Page GetCurrentPage()
    {
        return this._currentPage;
    }
}