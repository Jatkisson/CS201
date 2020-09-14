using System;

/**
 * @author James Atkisson
 * Class Program that will display the season which 
 * corresponds to a user-entered month.*/
class Program
{
    static void Main(string[] args)
    {
        //Prompt the user for the month
        Console.WriteLine("Enter a numeric month and " +
            "I will display the season.");
        Console.Write("Month: ");
        int month = Convert.ToInt16(Console.ReadLine());

        //Write the corresponding season or an error message
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.Write("\nwinter");
                break;
            case 3:
            case 4:
            case 5:
                Console.Write("\nspring");
                break;
            case 6:
            case 7:
            case 8:
                Console.Write("\nsummer");
                break;
            case 9:
            case 10:
            case 11:
                Console.Write("\nfall");
                break;
            default:
                Console.Write("\nI’m sorry, an invalid month was entered.");
                break;
        }

    }
}
