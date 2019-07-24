namespace LinkedList
{
    using System;

    public class DoublyLinkedList
    {
         // variable to hold the node structure ( data and reference)
        private DoubleLinkNode newNode;
        // variable to hold the head
        private DoubleLinkNode head;
        // variable to hold the tail
        private DoubleLinkNode tail;
        // variable to hold the length of the linked list
        private int nodeLength;

        // constructor function 
        public DoublyLinkedList(int value)
        {
            // create default node structure for value
            this.newNode = new DoubleLinkNode(value);
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
            DoubleLinkNode currentNode = this.head;
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
            this.newNode = new DoubleLinkNode(value);
            // 2. Set & move tail to new node
            this.tail.NEXT = this.newNode;
            this.newNode.PREV = this.tail;
            this.tail = this.newNode;
            nodeLength++;

        }

        // Function to prepend node to linked list : in start  => time complexity O(1)

        public void PrePend(int value)
        {
            // 1. Create the default Node structure for new value
            this.newNode = new DoubleLinkNode(value);
            // 2. Set & move head to new node
            this.newNode.NEXT = this.head;
            this.head.PREV = this.newNode;
            this.head = this.newNode;
            nodeLength++;


        }

        // Function to insert node in linked list = > time complexity O (n)
		public void Insert(int index, int value)
		{

			// 1. Check if index is 0, that means we want to make this new node as new head 
			if (index == 1)
			{
				PrePend(value);

			}
			else
			{
				// 2. Loop through the list till index position for insert
				DoubleLinkNode temp = this.head;
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
						this.newNode = new DoubleLinkNode(value);
						DoubleLinkNode pred = temp.PREV;
						temp.PREV = this.newNode;
						this.newNode.PREV = pred;
						pred.NEXT = this.newNode;
						this.newNode.NEXT = temp;
						this.nodeLength++;
						break;

					}
				}

			}


		}
        public void Remove(int value)
        {
            DoubleLinkNode temp = this.head;
            DoubleLinkNode pred;
            DoubleLinkNode succ;

            if(this.head.NODEVALUE == value)
            {
                succ = this.head.NEXT;
                succ.PREV = null;
                this.head = succ;
                this.nodeLength--;


            }else
            {
                if(this.tail.NODEVALUE == value)
                {
                    pred = this.tail.PREV;
                    pred.NEXT = null;
                    this.tail = pred;
                    this.nodeLength--;

                }else
                {
                    while (temp != null)
                    {
                        if(temp.NODEVALUE == value)
                        {
                            pred = temp.PREV;
                            succ = temp.NEXT;
                            pred.NEXT = succ;
                            succ.PREV = pred;
                            this.nodeLength--;
                            break;
                        }else
                        {
                            pred = temp;
                            temp = temp.NEXT;
                        // succ = temp.NEXT;
                        }

                     }

                }
                

            }
            
        }
    } 

}