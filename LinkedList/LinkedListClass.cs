using System;

namespace LinkedList
{
    public class LinkedListClass
    {
        // variable to hold the node structure ( data and reference)
        private LinkNode newNode;
        // variable to hold the head
        private LinkNode head;
        // variable to hold the tail
        private LinkNode tail;
        // variable to hold the length of the linked list
        private int nodeLength;

        // constructor function 
        public LinkedListClass(int value)
        {
            // create default node structure for value
            this.newNode = new LinkNode(value);
            // point head to this first node
            this.head = this.newNode;
            // point tail to this first node head
            this.tail = this.newNode;
            // Set length to 1 as its first node
            nodeLength = 1;
        }

        // Display function for Linked list Data => time complexity O(n)
        public void PrintAllNodes()
        {
            // set the variable on the linked list head
            LinkNode currentNode = this.head;
            // Now loop through all the elements till end of linked list 
            while (currentNode != null)
            {
                Console.Write("Node Value : {0} ---> ",currentNode.NODEVALUE);
                currentNode = currentNode.NEXT;
            //    Console.ReadLine(); 

            }
            Console.WriteLine("Total nodes :{0}",this.nodeLength);
        }

        // Function to append node to linked list : in end => time complexity O(1)
        public void AppendNode(int value)
        {
            // 1. Create the default Node structure for new value
            this.newNode = new LinkNode(value);
            // 2. Set & move tail to new node
            this.tail.NEXT = this.newNode;
            this.tail = this.newNode;
            nodeLength++;

        }

        // Function to prepend node to linked list : in start  => time complexity O(1)

        public void PrePend(int value)
        {
            // 1. Create the default Node structure for new value
            this.newNode = new LinkNode(value);
            // 2. Set & move head to new node
            this.newNode.NEXT = this.head;
            this.head = this.newNode;
            nodeLength++;


        }

        // Function to insert node in linked list = > time complexity O (n)
        public void Insert(int index,int value)
        {
            
            // 1. Check if index is 0, that means we want to make this new node as new head 
            if (index == 0)
            {
                PrePend(value);

            } else
            {
                // 2. Loop through the list till index position for insert
                LinkNode temp = this.head;
                int counter = 1;
                while (temp != null)
                {
                    if (counter < index)
                    {
                       temp = temp.NEXT;
                       counter++;
                    }
                    else
                    {
                        // position found
                       this.newNode = new LinkNode(value);
                       LinkNode successor = temp.NEXT;
                       this.newNode.NEXT = successor;
                       temp.NEXT = this.newNode;
                       this.nodeLength++;
                       break;

                    }
                }

            }
           

        }

       // Function to remove node in linked list = > time complexity O (n)
       public void Remove(int value)
		{
			LinkNode temp = this.head;
			LinkNode pred = this.head;
			LinkNode succ = this.head.NEXT;
			// LinkNode succ;
			if(this.head.NODEVALUE == value)
			{
				this.head = succ;
				this.nodeLength--;
			}
			else
			{
				while (temp != null)
				{
					if (temp.NODEVALUE == value)
					{
						pred.NEXT = temp.NEXT;
						this.nodeLength--;
						break;
					}
					else
					{
						pred = temp;
						temp = temp.NEXT;
						// succ = temp.NEXT;
					}

				}
			}

			
		}

        // function to reverse the linked list : O(n)
		public void ReverseList()
		{
			LinkNode current = this.head;
			LinkNode previous = null;
			LinkNode next = this.head;

			while (current != null)
			{
				next = current.NEXT;
				current.NEXT = previous;
				previous = current;
				current = next;
			}

			this.head = previous;

		}


      
    }

    // Class structure to define the Node 
    public class LinkNode
    {
        // Data Item stored by Node
        private int nodeValue;
        // Pointer reference for next node
        private LinkNode next;
        // Constructor function to define the default node structure
        public LinkNode(int value)
        {
            this.nodeValue = value;
            this.next = null;
        }

        public LinkNode NEXT
        {
           get
           {
             return this.next;
           }
           set
           {
               this.next = value;

           }
        }

        public int NODEVALUE
        {
            get 
            {
                return this.nodeValue;
            }
        }
        // public void SetNextValue(LinkNode newValue)
        // {
        //     this.next = newValue;
        // }
        // public LinkNode GetNextValue()
        // {
        //     return this.next;
        // }
        // public int GetNodeValue()
        // {
        //     return this.nodeValue;
        // }
    }
}
