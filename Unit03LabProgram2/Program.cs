using System;

/**
 * @author James Atkisson
 * Class Program that will display the season which 
 * corresponds to a user-entered month.*/

namespace Unit03LabProgram2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Prompt the user for the month
            Console.WriteLine("Enter a numeric month and " +
                "I will display the season.");
            Console.Write("Month: ");

            int month = Convert.ToInt16(Console.ReadLine());

            ProcessInput.InputProcessor(month);

        }
    }
}