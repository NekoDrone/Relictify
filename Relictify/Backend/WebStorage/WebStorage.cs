using System.Text.Json;
using Microsoft.JSInterop;

namespace Relictify.Backend.WebStorage;

public class WebStorage : IWebStorage
{
    private const string DictIdentifier = "blob";
    private readonly IJSInProcessRuntime _jsRuntime;
    private Dictionary<string, string> _storageDict;

    public WebStorage(IJSRuntime js)
    {
        this._jsRuntime = (IJSInProcessRuntime) js;
        this.InitializeStorage();
        this._storageDict = this.InteropConstructDict();
    }

    public Dictionary<string, string> GetStorageRef()
    {
        return this._storageDict;
    }

    public void ClearStorage()
    {
        this._storageDict = new Dictionary<string, string>();
    }

    public string GetItem(string keyName)
    {
        return this._storageDict[keyName];
    }

    public void RemoveItem(string keyName)
    {
        this._storageDict.Remove(keyName);
    }

    public void SetItem(string keyName, string keyValue)
    {
        this._storageDict.Add(keyName, keyValue);
    }

    public void WriteToStorage()
    {
        string jsonString = JsonSerializer.Serialize(this._storageDict);
        this.InteropSetItem(DictIdentifier, jsonString);
    }

    private void InitializeStorage()
    {
        if (this.InteropGetValue(DictIdentifier) is not null) return;
        Dictionary<string, string> initDict = new();
        string jsonString = JsonSerializer.Serialize(initDict);
        this.InteropSetItem(DictIdentifier, jsonString);
    }

    private void InteropSetItem(string key, string value)
    {
        this._jsRuntime.InvokeVoid("localStorage.setItem", key, value);
    }

    private Dictionary<string, string> InteropConstructDict()
    {
        string identifier = DictIdentifier;
        string jsonString = this.InteropGetValue(identifier) ??
                            throw new InvalidOperationException($"localStorage {DictIdentifier} not found.");
        Dictionary<string, string>? storageDict = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
        if (storageDict is null)
            throw new InvalidOperationException($"Could not convert localStorage {DictIdentifier}.");
        return storageDict;
    }

    private string? InteropGetValue(string keyName)
    {
        return this._jsRuntime.Invoke<string>("localStorage.getItem", keyName);
    }
}