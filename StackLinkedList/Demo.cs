using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {

            int choice, x;

            StackL stack = new StackL();

            while (true)
            {
                Console.WriteLine("1. Push element onto stack");
                Console.WriteLine("2. Pop an element off stack");
                Console.WriteLine("3. Display the top element");
                Console.WriteLine("4. Display all stack elements");
                Console.WriteLine("5. Display stack size");
                Console.WriteLine("6. Quit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element to be pushed: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        stack.Push(x);
                        break;
                    case 2:
                        x =stack.Pop();
                        Console.WriteLine("Popped element is:  " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the top is:  " + stack.Peek());
                        break;
                    case 4:
                        stack.Display();
                        break;
                    case 5:
                        Console.WriteLine("Sixe of stack is:  " + stack.Size());
                        break;
                    case 6:
                        Console.WriteLine("Wrong choice!");
                        break;
                }               
                Console.WriteLine("");

            }
        }
    }
}
