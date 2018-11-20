using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaDontDie
{
    class Pseudocode
    {
        /*  var iventory = bool
            var energy = int
            energy = 7
            var hasWater = bool
            var hasFire = bool
            var hasShelter = bool

            DAY 1 

            STORYTIME - setup

            Choice 1 Do you want to stop and check what you have with you?
            
            if stop, i = true
                tell player - have LIGHTER, 1/2 BAG of TRAIL MIX, TARP
            if walk, e -= 1 

            Choice 2 Are you hungry enough to ignore your thirst?
            if water, water = true go to WATERCHOICE
            if food, water = false, go to FOODCHOICE

            WATERCHOICE
            You see a stream nearby, do you take a drink?
            
            yes - water = true,
            energy -= 1;
            
            no - nothing

            FOODCHOICE You see some animals nearby, do you try to hunt them?
            if no, you eat bugs e += 1
            if yes, e -= 2
                if e >= 5, animal catch SUCCESS, e += 4
                if e < 5, animal catch FAIL

            Decision 3 Do you want to build a shelter?
            if shelter, hasShelter = TRUE
            if tree, hasShelter = FALSE

            WILDCARD A storm happens!

            do you try and gather water from the storm?

            if water = false && i = true, use tarp to get water
                water = true, e -= 1
            if hasShelter = false
                e -= 3



            DAY 2

            if(i == true){
            question1 = "you awake next morning feeling refreshed"
            else{
            question1 = "you are thirsty. do you look for water"? => y = energy-- hasWater = true, n = hasWater = false 
            }

            question2 = "you're hungry. do you look for food"? => y = energy++ n = energy--

            if(i == true){
            question3 = "you have a lighter. do you make a fire?" => y has fire = true = energy++, n = energy-- hasFire = false
            }
            else{
            question3 = "do you make a fire?" => y = energy-- hasFire = true, n = energy---- hasFire = false,
            }

            question4 = "you hear shuffling and grunts outside, do you investigate?" 
            y=(
            if(energy < 4)
            game over
            else{
            its a bear and you run away or something
            energy --)
            n = nothing happens

            
            DAY 3
            "you awake the next morning wondering if you're ever going to see civilization again."
            if(energy < 3 or hasWater = false and not hasFire)
            {
            dead
            }
            else{
            hears helicopters
            question: do you run into the clearing to signal for help?
            if(energy < 4 or not has fire)
            dead
            {
            else{ energy > 4 or hasFire)
            rescued
            }
        */
    }
}
