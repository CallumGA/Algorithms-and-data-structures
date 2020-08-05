using System;

namespace RecursionFactorial
{
    class Program
    {
        //Left off here - study this code
        //Factorial: 7! = 7 x 6 x 5 x 4 x 3 x 2 x 1 = 5,040

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a number greater than zero : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of " + n + " is " + Factorial(n));


        }

        private static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
