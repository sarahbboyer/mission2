namespace mission2;
using System.Collections.Generic;
using System;


// to make a constructor, you use the same name as the class
//for (initialization; condition; iteration)

// this is the second class for the dice rolling. the user input needs to be passed here
    internal class Dice
    {
        // collect result from first die roll combined with the second die roll
        // the int[] is what the function will be returning, void is if it is not returning anything
        public int[] SimulateRolls(int numberOfRolls)
        {
            //create array to store roll results
            int[] results = new int[13];
            
            //create random intance
            Random random = new Random();
            
            //loop to loop through the rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                //roll dice one and two (get a random number)
                int randomNumber = random.Next(1, 7);
                int randomNumber2 = random.Next(1, 7);
                
                //add the rolls bc we only care about the result
                int result = randomNumber2 + randomNumber;
                
                //add to the array
                results[result]++;
            }
            
            //return the array
            return results;
        }
    }