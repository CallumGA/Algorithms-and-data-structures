using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAlgorithms
{
    public class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }


        
        // CREATE LINKED LIST
        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for (i = 1; i < n; i++)
            {
                Console.WriteLine("Enter element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }





        public void InsertAtBeginning(int data)
        {
            //Create node to be inserted
            Node temp = new Node(data); 
            //set the new node link to the info of first link of the existing list
            temp.link = start;
            //Change the start node to the new node
            start = temp;
        }

        public void InsertAtEnd(int data)//*Note*: this also handles the creation of the list in CreateList()
        {
            //create reference to the last node
            Node p;

            //Create temp node to be added to end of list
            Node temp = new Node(data);

            //Make sure list has a first node, if not break
            if (start == null)
            {
                start = temp;
                return;
            }
            //Set p node to the begining 
            p = start;

            while (p.link != null)
                p = p.link;
            //Set the last nodes link to the info of new node
            p.link = temp;
        }

        // TRAVERSE LINKED LIST
        public void DisplayList()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("List is: ");
            p = start;

            while (p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;
            }
        }

        // COUNT NODES LINKED LIST
        public void CountNodes()
        {
            int n = 0;//Tally for number of nodes

            Node p = start;//set p to first node

            while(p != null)
            {
                p = p.link;//iterate each node by assigning the link of the next node
                n++;//add 1 for each node iterated
            }
            Console.WriteLine("There are: " + n + " nodes.");
        }


        // SEARCH LINKED LIST
        public bool SearchLinkedList(int x)//x = node to search for
        {
            int position = 1;//position to start at in list
            Node p = start;//the start node of the list

            while (p != null)//iterate the list
            {
                if (p.info == x)//if the node currently on is x, end loop
                    break;
                position++;//add 1 for each position iterated over in list
                p = p.link;//iterate each node by assigning the link of the next node
            }

            bool ifFound = p == null ? false : true;//operator bool to see if node matches
            if(ifFound)
                Console.WriteLine("Found at position: " + position);

            return ifFound;
            }



        // INSERT VALUE AFTER NODE
        public void InsertAfter(int data, int x)
        {
            Node p = start;//first node in connected linked list

            while (p != null)//make sure node isnt null
            {
                if (p.info == x)//break loop if we are at the position user wants to insert at
                    break;
                p = p.link;//iterate to the next node if not, if found set p to the node currently on 
            }

            if (p == null)
                Console.WriteLine( x + "not present in list");//if requested location doesnt exist, let user know
            else
            {
                Node temp = new Node(data);//create the node the user is inserting
                temp.link = p.link;//set the new node link to be the before nodes previous link
                p.link = temp;//set previous node link to new node

                //*TIP*:    Think in terms of 1 44 2 3 instead of 1 2  2 3  3 null

            }
        }


        //INSERT BEFORE
        public void InsertBefore(int data, int x)
        {
            Node temp; 

            //If list is empty
            if (start == null)
            {
                Console.WriteLine("List is empty...stopping.");
                return;
            }
                
            //X is in first node, new node(temp) is to be inserted before first node
            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;

                return;
            }


            //Find reference to predecessor of node containing x
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)//go up the chain to find previous node
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(x + " not present in the list...closing");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)//make sure list is not null
                return;
            start = start.link;//make start node equal to the start nodes
                               //link(thus cutting off the first node from the chain)
        }

        public void DeleteLastNode()
        {
            if (start == null)//make sure list is not null
                return;

            if (start.link==null)//if there is only one node, delete that node
            {
                start = null;
                return;
            }

            Node p = start;//starting node
            while (p.link.link != null)//last node is already null, so we need to find the node before the last node by
                                       //checking a node ahead of the actual loop iterator(so the node we delete, is the one before the last node)
            {
                p = p.link;
            }
            //located the node before the last node and set link to null, shaving off the last node
            p.link = null;
        }



       
        //LEFT OFF HERE STUDY BELOW******



        public void DeleteNode(int x)
        {
            if (start == null)//ccheck to see if list is empty
            {
                Console.WriteLine("List is empty!");
                return;
            }

            /* Deletion of the first node */

            if (start.info==x)//if first node is the one to be deleted
            {
                start = start.link;//cut off the first node by assigning the first node to the first nodes link
                return;
            }

            /* Deletion in between or at the end */

            Node p = start; //start of the list
            while (p.link != null)//loop the entire list
            {
                if (p.link.info == x)//check if the node infront of the current one is the node to be deleted
                    break;
                p = p.link;// if not the node to be deleted continue
            }

            if (p.link == null)//got to end of list without finding node to be deleted
                Console.WriteLine("Element " + x + " is not in the list!");
            else
                p.link = p.link.link;//if we find node given by user, set the link of the current node(node before one to be deleted) 
                                     //to skip to the node after the node to be removed(breaking the link)
        }

        public void ReverseList()
        {
            Node prev, p, next;//create 3 nodes: previous, current and next
            prev = null;//set previous to null for now
            p = start;//set current node to the first node of the list

            while (p != null)
            {
                next = p.link;//assign next to the first nodes link(next node)
                p.link = prev;//assign the currrent nodes link to be the previous nodes info(reversing the link) *no previous for the first node*
                prev = p;//set previous to be the variable we are passing now
                p = next;//set the new current variable to the next variable(next number in the list)
            }

            start = prev;//change the start of the list to the end of the list, reversing the last node

            //SET THE NEXT NODES LINK TO THE PREVIOUS NODE(INFO)
            //1 -> 2 -> 3
            
            //1 <- 2 <- 3
        }

        /* Sort smallest to biggest via bubble sort */
        //p=first node, q=first node link
        public void BubbleSortExData()
        {
            Node end, p, q;

            for (end = null; end != start.link; end = p)    
            {
                for (p=start; p.link != end; p=p.link)
                {
                    q = p.link;//set first node link to first node value so we can compare 
                               // the 2 nodes 

                    if (p.info > q.info)//check if the first node is bigger than the next node
                    {
                        int temp = p.info;//create temp node of that bigger value
                        p.info = q.info;//set the first nodes value to be the second nodes value
                        q.info = temp;//set the second value to be the bigger node thus swapping the bigger for the smaller
                    }
                }

            }

        }

    }
}
