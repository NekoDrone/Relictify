namespace Relictify.Backend.Characters.Builder;

public interface ICharacterBuilder
{
    public void Start();
    public void SetRarity(int rarity);
    public void SetName(string Name);
    public void SetElement(CombatElement element);
    public void SetPath(CharPath path);
    public void SetStartingHp(int value);
    public void SetStartingAtk(int value);
    public void SetStartingDef(int value);
    public void SetStartingSpd(int value);
    public Character Build();
    public void Reset();
}