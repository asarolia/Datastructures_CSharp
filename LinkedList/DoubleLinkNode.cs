namespace LinkedList
{
    // Class structure to define the doubly link Node 
    public class DoubleLinkNode
    {
        // Data Item stored by Node
        private int nodeValue;
        // Pointer reference for next node
        private DoubleLinkNode next;
        // Pointer reference for previous node 
        private DoubleLinkNode prev;

        // Constructor function to define the default node structure
        public DoubleLinkNode(int value)
        {
            this.nodeValue = value;
            this.next = null;
            this.prev = null;
        }

        public DoubleLinkNode NEXT
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
         public DoubleLinkNode PREV
        {
           get
           {
             return this.prev;
           }
           set
           {
               this.prev = value;

           }
        }

        public int NODEVALUE
        {
            get 
            {
                return this.nodeValue;
            }
        }
      
    }

}
