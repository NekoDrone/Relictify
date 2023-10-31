using Relictify.Backend.Characters;

namespace Relictify.StateManagement;

public interface IStateService
{
    public void ChangeEntry(CharacterEntry newEntry);
    public void ChangePage(Page newPage);
    public event Action OnAppStateChange;
    public CharacterEntry GetCurrentEntry();
    public Page GetCurrentPage();
}