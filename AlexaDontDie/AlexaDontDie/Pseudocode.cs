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
            Both go to QUESTION 6

            WATERCHOICE QUESTION 5 You see a stream nearby, do you take a drink?
            if YES - water = true, energy -= 1;
            if NO - no change
            Both go to QUESTION 6

            QUESTION 6 Do you want to build a shelter?
            if YES, hasShelter = TRUE
            if NO, hasShelter = FALSE sleep under tree
            Both go to:
                WILDCARD A storm happens!
                if hasWater == true 
                    if hasShelter == true
                        if i == true
                            you watch the rain safely from your shelter in comfort
                            "you awake next morning feeling refreshed"
                            Go to QUESTION 10
                        else
                            "you awake next morning feeling refreshed"
                            Go to QUESTION 10
                    else
                        if i == true
                            "you sleep under a tree"
                            Go to QUESTION 10
                        else
                            "you sleep under a tree"
                            Go to QUESTION 10
                else
                    if hasShelter == true
                        if i == true
                            Go to QUESTION 7
                        else
                            e -= 3
                            []you cry as the rain hits your face, you desperately try to drink some rain drops
                            Go to QUESTION 9
                            
                    else
                        if i == true
                            Go to QUESTION 7
                        else
                            e -= 3
                            []you cry as the rain hits your face, you desperately try to drink some rain drops
                            Go to QUESTION 8
                
            QUESTION 7
            Do you want to use tarp to get water?
                    if YES, hasWater = true, e-=1
                        Go to QUESTION 9
                    if NO, hasWater = false
                        if hasShelter == true 
                            Go to QUESTION 9
                        else 
                            Go to QUESTION 8
            DAY 2

            QUESTION 8
            "you are thirsty. do you look for water"? 
                if YES, energy--, hasWater = true, 
                if NO, hasWater = false
            Both go to QUESTION 10

            QUESTION 9
            "you awake feeling refreshed yet thirsty, do you look for water?"
                if YES, energy+, hasWater = true, 
                if NO, energy +, hasWater = false 

            QUESTION 10
            "you're hungry. do you look for food"?
            if YES = energy++ 
            if NO = energy--                       
                if(i == true){
                    Go to QUESTION 11
                }
                else{
                    Go to QUESTION 12
                }
            
            QUESTION 11
            "you have a lighter. do you make a fire?"
                if YES hasfire = true, energy++
                if NO energy--, hasFire = false
                Both go to QUESTION 13

            QUESTION 12
            "you feel cold.  do you make a fire?"  
                if YES energy--, hasFire = true
                if NO energy----, hasFire = false,
                Both go to QUESTION 13

            QUESTION 13 
            "you hear shuffling and grunts outside, do you investigate?" 
                if YES 
                    if(energy < 4)
                    game over
                    else{
                    its a bear and you run away or something
                    energy --)
                if NO nothing happens
                Both go to:
                    "you awake the next morning wondering if you're ever going to see civilization again."
                    if(energy < 3 or hasWater = false & hasFire=false)
                        dead
                    else
                        Go to QUESTION 14

            
            
            DAY 3
            
            
            QUESTION 14
            "you hear a helicopter approaching, do you run into the clearing to signal for help?"
                if YES 
                    if energy < 4 or not has fire
                        dead
                    else energy > 4 or hasFire
                        rescued
                if NO
                    dead
        */
    }
}
