using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainData;

public static class SpeciesBackgroundsData
{
    // species, backgrounds

    // SPECIES
    public enum Species
    {
        Human,
        Casellian,
        Orack,
        Trino,
        Parian,
        Envo,
        Android
    }

    public static string Species_GetName(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "Human";
                break;
            case Species.Casellian:
                result = "Casellian";
                break;
            case Species.Orack:
                result = "Orack";
                break;
            case Species.Trino:
                result = "Trino";
                break;
            case Species.Parian:
                result = "Parian";
                break;
            case Species.Envo:
                result = "Envo";
                break;
            case Species.Android:
                result = "Android";
                break;
        }
        return result;
    }

    public static string Species_GetAge(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "Humans reach adulthood in their late teens and live between 100 and 125 years.";
                break;
            case Species.Casellian:
                result = "Casellian reach adulthood in their early 100s and live between 400 and 600 years.";
                break;
            case Species.Orack:
                result = "Oracks reach adulthood in their mid 50s and live between 200 and 300 years.";
                break;
            case Species.Trino:
                result = "Trino reach adulthood in their late teens and live between 150 and 175 years.";
                break;
            case Species.Parian:
                result = "Parians reach adulthood in their late teens and live between 125 and 150 years.";
                break;
            case Species.Envo:
                result = "Envos reach adulthood in their late teens and live between 100 and 125 years.";
                break;
            case Species.Android:
                result = "Androids are created as adults, and “live” for 15 years, after which they deteriorate and either go rampant or cease to function.";
                break;
        }
        return result;
    }

    public static string Species_GetAlignment(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "Humans tend toward no particular alignment. The best and the worst are found among them.";
                break;
            case Species.Casellian:
                result = "Casellian are biased towards good, but have a range of alignments similar to humans. Most younger Casellian are chaotic, " +
                    "with middle aged Casellian being neutral, and adult Casellian being lawful.";
                break;
            case Species.Orack:
                result = "Oracks are biased towards chaotic, as they tend to be mercenaries, but have a range of alignments similar to humans.";
                break;
            case Species.Trino:
                result = "Trino are biased towards neutral alignments, though the balance between good and evil is fairly gray. There are rarely " +
                    "chaotic or lawful Trino, though similar to humans, they have a range of alignments. Most younger Trino are neutral, " +
                    "and get progressively more good or evil as they age.";
                break;
            case Species.Parian:
                result = "Parians tend toward no particular alignment. The best and the worst are found among them.";
                break;
            case Species.Envo:
                result = "Envos are biased towards neutral , but have a range of alignments similar to humans.";
                break;
            case Species.Android:
                result = "Androids are only set to follow their given programming, thus giving them the alignments of their creators.";
                break;
        }
        return result;
    }

    public static string Species_GetSize(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "Humans vary widely in height and build, from barely 1.5 m to well over 2 m tall. Regardless of your position " +
                    "in that range, your size is Medium.";
                break;
            case Species.Casellian:
                result = "Casellian vary widely in height and build, from 1.7 m to well over 2 m tall. They resemble female humans, always with " +
                    "a purple-ish skin tone, with protrusions from their head. Regardless of your position in that range, your size is Medium.";
                break;
            case Species.Orack:
                result = "Oracks are generally large in size, being well over 2 m tall regardless of gender or position. They resemble large " +
                    "rhinoceros-like crocodiles, with a yellowish, orangish skin tone. Regardless of your height and weight, your size is Medium.";
                break;
            case Species.Trino:
                result = "Trino vary in height, from 1.8 m to well over 2 m tall. They resemble skinny, tall amphibious humanoids with frog heads, " +
                    "with a brownish tone. Regardless of your position in that range, your size is Medium.";
                break;
            case Species.Parian:
                result = "Parians vary widely in height and build, from 1.7 m to well over 2 m tall. They resemble humanoid reptilians, with varying " +
                    "skin tones from white to black. Regardless of your position in that range, your size is Medium.";
                break;
            case Species.Envo:
                result = "Envos vary widely in height and build, from 1.7 m to well over 2 m tall. They resemble humans, though no one has actually " +
                    "seen what they actually look like under their biosuits. Their size is Medium.";
                break;
            case Species.Android:
                result = "Androids vary widely in height and build, from 1.7 m to well over 2 m tall. They resemble humans. Regardless of your position " +
                    "in that range, your size is Medium.";
                break;
        }
        return result;
    }

    public static string Species_GetSpeed(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Casellian:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Orack:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Trino:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Parian:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Envo:
                result = "Your base walking speed is 30 m.";
                break;
            case Species.Android:
                result = "Your base walking speed is 30 m.";
                break;
        }
        return result;
    }

    public static string Species_GetFeature(Species val)
    {
        string result = "";
        switch (val)
        {
            case Species.Human:
                result = "When earning your first exhaustion point, you may roll a Physical Saving Throw (DC = 10). " +
                    "On a fail, you earn an exhaustion point as normal. On a pass, you forgo that exhaustion point, " +
                    "but earn 2 on your next exhaustion point increase (thus skipping 1 level of exhaustion and going straight to 2).";
                break;
            case Species.Casellian:
                result = "You can have 2-way telepathic communications with sentient living creatures within 60 ft. " +
                    "You may not read their minds, and they will be alerted to your voice in their mind. They do not " +
                    "recognize a location unless you tell them.";
                break;
            case Species.Orack:
                result = "Your ranges for thrown items/weapons is doubled.";
                break;
            case Species.Trino:
                result = "For a long rest, you only need 4 hours, rather than the full 8.";
                break;
            case Species.Parian:
                result = "See twice as far as human can and have advantage on Perception skill checks related to seeing details.";
                break;
            case Species.Envo:
                result = "You can repair things in half the time it would normally require, though all other components are the same cost.";
                break;
            case Species.Android:
                result = "You may still use Nanoabilities but may not pick the Starborn class. You function identically to " +
                    "a Human character, with some caveats: 1) Any skill used to notice that you are not human or that you " +
                    "were designed to emulate suffers disadvantage on that roll. 2) You do not need to eat or drink, and " +
                    "your android body does not go unconscious when you rest for the night (though you must still rest to " +
                    "recharge). 3) You are resistant to slashing damage but are vulnerable to electric damage.You are immune to " +
                    "poison but can be hacked(DC = 8 + PROF + INT). 4) To be healed, you must use your Engineering skill, not Healing skill.";
                break;
        }
        return result;
    }

    // BACKGROUNDS
    public enum Backgrounds
    {
        Academic,
        Artist,
        Clergy,
        CombatVeteran,
        Courtesan,
        Dilettante,
        Investigator,
        Lowlife,
        Merchant,
        OnePercenter,
        Outlaw,
        Physician,
        Pilot,
        SoftwareSecurityTechnician,
        Technician,
        Thug,
        Wildperson
    }

    public static string Backgrounds_GetName(Backgrounds val)
    {
        string result = "";
        switch (val)
        {
            case Backgrounds.Academic:
                result = "Academic";
                break;
        }
        return result;
    }

    public static string Backgrounds_GetSkills(Backgrounds val)
    {
        string result = "";
        // MainData.Skills.Keys[]
        return result;
    }

    public static string Backgrounds_GetTools(Backgrounds val)
    {
        string result = "";
        return result;
    }

    public static string Backgrounds_GetFeature(Backgrounds val)
    {
        string result = "";
        return result;
    }
}
