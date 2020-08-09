using System;
using System.Transactions;

namespace SumOfDigitsRecursion
{
    /* Get the sum of a numbers digits via recursion */

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(n));

        }

        private static int SumDigits(int n)
        {
            if (n / 10 == 0)
                return n;
            return SumDigits(n / 10) + n % 10;
        }
    }
}
