using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            int reverse = 0;
            Console.WriteLine("Enter a number that is 9 digit long: ");
            string Num = Console.ReadLine();
            while (Num.Length > 9 || Num.Length < 9)
            {
                Console.WriteLine("The number you entered is not 9 digits long. Please try again! : ");
                Num = Console.ReadLine();

            }
            int Temp1 = int.Parse(Num);
            int Temp2 = Temp1;
            while (Temp1 > 0)
            {
                int remainder = Temp1 % 10;
                Temp1 = Temp1 / 10;
                reverse = reverse * 10 + remainder;
            }
            if (Temp2 == reverse)
            {
                Console.WriteLine("This is a Palindrome");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome");
            }
            Console.ReadLine();
        }

    }
}

