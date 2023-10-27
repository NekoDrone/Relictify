using Relictify.Classes;
using Relictify.Enums;

namespace Relictify.Interfaces;

public interface IStateService
{
    public void ChangeChar(Character newChar);
    public void ChangePage(Page newPage);
    public event Action OnAppStateChange;
    public Character GetCurrentChar();
    public Page GetCurrentPage();
}