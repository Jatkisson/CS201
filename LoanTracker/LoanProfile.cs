using System;
using System.Collections.Generic;
using System.Text;

namespace LoanTracker
{
    class LoanProfile
    {
        private int principal;
        private int interestRate;
        private int monthlyPayment;

        public void CalculateLoanDetails()
        {
            int tempPrincipal = principal;

            Console.WriteLine($"{GetPrincipal()} {GetInterestRate()}");
        }

        public static int RequestLoanPrincipal()
        {
            Console.Write("Please enter your loan's principal amount: ");
            int loanPrincipal = Convert.ToInt16(Console.ReadLine());

            return loanPrincipal;
        }

        public static int RequestInterestRate()
        {
            Console.Write("Please enter your loan's interest rate: ");
            int loanIR = Convert.ToInt16(Console.ReadLine());

            return loanIR;
        }

        public static int RequestMonthlyPayment()
        {
            Console.Write("Please enter your loan's monthly payment: ");
            int loanMP = Convert.ToInt16(Console.ReadLine());

            return loanMP;
        }

        public void SetLoanDetails(int loanP, int loanIR, int loanMP)
        {
            principal = loanP;
            interestRate = loanIR;
            monthlyPayment = loanMP;
        }

        public int GetPrincipal()
        {
            return principal;
        }

        public int GetInterestRate()
        {
            return interestRate;
        }

        public int GetMonthlyPayment()
        {
            return monthlyPayment;
        }
    }
}
