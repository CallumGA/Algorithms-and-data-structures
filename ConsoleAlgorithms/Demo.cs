using System;

namespace ConsoleAlgorithms
{
    class Demo 
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("    ");
                Console.WriteLine("    ");
                Console.WriteLine("    ");

                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list or beggining of list");
                Console.WriteLine("5. Insert a node at the end of the list");
                Console.WriteLine("6. Insert a node after specified node");
                Console.WriteLine("7. Insert a node before specified node");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse linked list");
                Console.WriteLine("13. Bubble sort by exchanging data");
                Console.WriteLine("14. Bubble sort exchaging links");
                Console.WriteLine("15. Merge sort");
                Console.WriteLine("16. Insert cycle");
                Console.WriteLine("17. Detect cycle");
                Console.WriteLine("18. Remove cycle");
                Console.WriteLine("19. Quit");

                Console.Write("Please enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Display list");
                        list.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Count nodes");
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.SearchLinkedList(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter element to be inserted beginning:  ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter element to be inserted end: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.WriteLine("Enter element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter location to be inserted after: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.WriteLine("Enter element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter location to be inserted before: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 9:
                        Console.WriteLine("Deleting first node: ");
                        list.DeleteFirstNode();
                        list.DisplayList();
                        break;
                    case 10:
                        Console.WriteLine("Deleting last node: ");
                        list.DeleteLastNode();
                        list.DisplayList();
                        break;
                    case 11:
                        Console.WriteLine("Enter element to deleted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(x);
                        break;
                    case 12:
                        Console.WriteLine("Reversed list: ");
                        list.ReverseList();
                        list.DisplayList();
                        break;
                    case 13:
                        Console.WriteLine("Bubble sort smallest-biggest: ");
                        list.BubbleSortExData();
                        list.DisplayList();
                        break;
    
                }
            }
        }
    }

}
