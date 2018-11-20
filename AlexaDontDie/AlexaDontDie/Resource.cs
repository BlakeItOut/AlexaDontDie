using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaDontDie
{
    public class Resource
    {
        public string Language { get; set; } = "en-US";
        public string SkillName { get; set; } = "Don't Die";
        public string LaunchMessage { get; set; } = "Welcome to Don't Die where you try not to die.<audio src='soundbank://soundlibrary/animals/amzn_sfx_bear_roar_grumble_01'/> Would you like to try your luck?";
        public string LaunchMessageReprompt { get; set; } = "Say yes or no";
        public string AskMessage { get; set; } = "Yes or no?";
        public string HelpMessage { get; set; } = "Just say yes or no. Say help to hear the prompt again. You can say exit at any time to exit.";
        public string HelpReprompt { get; set; } = "Yes, no, help, or exit.";
        public string StopMessage { get; set; } = "Safe adventures!";
        public Dictionary<string, object> Stats { get; set; } = new Dictionary<string, object>()
        {
            { "Question", 1},
            { "Inventory", false},
            { "HasWater", false },
            { "HasFire", false },
            { "HasShelter", false },
            { "Energy", 7 }
        };

        public string Introduction { get; set; } = "ENTER INTRO TEXT HERE";

        public string[] Questions { get; set; } = 
        {
            "Do you want to stop and check what you have with you?",
            "Are you hungry enough to ignore your thirst?",
            "You see some animals nearby, do you try to hunt them?", //FOODCHOICE
            "You see a stream nearby, do you take a drink?", //WATERCHOICE
            "Do you want to build a shelter?",
            "STORM.  Do you want to use tarp to get water?", //CHECK LOGIC HERE -STORM
            "You awake feeling refreshed yet thirsty, do you look for water?",
            "you're hungry. do you look for food?",
            "you have a lighter. do you make a fire?",
            "you feel cold.  do you make a fire?",
            "you hear shuffling and grunts outside, do you investigate?",
            "you awake the next morning wondering if you're ever going to see civilization again.",
            "you hear a helicopter approaching, do you run into the clearing to signal for help?",
        };

        public Dictionary<string, string> Statements { get; set; } = new Dictionary<string, string>()
        {
            { "inventory", "You have a LIGHTER, a 1/2 BAG of TRAIL MIX, and a TARP" },
            { "noWaterOrShelter", "you cry as the rain hits your face, you desperately try to drink some rain drops" },
            { "yesWaterShelterAndInventory", "you watch the rain safely from your shelter in comfort" },
            { "yesWaterShelter", "you awake next morning feeling refreshed" },
        };
    }
}
