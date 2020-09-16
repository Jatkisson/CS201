using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LoanTracker
{
    public class UserProfile
    {
        private string userName;
        private string firstName;
        private string lastName;

        public static string RequestUsernameEntry()
        {
            Console.Write("Please enter your username: ");
            string usernameEntry = Console.ReadLine();

            return usernameEntry;
        }

        public static void GreetUser(UserProfile GreetUserName)
        {
            Console.Write($"Hello {GreetUserName.GetFirstName()} ");
            Console.WriteLine($"{GreetUserName.GetLastName()}!");
            Console.WriteLine($"Your username, {GreetUserName.GetUserName()}" +
                $", was recognized as valid!");
        }

        public void SetName(string uName)
        {
            switch (uName) {
                case "jatkisson":
                    firstName = "James";
                    lastName = "Atkisson";
                    userName = uName;
                    break;
                default:
                    Console.WriteLine("This Username was not found.");
                    userName = "None Found";
                    break;
            }
            
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetUserName()
        {
            return userName;
        }
    }
}
