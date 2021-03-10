using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MainData
{
    // insert stardrive attributes, skills, conditions, damage types, tools,

    // ATTRIBUTES
    public enum Attributes
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

    public static string Attributes_GetAttr(Attributes val)
    {
        string result = "";
        switch (val)
        {
            case Attributes.Strength:
                result = "Strength";
                break;
            case Attributes.Dexterity:
                result = "Dexterity";
                break;
            case Attributes.Constitution:
                result = "Constitution";
                break;
            case Attributes.Intelligence:
                result = "Intelligence";
                break;
            case Attributes.Wisdom:
                result = "Wisdom";
                break;
            case Attributes.Charisma:
                result = "Charisma";
                break;
        }
        return result;
    }

    // SKILLS
    public static Dictionary<string,string> Skills = new Dictionary<string, string>()
    {
        { "Astronomy", "Intelligence" },
        { "Biology", "Wisdom" },
        { "Engineering", "Intelligence" },
        { "Exert", "Strength/Dexterity" },
        { "Heal", "Intelligence" },
        { "Insight", "Wisdom" },
        { "Intimidation", "Strength/Charisma" },
        { "Investigation", "Intelligence" },
        { "Knowledge", "Intelligence" },
        { "Manipulation", "Wisdom/Charisma" },
        { "Perception", "Wisdom" },
        { "Persuasion", "Charisma" },
        { "Pilot", "Dexterity/Wisdom" },
        { "Program", "Intelligence" },
        { "Sleight of Hand", "Dexterity" },
        { "Sneak", "Dexterity" },
    };

    // CONDITIONS
    public static List<string> conditions = new List<string>()
    {
        "Blinded",
        "Charmed",
        "Deafened",
        "Frightened",
        "Grappled",
        "Incapacitated",
        "Invisible",
        "Paralyzed",
        "Petrified",
        "Poisoned",
        "Prone",
        "Restrained",
        "Stunned",
        "Unconscious",
        "Exhaustion",
    };

    // DAMAGE TYPE
    public enum DamageTypes
    {
        Slashing,
        Piercing,
        Bludgeoning,
        Force,
        Poison,
        Acid,
        Psychic,
        Heat,
        Cryonic,
        Electric,
        Concussion,
        Radiation,
        Rot
    }

    public static string DamageTypes_GetDamageType(DamageTypes val)
    {
        string result = "";

        switch (val)
        {
            case DamageTypes.Slashing:
                result = "Slashing";
                break;
            case DamageTypes.Piercing:
                result = "Piercing";
                break;
            case DamageTypes.Bludgeoning:
                result = "Bludgeoning";
                break;
            case DamageTypes.Force:
                result = "Force";
                break;
            case DamageTypes.Poison:
                result = "Poison";
                break;
            case DamageTypes.Acid:
                result = "Acid";
                break;
            case DamageTypes.Psychic:
                result = "Psychic";
                break;
            case DamageTypes.Heat:
                result = "Heat";
                break;
            case DamageTypes.Cryonic:
                result = "Cryonic";
                break;
            case DamageTypes.Electric:
                result = "Electric";
                break;
            case DamageTypes.Concussion:
                result = "Concussion";
                break;
            case DamageTypes.Radiation:
                result = "Radiation";
                break;
            case DamageTypes.Rot:
                result = "Rot";
                break;
        }
        return result;
    }

    // TOOLS
    public enum Tools
    {
        ArtisanTools,
        DisguiseKit,
        GamingSet,
        Lockpicks,
        Cryptocryptex,
        MusicalInstruments,
        AstroSurveyingEquipment,
        PlanetarySurveyingEquipment,
        DemolitionsKit,
        MetalfineKit,
        PixelKit,
        BiologicKit,
        VehicleGround,
        VehicleAir
    }

    public static string Tools_GetTools(Tools val)
    {
        string result = "";
        switch (val)
        {
            case Tools.ArtisanTools:
                result = "Artisan's Tools";
                break;
            case Tools.DisguiseKit:
                result = "Disguise Kit";
                break;
            case Tools.GamingSet:
                result = "Gaming Set";
                break;
            case Tools.Lockpicks:
                result = "Lockpicks";
                break;
            case Tools.Cryptocryptex:
                result = "Cryptocryptex";
                break;
            case Tools.MusicalInstruments:
                result = "Musical Instruments";
                break;
            case Tools.AstroSurveyingEquipment:
                result = "Astro Surveying Equipment";
                break;
            case Tools.PlanetarySurveyingEquipment:
                result = "Planetary Surveying Equipment";
                break;
            case Tools.DemolitionsKit:
                result = "Demolitions Kit";
                break;
            case Tools.MetalfineKit:
                result = "Metalfine Kit";
                break;
            case Tools.PixelKit:
                result = "Pixel Kit";
                break;
            case Tools.BiologicKit:
                result = "Biologic Kit";
                break;
            case Tools.VehicleGround:
                result = "Vehicle (Ground/Water)";
                break;
            case Tools.VehicleAir:
                result = "Vehicle (Air/Space)";
                break;
        }
        return result;
    }
}
