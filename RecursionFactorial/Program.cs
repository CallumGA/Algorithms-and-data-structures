using System;

namespace RecursionFactorial
{
    class Program
    {
        //Left off here - study this code
        //Factorial: 7! = 7 x 6 x 5 x 4 x 3 x 2 x 1 = 5,040

        static void Main(string[] args)
        {
            int n;//n for the inputed value you want the factorial of

            Console.WriteLine("Enter a number greater than zero : ");
            n = Convert.ToInt32(Console.ReadLine());//Set the value

            Console.WriteLine("Factorial of " + n + " is " + Factorial(n));//Call method pass in value


        }

        private static long Factorial(int n)
        {
            if (n == 0)//Check to make sure input value is not 0
                return 1;
            return n * Factorial(n - 1);//Multiply value of n by n-1 passed back into the factorial method, thus multiplying
                                        //by the next number down
                                        //6 x 5 then 5 x 4 then 4 x 3...etc
        }
    }
}
