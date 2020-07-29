using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x;

            QueueA queue = new QueueA();

            while (true)
            {
                Console.WriteLine("1. Insert element to queue");
                Console.WriteLine("2. Remove an element from the queue");
                Console.WriteLine("3. Display the front element");
                Console.WriteLine("4. Display all queue elements");
                Console.WriteLine("5. Display the size of the queue");
                Console.WriteLine("6. Quit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        queue.Insert(x);
                        break;
                    case 2:
                        x = queue.Delete();
                        Console.WriteLine("Deleted element is:  " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at front is: " + queue.Peek());
                        break;
                    case 4:
                        queue.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of queue is: " + queue.Size());
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
