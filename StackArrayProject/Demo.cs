using System;

namespace StackArrayProject
{
    class Demo
    {
        static void Main(string[] args)
        {

            int choice, x;

            StackA stack1 = new StackA(8);

            while (true)
            {
                Console.WriteLine("1. Add element on the stack");
                Console.WriteLine("2. Remove an element from the stack");
                Console.WriteLine("3. Display the top element");
                Console.WriteLine("4. Display all stack elements");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Quit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element to add: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        stack1.Push(x);
                        break;
                    case 2:
                        x = stack1.Pop();
                        Console.WriteLine("Popped element is:  " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at top is: " + stack1.Peek());
                        break;
                    case 4:
                        stack1.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of stack is: " + stack1.Size());
                        break;
                    default:
                        Console.WriteLine("Choice not in list");
                        break;
                }
                Console.WriteLine("");

            }

        }
    }
}
