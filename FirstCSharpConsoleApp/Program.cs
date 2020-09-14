using System;

/**
 * @author James Atkisson
 * Class Program that displays Welcome text on run*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C#!");

        "JCCC".Equals("jccc");

        int i = 1;

        Console.Write("Enter integer one: ");
        if (Int32.TryParse(Console.ReadLine(), out i))
            Console.WriteLine($"Converted to int: {i}");
        else
            Console.WriteLine($"Improper Integer. Value of i: {i}");
    }
}   