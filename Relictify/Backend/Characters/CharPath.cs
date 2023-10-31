using System.Text.Json.Serialization;

namespace Relictify.Backend.Characters;

//Technically this is not an enum, but it's as good
//as an enum, and behaves almost like an enum.
public enum CharPath
{
    None,
    Destruction,
    Preservation,
    TheHunt,
    Erudition,
    Harmony,
    Nihility,
    Abundance,
}