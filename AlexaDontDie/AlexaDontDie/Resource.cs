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
    }
}
