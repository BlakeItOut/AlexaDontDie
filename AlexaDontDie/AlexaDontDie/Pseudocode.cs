using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaDontDie
{
    class Pseudocode
    {
        /*  var iventory = bool
            int energy = 7
            var hasWater = bool
            var hasFire = bool
            var hasShelter = bool

            DAY 1 

            STORYTIME - setup

            QUESTION 1 Would you like to try your luck?
            if YES,
            Go to QUESTION 2
            if NO,
            End session

            QUESTION 2 Do you want to stop and check what you have with you?            
            if YES, i = True
                tell player [inventory] - have LIGHTER, 1/2 BAG of TRAIL MIX, TARP
            if NO
            Both go to QUESTION 3

            QUESTION 3 Are you hungry enough to ignore your thirst?
            if YES, go to FOODCHOICE QUESTION 4
            if NO, go to WATERCHOICE QUESTION 5

            FOODCHOICE QUESTION 4 You see some animals nearby, do you try to hunt them?
            if NO, you eat bugs e += 1
            if YES, e -= 2
                if e >= 5, animal catch SUCCESS, e += 4
                if e < 5, animal catch FAIL
            next question

            WATERCHOICE QUESTION 5 You see a stream nearby, do you take a drink?
            if YES - water = true, energy -= 1;
            if NO - no change
            next question

            QUESTION 6 Do you want to build a shelter?
            if YES, hasShelter = TRUE
            if NO, hasShelter = FALSE sleep under tree

            WILDCARD A storm happens!
            QUESTION 4
            if water = false && i = true, Do you want to use tarp to get water?
                if YES, hasWater = true, e-=1
                if NO, hasWater = false
            if hasWater = false & hasShelter = false
                e -= 3
                you cry as the rain hits your face, you desperately try to drink some rain drops
            if hasWater = true, hasShelter = true & inventory = true
                you watch the rain safely from your shelter in comfort


            DAY 2

            QUESTION 5
            if(hasShelter == true & hasWater == true){
                "you awake next morning feeling refreshed"
                enery +
            else if (hasShelter == false & hasWater == false){
                "you are thirsty. do you look for water"? 
                if YES, energy--, hasWater = true, 
                if NO, hasWater = false 
            } else 
                "you awake feeling refreshed yet thirsty, do you look for water?"
                if YES, energy+, hasWater = true, 
                if NO, energy +, hasWater = false 

            QUESTION 6
            "you're hungry. do you look for food"?
            if YES = energy++ 
            if NO = energy--

            QUESTION 7
            if(i == true){
            "you have a lighter. do you make a fire?"
            if YES hasfire = true, energy++
            if NO energy--, hasFire = false
            }
            else{
            "you feel cold.  do you make a fire?"  
            if YES energy--, hasFire = true
            if NO energy----, hasFire = false,
            }

            QUESTION 8 
            "you hear shuffling and grunts outside, do you investigate?" 
            if YES 
                if(energy < 4)
                game over
                else{
                its a bear and you run away or something
                energy --)
            if NO nothing happens

            
            DAY 3
            QUESTION 9
            "you awake the next morning wondering if you're ever going to see civilization again."
            if(energy < 3 or hasWater = false & hasFire=false)
            {
            dead
            }
            else{
            "you hear a helicopter approaching, do you run into the clearing to signal for help?"
            if YES if(energy < 4 or not has fire)
                dead
                {
                else{ energy > 4 or hasFire)
                rescued
                }
            if NO
                dead
        */
    }
}
