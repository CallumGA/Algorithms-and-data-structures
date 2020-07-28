using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedList
{
    class StackL
    {
        private Node top;//Top of the stack node

        public StackL()
        {
            top = null;//Set to null for now as stack is empty
        }


        public int Size()
        {
            int s = 0;//Empty var for the size integer
            Node p = top;//The top node of the linked list stack

            while (p!=null)
            {
                p = p.link;//Iterate the nodes(set node container to be the link of current node thus moving to the next node)
                s++;//Add 1 for each node iterated
            }
            return s;//Return the size integer just iterated
        }


        public void Push(int x)//x = user inputted value
        {
            Node temp = new Node(x);//Create a new node via node class with the entered value
            temp.link = top;//Set the link of new node to the node value of the top of the stack
            top = temp;//Reset the top marker to the new node
        }


        public int Pop()
        {
            int x;//Empty variable for the top value that will be removed
            if (IsEmpty())//Verify not empty
                Console.WriteLine("Stack underflow!");
            x = top.info;//Set x as the top values info 
            top = top.link;//Set the new top(first value) to the next node via the 1st nodes link
                           //therefore shaving off the first(top) value

            return x;//Return the value of the popped node
        }


        public int Peek()
        {
            if (IsEmpty())//Make sure linked list stack is not null
                Console.WriteLine("Stack underflow!");
            return top.info;//Return the first node on the top of the stack via the top marker nodes info
        }


        private bool IsEmpty()
        {
            return (top==null);//Return true if there is no first top value in the stack, if there is then return true
        }

        public void Display()
        {
            Node p = top;//Get the first node in the top of the stack

            if (IsEmpty())
            {
                Console.WriteLine("Stack empty!");//Verify not empty
                return;
            }

            Console.WriteLine("Stack is: ");
            while (p != null)//Loop while there are node in iteration
            {
                Console.WriteLine(p.info + " ");//Display current iterated nodes info(node value)
                p = p.link;//Iterate the next node by setting p(current node in loop) to that nodes link(thus the next node info)
            }

            Console.WriteLine();

        }
    }
}
