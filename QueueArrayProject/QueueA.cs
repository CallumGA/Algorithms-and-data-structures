using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayProject
{
    class QueueA
    {
        private int[] queueArray;//Array int holding the queue
        private int front;//Marks the front value in queue
        private int rear;//Marks the end of the queue

        public QueueA()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueA(int maxSize)  
        {
            queueArray = new int[maxSize];
            front = -1;//Were items in queue come out of
            rear = -1;//Were you insert values
        }

        public bool IsEmpty()
        {
            return (front == -1 || front==rear + 1);//If front has no value or front value is same as rear plus 1
        }

        public bool IsFull()
        {
            return (rear == queueArray.Length - 1);//If rear is equal to length of the queue
        }

        public int Size()
        {
            if (IsEmpty())//Check if empty
                return 0;
            else
                return rear - front + 1;//Rear = second last value
                                        //Front is 0 if queue isnt null
                                        //3 - 0 + 1 if queue is 1 2 3 4
        }

        public void Insert(int x)//x is value provided by user
        {
            if (IsFull())//Make sure array queue isnt maxed out (10 in this case)
            {
                Console.WriteLine("Queue overflow!");
                return;
            }
                
            if (front == -1)//If queue has value, it will be 0. If null then equal to -1
                front = 0;//If queue is null, set front to 0 to signify queue has value now
            rear = rear + 1;//Add 1 value to rear to account for new inserted value
            queueArray[rear] = x;//Set new value at rear position(were value is inserted in queue) to the inserted value(x)
        }

        public int Delete()
        {
            int x;//Represents the front value to be removed from queue
            if (IsEmpty())//Make sure queue array isnt null
                Console.WriteLine(" Queue underflow!");
            x = queueArray[front];//Set value to be removed(x) as the queue arrays front most value(were values are pushed out of queue)
            front = front + 1;//Actually delete the front value from queue by adding one to
                              //the front

            return x;//return the value of the deleted element(position 0 in this case)
        }

        public int Peek()
        {
            if (IsEmpty())
                Console.WriteLine(" Queue underflow!");
            return queueArray[front];//Peek the front value by returning the value of front position
        }

        public void Display()
        {
            if (IsEmpty())//Make sure not empty
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine("Queue is : \n\n");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queueArray[i] + " ");//Loop through array queue with iteration(i)
            }

            Console.WriteLine();

        }

    }
}