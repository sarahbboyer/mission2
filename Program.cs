// See https://aka.ms/new-console-template for more information
// Sarah Boyer Mission 2

// user input to get the number of dice
using mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        //ask for user input
       Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?:  ");
       
       //use read line to store the user input, convert to int
       // this can be accessed by other classes
       int numberOfRolls = int.Parse(Console.ReadLine());
        
        // create new dice object from dice class
        // this allows for the program to access the simulaterolls method
        Dice dice = new Dice();
        
        // if i wanted to do a static class, i could have done this:
            //int[] results =  Dice.SimulateRolls(numberOfRolls)
            
        // the dice. is referencing the dice class
        int[] endresults = dice.SimulateRolls(numberOfRolls);
        
        //print results
        Console.WriteLine($"ROLLING SIMULATION RESULTS:\nEach '*' represents 1% of the total number of rolls. Total number of rolls = {numberOfRolls}");
        Console.WriteLine("Results of the dice rolls:");
        
        //looping through endresult array to collect the amount of numbers rolled and convert them to percentage
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (endresults[i] * 100) / numberOfRolls; // Calculate percentage
            
            // display the percentage as astrisk using percentage 
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
            
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}


// print number 
// calculate percentage of times each number was rolled
// print astrisk for each percent 




