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
            LoanProfile Loan = new LoanProfile();

            //Prompt for and receive the loan information
            int loanPrincipal = LoanProfile.RequestLoanPrincipal();
            int loanInterestRate = LoanProfile.RequestInterestRate();
            int loanMonthlyPayment = LoanProfile.RequestMonthlyPayment();

            Loan.SetLoanDetails(loanPrincipal, loanInterestRate,
                loanMonthlyPayment);

            Loan.CalculateLoanDetails();
        }

        
    }

}
