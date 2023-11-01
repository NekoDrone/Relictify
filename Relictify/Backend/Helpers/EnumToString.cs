using Relictify.Backend.Characters;
using Relictify.Backend.Relics;
using Relictify.Backend.Stats;

namespace Relictify.Backend.Helpers;

public static class EnumToString
{
    public static string ConvertStatType(StatType statType)
    {
        string result = statType switch
        {
            StatType.None => "",
            StatType.HpFlat => "HP",
            StatType.HpPercent => "HP",
            StatType.AtkFlat => "ATK",
            StatType.AtkPercent => "ATK",
            StatType.DefFlat => "DEF",
            StatType.DefPercent => "DEF",
            StatType.SpdFlat => "SPD",
            StatType.SpdPercent => "SPD",
            StatType.CritRate => "CRIT Rate",
            StatType.CritDmg => "CRIT DMG",
            StatType.EHR => "Effect Hit Rate",
            StatType.EffectRes => "Effect RES",
            StatType.BreakEffect => "Break Effect",
            StatType.OutgoingHealing => "Outgoing Healing Boost",
            StatType.ERR => "Energy Regeneration Rate",
            StatType.ElementalDamage => "Elemental Damage Boost",
            _ => throw new ArgumentOutOfRangeException(nameof(statType), statType,
                "Stat Type not recognised for conversion into string")
        };
        return result;
    }

    public static string ConvertCharPath(CharPath charPath)
    {
        string result = charPath switch
        {
            CharPath.None => "",
            CharPath.Destruction => "Destruction",
            CharPath.Preservation => "Preservation",
            CharPath.TheHunt => "The Hunt",
            CharPath.Erudition => "Erudition",
            CharPath.Harmony => "Harmony",
            CharPath.Nihility => "Nihility",
            CharPath.Abundance => "Abundance",
            _ => throw new ArgumentOutOfRangeException(nameof(charPath), charPath,
                "Character Path not recognised for conversion into string")
        };
        return result;
    }

    public static string ConvertRelicSet(RelicSet relicSet)
    {
        string result = relicSet switch
        {
            RelicSet.None => "",
            RelicSet.CavernBandOfSizzlingThunder => "Band of Sizzling Thunder",
            RelicSet.CavernChampionOfStreetwiseBoxing => "Champion of Streetwise Boxing",
            RelicSet.CavernEagleOfTwilightLine => "Eagle of Twilight Line",
            RelicSet.CavernFiresmithOfLavaForging => "Firesmith of Lava Forging",
            RelicSet.CavernGeniusOfBrilliantStars => "Genius of Brilliant Stars",
            RelicSet.CavernGuardOfWutheringSnow => "Guard of Wuthering Snow",
            RelicSet.CavernHunterOfGlacialForest => "Hunter of Glacial Forest",
            RelicSet.CavernKnightOfPurityPalace => "Knight of Purity Palace",
            RelicSet.CavernMusketeerOfWildWheat => "Musketeer of Wild Wheat",
            RelicSet.CavernPasserbyOfWanderingCloud => "Passerby of Wandering Cloud",
            RelicSet.CavernThiefOfShootingMeteor => "Thief of Shooting Meteor",
            RelicSet.CavernWastelanderOfBanditryDesert => "Wastelander of Banditry Desert",
            RelicSet.PlanarBelobogOfTheArchitects => "Belobog of the Architects",
            RelicSet.PlanarCelestialDifferentiator => "Celestial Differentiator",
            RelicSet.PlanarFleetOfTheAgeless => "Fleet of the Ageless",
            RelicSet.PlanarInertSalsotto => "Inert Salsotto",
            RelicSet.PlanarPanCosmicCommercialEnterprise => "Pan-Cosmic Commercial Enterprise",
            RelicSet.PlanarSpaceSealingStation => "Space Sealing Station",
            RelicSet.PlanarSprightlyVonwacq => "Sprightly Vonwacq",
            RelicSet.PlanarTaliaKingdomOfBanditry => "Talia: Kingdom of Banditry",
            RelicSet.CavernLongevousDisciple => "Longevous Disciple",
            RelicSet.CavernMessengerTraversingHackerspace => "Messenger Traversing Hackerspace",
            RelicSet.PlanarRutilantArena => "Rutilant Arena",
            RelicSet.PlanarBrokenKeel => "Broken Keel",
            _ => throw new ArgumentOutOfRangeException(nameof(relicSet), relicSet, 
                "Relic set not recognised for conversion into string")
        };
        return result;
    }

    public static string ConvertRelicType(RelicType relicType)
    {
        string result = relicType switch
        {
            RelicType.Head => "Head",
            RelicType.Hands => "Hands",
            RelicType.Body => "Body",
            RelicType.Feet => "Feet",
            RelicType.Sphere => "Planar Sphere",
            RelicType.Rope => "Link Rope",
            RelicType.Blank => "",
            _ => throw new ArgumentOutOfRangeException(nameof(relicType), relicType, 
                "Relic type not recognised for conversion into string")
        };
        return result;
    }
}