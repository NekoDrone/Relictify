namespace Relictify.Backend.Characters.Builder;

public interface ICharacterBuilder
{
    public void Start();
    public void SetRarity(int rarity);
    public void SetName(string name);
    public void SetElement(CombatElement element);
    public void SetPath(CharPath path);
    public void SetStartingHp(double value);
    public void SetStartingAtk(double value);
    public void SetStartingDef(double value);
    public void SetStartingSpd(double value);
    public Character Build();
    public void Reset();
}