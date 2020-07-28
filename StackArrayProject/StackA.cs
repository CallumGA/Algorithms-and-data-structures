using System;
using System.Collections.Generic;
using System.Text;

namespace StackArrayProject
{
    class StackA
    {
        private int[] stackArray;
        private int top;

        public StackA()
        {
            stackArray = new int[10];
            top = -1;   
        }

        public StackA(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        //Return size of stack
        public int Size()
        {
            return top + 1;//Return top + 1 which is the size of the stack
        }

        //Check if stack is empty
        public bool IsEmpty()
        {
            return (top == -1);//Return bool depending on if the top = -1. if it does empty return true
        }

        //Check if the stack is full
        public bool IsFull()
        {
            return (top == stackArray.Length-1);//Get the length of the array -1 and compare, return true
        }

        //Add a new element to the top of the stack
        public void Push(int x)//x = user input
        {
            if (IsFull())//Check make sur not full
            {
                Console.WriteLine("Stack overflow!");
                return;
            }

            top = top + 1;//Add 1 to account for new element and top value
            stackArray[top] = x;//Set the new top to be that of the added element, thus adding a value
        }

        //Takes off the top element and deletes
        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow!");
            }

            x = stackArray[top];//Assign the top to be x
            top = top - 1;//Set new top to subtract 1, thus eliminating the top element

            return x;//Return the new 1 smaller array
        }

        //Retruns top most element without removing
        public int Peek()
        {
            if(IsEmpty())
                Console.WriteLine("Stack underflow!");
            return stackArray[top];//Just return the top stack element
        }


        public void Display()
        {
            if (IsEmpty())//Make sure not empty
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("Stack is: ");
            for (int i = top;   i >= 0; i--)//Loop down the stack with i-- starting with top element
            {
                Console.WriteLine(stackArray[i] + " ");//Display
            }

            Console.WriteLine();
        }
    }
}
