using Relictify.Backend.Relics;

namespace Relictify.Backend.WebStorage;

public interface IRelicStore
{
    public void SaveRelic(Relic relic);
    public Relic GetRelic(string identifier);
    public List<Relic> GetAllRelicsList();
}