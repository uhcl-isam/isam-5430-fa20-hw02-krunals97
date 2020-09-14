using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            // Enter your sentinel loop here

            Console.WriteLine("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            while (accountNumber > 0)
            {
                Console.WriteLine("Enter the balance at the begining of the month");
                int initialBalance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the total of all items charged by the customer this month");
                int totalCharges = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the total of all credits applied to the customers account this month");
                int totalCredits = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the credit limit allowed for the customers account");
                int creditLimit = int.Parse(Console.ReadLine());
                int totalBalance = initialBalance + totalCharges - totalCredits;
                Console.WriteLine($"New Account balance is :{totalBalance}");
                if (totalBalance > creditLimit)
                {
                    Console.WriteLine("Credit limit exceeded");
                    Console.WriteLine("Enter the Account number: ");
                    accountNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter the Account number: ");
                    accountNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
