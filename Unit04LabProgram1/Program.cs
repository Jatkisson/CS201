using System;

namespace Unit04LabProgram1 { 
/**
 * @author James Atkisson
 * Class Program that retrieves money entered for a vending 
 * machine item until enough money is entered.*/
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declare variables to be used
            double itemCost;
            double deposit;
            double remainingBalance;

            //Get item cost from the customer.
            Console.Write("Vending machine item cost: $");
            itemCost = Convert.ToDouble(Console.ReadLine());
            remainingBalance = itemCost;

            //Get initial deposit from the customer.
            Console.Write("Please deposit money: $");
            deposit = Convert.ToDouble(Console.ReadLine());
            remainingBalance = ProcessDeposit(itemCost, deposit);

            //(while loop) Continue to prompt for and retrieve additional 
            //while more money is needed.If a negative amount of money 
            //is entered, that amount is ignored.
            while (remainingBalance > 0)
            {
                Console.WriteLine($"\n{remainingBalance:C2} still needed.");
                Console.Write("Deposit additional money: $");
                deposit = Convert.ToDouble(Console.ReadLine());
                remainingBalance = ProcessDeposit(remainingBalance, deposit);
            }

            //Tell the customer to take the item.
            Console.Write("\nPlease take your item.");
            remainingBalance = System.Math.Abs(remainingBalance);

            //If necessary, tell the customer to take their change
            if (System.Math.Abs(remainingBalance) > 0)
            {
                Console.Write($"\nPlease take your change of " +
                    $"{remainingBalance:C2}");
            }
            else { }
        }

        public static double ProcessDeposit(double cost, double dep)
        {
            double amountDue;
            if (dep > 0)
            {
                amountDue = cost - dep;
            }
            else {
                amountDue = cost;
            }
            return amountDue;
        }
    }
}