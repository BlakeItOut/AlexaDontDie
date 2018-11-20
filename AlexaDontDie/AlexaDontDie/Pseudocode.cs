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

            Choice 1 Do you stop and take inventory or keep walking? 
            if stop, i = true
                tell player - have LIGHTER, 1/2 BAG of TRAIL MIX, TARP
            if walk, e -= 1 

            Choice 2 Do you find water or find food?
            if water, e += 1, water = true
            if food water = false, go to FOODCHOICE

            FOODCHOICE Do you try to catch an animal or eat the bugs you see?
            if bugs, e+= 1
            if animal, e -= 2
                if e >= 5, animal catch SUCCESS, e += 4
                if e < 5, animal catch FAIL

            Decision 3 Do you take time to build shelter or sleep under tree?
            if shelter, hasShelter = TRUE
            if tree, hasShelter = FALSE

            WILDCARD A storm happens!

            if water = false && i = true, use tarp to get water
                water = true, e -= 1
            if hasShelter = false
                e -= 3



            DAY 2

            if(i == true){
            question1 = "the tarp you set up last night collected water" do you ____? => y = ___, n = ____
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
            if(energy < 3 or hasWater = false and not hasFire)
            {
            dead
            }
            else{
            hears helicopters
            if(energy < 4 )
            dead
            {
            else{ energy > 4 or hasFire)
            rescued
            }
        */
    }
}
