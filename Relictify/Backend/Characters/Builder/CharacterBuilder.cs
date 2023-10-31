using Relictify.Backend.Stats;

namespace Relictify.Backend.Characters.Builder;

public class CharacterBuilder : ICharacterBuilder
{
    private Character? _character;

    public CharacterBuilder()
    {
        this.Start();
    }

    public void Start()
    {
        this._character = new Character(0, "Empty", CombatElement.None, CharPath.None);
    }

    public void SetRarity(int rarity)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._character.Rarity = rarity;
    }

    public void SetName(string name)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._character.Name = name;
    }

    public void SetElement(CombatElement element)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._character.CombatElement = element;
    }

    public void SetPath(CharPath path)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        this._character.CharPath = path;
    }

    public void SetStartingHp(int value)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        Stat stat = new(StatType.HpFlat, value);
        this._character.BaseHp = stat;
    }

    public void SetStartingAtk(int value)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        Stat stat = new(StatType.AtkFlat, value);
        this._character.BaseHp = stat;
    }

    public void SetStartingDef(int value)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        Stat stat = new(StatType.DefFlat, value);
        this._character.BaseHp = stat;
    }

    public void SetStartingSpd(int value)
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        Stat stat = new(StatType.SpdFlat, value);
        this._character.BaseHp = stat;
    }

    public Character Build()
    {
        if (this._character is null)
            throw new InvalidOperationException(
                "Builder reference invalid. Call Reset() before calling this method");
        return this._character;
    }

    public void Reset()
    {
        this.Start();
    }
}