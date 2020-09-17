using System;

namespace LoanTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new User object
            UserProfile User = new UserProfile();

            //Prompt for and receive the username
            string usernameEntry = UserProfile.RequestUsernameEntry();

            User.SetName(usernameEntry);

            while (User.GetUserName() == "None Found") {
                usernameEntry = UserProfile.RequestUsernameEntry();
                User.SetName(usernameEntry);
            }

            UserProfile.GreetUser(User);

            //Create new Loan object
            int loanCount = 0;

            LoanProfile[] Loan = new LoanProfile[10];

            for (int i = 0; i < Loan.Length; i++)
            {
                Loan[i] = new LoanProfile();
            }

            //Prompt for and receive the loan information
            int loanPrincipal = LoanProfile.RequestLoanPrincipal();
            int loanInterestRate = LoanProfile.RequestInterestRate();
            int loanMonthlyPayment = LoanProfile.RequestMonthlyPayment();

            Loan[loanCount].SetLoanDetails(loanPrincipal, loanInterestRate,
                loanMonthlyPayment);
            Loan[loanCount].GetPrincipal();
            Loan[loanCount].GetInterestRate();
            Loan[loanCount].GetMonthlyPayment();

            char menuSelection = 'x';

            while (menuSelection != '9')
            {
                menuSelection = MainMenu.DisplayMainMenu();
                switch (menuSelection)
                {
                    case '1':
                        for (int i = 0; i < loanCount + 1; i++)
                        {
                            Console.Write("Principal: ");
                            Console.WriteLine($"{Loan[i].GetPrincipal()}");
                            Console.Write("Interest Rate: ");
                            Console.WriteLine($"{Loan[i].GetInterestRate()}");
                            Console.Write("Monthly Payment: ");
                            Console.WriteLine($"{Loan[i].GetMonthlyPayment()}");
                        }
                        break;
                    case '2':
                        Console.WriteLine("Case 2 selected.");
                        break;
                    case '3':
                        //Prompt for and receive the loan information
                        loanPrincipal = LoanProfile.RequestLoanPrincipal();
                        loanInterestRate = LoanProfile.RequestInterestRate();
                        loanMonthlyPayment = LoanProfile.RequestMonthlyPayment();

                        loanCount++;
                        Loan[loanCount].SetLoanDetails(loanPrincipal, loanInterestRate,
                loanMonthlyPayment);
                        Loan[loanCount].GetPrincipal();
                        Loan[loanCount].GetInterestRate();
                        Loan[loanCount].GetMonthlyPayment();
                        break;
                    case '4':
                        Console.WriteLine("case 4 selected\n");
                        break;
                    case '9':
                        Console.WriteLine("Exiting application");
                        break;
                    default:
                        Console.WriteLine("Selection not recognized");
                        break;
                }
            }
        }

        
    }

}
