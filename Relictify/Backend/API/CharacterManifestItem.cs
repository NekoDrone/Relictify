using Relictify.Backend.Characters;
using Relictify.Backend.Stats;

namespace Relictify.Backend.API;

public class CharacterManifestItem
{
    public string Name;
    public int Rarity;
    public CharPath Path;
    public CombatElement Element;
    public double StartingHp;
    public double StartingAtk;
    public double StartingDef;
    public double StartingSpd;
}