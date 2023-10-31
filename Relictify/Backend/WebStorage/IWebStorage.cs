namespace Relictify.Backend.WebStorage;

public interface IWebStorage
{
    public Dictionary<string, string> GetStorageRef();
    // Hello future dev: the reason why we aren't using Blazored.LocalStorage is because we want to keep an in-memory
    // representation of the localStorage blob, instead of writing to the blob every time a user does an update.
    // This allows us to keep a reference to the entire dictionary, and then simply save the dictionary using
    // the interop bridge after every auto-save interval.
    
    // Note: This dictionary is in the format of Dictionary<key, jsonString>, where the values of the dictionary
    // all json-serialized objects in string format. When reading and writing, you *must* serialize and deserialize<t>
    // accordingly.
    
    // the rest of these methods are wrappers for the dictionary.
    public void ClearStorage();
    public string GetItem(string keyName);
    public void RemoveItem(string keyName);
    public void SetItem(string keyName, string keyValue);
    
    // this is just another interop call to write the dictionary to the blob.
    public void WriteToStorage();
}