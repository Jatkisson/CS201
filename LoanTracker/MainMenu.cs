using System;
using System.Collections.Generic;
using System.Text;

namespace LoanTracker
{
    class MainMenu
    {
        public static char DisplayMainMenu()
        {
            Console.WriteLine("Please select from one of the following options");
            Console.WriteLine("1 : View Loan Details");
            Console.WriteLine("2 : Edit Loan Details");
            Console.WriteLine("3 : Add another loan");
            Console.WriteLine("4 : Show payment schedule");
            Console.WriteLine("9 : EXIT");
            Console.Write("\nEnter the corresponding number for your choice: ");

            string str = Console.ReadLine();
            while (str == "")
            {
                Console.WriteLine("Selection not recognized");
                str = Console.ReadLine();
            }
                
            string answer = str.Substring(0, 1);

            char usernameEntry = Convert.ToChar(answer);

            return usernameEntry;
        }
    }
}
