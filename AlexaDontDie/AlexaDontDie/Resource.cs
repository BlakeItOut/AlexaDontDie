using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaDontDie
{
    public class Resource
    {
        public string Language { get; set; } = "en-US";
        public string SkillName { get; set; } = "Don't Die";
        public string LaunchMessage { get; set; } = "Welcome to Don't Die where you try not to die.<audio src='soundbank://soundlibrary/animals/amzn_sfx_bear_roar_grumble_01'/>";
        public string LaunchMessageReprompt { get; set; } = "Say yes or no";
        public string AskMessage { get; set; } = "Yes or no?";
        public string HelpMessage { get; set; } = "Just say yes or no. Say help to hear the prompt again. You can say exit at any time to exit.";
        public string HelpReprompt { get; set; } = "Yes, no, help, or exit.";
        public string StopMessage { get; set; } = "Safe adventures!";
        public Dictionary<string, object> Stats { get; set; } = new Dictionary<string, object>()
        {
            { "Question", 1}, //start after intro
            { "Inventory", false},
            { "HasWater", false },
            { "HasFire", false },
            { "HasShelter", false },
            { "Energy", 7 }
        };

        public string Introduction { get; set; } = "ENTER INTRO TEXT HERE";

        public Dictionary<int, string> Questions { get; set; } = new Dictionary<int, string>
        {
            { 1,"Would you like to try your luck?" }, //INTRO
            { 2,"Do you want to stop and check what you have with you?" },
            { 3,"Are you hungry enough to ignore your thirst?" },
            { 4,"You see some animals nearby, do you try to hunt them?" }, //FOODCHOICE
            { 5,"You see a stream nearby, do you take a drink?" }, //WATERCHOICE
            { 6,"Do you want to build a shelter?" },
            { 7,"STORM.  Do you want to use tarp to get water?" }, //CHECK LOGIC HERE -STORM
            { 8,"You awake feeling refreshed yet thirsty, do you look for water?" },
            { 9,"You're hungry. Do you look for food?" },
            { 10,"You have a lighter. Do you make a fire?" },
            { 11,"You feel cold.  Do you make a fire?" },
            { 12,"You hear shuffling and grunts outside, do you investigate?" },
            { 13,"You awake the next morning wondering if you're ever going to see civilization again." },
            { 14,"You hear a helicopter approaching, do you run into the clearing to signal for help?" }
        };

        public Dictionary<string, string> Statements { get; set; } = new Dictionary<string, string>()
        {
            { "inventory", "You have a LIGHTER, a 1/2 BAG of TRAIL MIX, and a TARP" },
            { "noWaterOrShelter", "You cry as the rain hits your face, you desperately try to drink some rain drops" },
            { "yesWaterShelterAndInventory", "You watch the rain safely from your shelter in comfort" },
            { "yesWaterShelter", "You awake next morning feeling refreshed" },
        };
    }
}
