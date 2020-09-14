using System;

/**
 * @author James Atkisson
 * Class Program that displays the author's initials via the console*/

class Program
{
    static void Main(string[] args)
    {
        //Prompt the user for the first integer
        Console.Write("Please enter a positive integer: ");
        int firstInt = Convert.ToInt16(Console.ReadLine());

        //Prompt the user for the second integer
        Console.Write("Please enter another positive integer: ");
        int secondInt = Convert.ToInt16(Console.ReadLine());

        //Output of the arithmetic operations
        //Output for addition operator
        Console.WriteLine($"Sum: {firstInt + secondInt:N0}");

        //Output for multiplication operator
        Console.WriteLine($"Product: {firstInt * secondInt:N0}");

        //Output for subtraction operator
        Console.WriteLine($"Difference: {firstInt - secondInt:N0}");

        //Output for division operator 
        //Integers are initially converted to doubles for more precision 
        Console.WriteLine($"Quotient : " +
            $"{Convert.ToDouble(firstInt) / Convert.ToDouble(secondInt):F2}");

        //Output for the remainder operator
        Console.WriteLine($"Remainder: {firstInt % secondInt:N0}");
    }
}
