using System;
using System.Security.Cryptography;

namespace Unit04LabProgram2 { 
/**
 * @author James Atkisson
 * Class Program that authenticates a user. If the user enters
 * the correct login and password combination in 3 or less attempts,
 * they are allowed to login. Otherwise, a login disabled message is shown.*/
    public class Program
    {
        public static void Main(string[] args)
        {
            const string USERNAME = "jccc";
            const string PASSWORD = "cavs";
            const int MAX_LOGIN_ATTEMPTS = 3;
            string usernameEntry;
            string passwordEntry;
            bool usernameMatch;
            bool passwordMatch;
            int loginAttempts = 1;

            //Prompt for and retrieve the first attempt 
            //at a correct username and password.
            Console.Write("Username: ");
            usernameEntry = Console.ReadLine();

            Console.Write("Password: ");
            passwordEntry = Console.ReadLine();

            usernameMatch = String.Equals(USERNAME, usernameEntry.ToLower());
            passwordMatch = String.Equals(PASSWORD, passwordEntry.ToLower());

            //while loop with a compound loop condition that evaluates to 
            //true while the ((user entered username or password are 
            //incorrect) and(there are more login attempts)) remaining.
            //The username is not case sensitive, but the password is.
            while ((usernameMatch == false || passwordMatch == false) 
                && loginAttempts < MAX_LOGIN_ATTEMPTS)
            {
                Console.WriteLine("Login incorrect. Please re-enter your " +
                    "username and password.");

                //Prompt for and retrieve the first attempt 
                //at a correct username and password.
                Console.Write("Username: ");
                usernameEntry = Console.ReadLine();

                Console.Write("Password: ");
                passwordEntry = Console.ReadLine();

                usernameMatch = String.Equals(USERNAME, 
                    usernameEntry.ToLower());
                passwordMatch = String.Equals(PASSWORD, 
                    passwordEntry.ToLower());
                loginAttempts++;
            }

            //Display "Logging in..." if the login was successful. 
            //Else, the program will display Login disabled.
            //Please contact your administrator
            if (usernameMatch == true || passwordMatch == true)
            {
                Console.Write("Logging in...");
            } else
            {
                Console.Write("Login disabled. " +
                    "Please contact your administrator.");
            }
        }
    }
}