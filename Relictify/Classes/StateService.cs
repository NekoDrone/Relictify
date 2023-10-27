using Relictify.Enums;
using Relictify.Interfaces;

namespace Relictify.Classes;

public class StateService : IStateService
{
    private Character _currentChar;
    private Page _currentPage;

    public void ChangeChar(Character newChar)
    {
        this._currentChar = newChar;
        this.RaiseStateChange();
    }

    public void ChangePage(Enums.Page newPage)
    {
        this._currentPage = newPage;
        this.RaiseStateChange();
    }

    private void RaiseStateChange()
    {
        this.OnAppStateChange?.Invoke();
    }
    
    public event Action? OnAppStateChange;

    public Character GetCurrentChar()
    {
        return this._currentChar;
    }

    public Page GetCurrentPage()
    {
        return this._currentPage;
    }
}