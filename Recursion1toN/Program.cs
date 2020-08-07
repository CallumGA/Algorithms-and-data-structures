using System;

namespace Recursion1toN
{
    class Program
    {
        public static void Print1(int n)//Number user inputted
        {
            if (n == 0)//Make sure not 0
                return;
            Console.Write(n + " ");//Print the number
            Print1(n-1);//Subtract 1 from the previous number and run it through Print1 again(thus counting down)
        }

        public static void Print2(int n)//
        {
            if (n == 0)//Make sure not null
                return;    
            Print2(n - 1);//This call runs through first(runs Print2 as many times as the size of the number) with no printing, move on when reached the base case
            Console.Write(n + " ");//Go back up the stack and print the numbers in reverse(when we get to this method we have gotten to base case)
                                   //This is why when we start printing, it starts at 1 and counts up
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Print1(n);
            Console.WriteLine();

            Print2(n);
            Console.WriteLine();
        }
    }
}
