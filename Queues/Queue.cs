/*
 Queues works in FIFO ( First in first out) manner and thus can be implemented efficiently with LinkedLi

 Thus, we will implement Queues using LinkedList as ADT ( Abstract Data Type). Supported operation for stacks :
   => enqueue - add element to Queue , O(1)
   => dequeue  - remove first added element from queue , O(1)
   => peek - remove first added element from queue i.e. head, O(1)
   => lookup - searches for element in Queue, O (n) 

 */

using System;

namespace Queues
{
    public class Queue
    {
        QueueNode item;
        QueueNode first;
        QueueNode last;

        int queueLength;

        public Queue(int value)
        {
            this.item = new QueueNode(value);
            this.first = this.item;
            this.last = this.item;
            this.queueLength = 1;
            
        }

        public void Enqueue(int value)
        {
            this.item = new QueueNode(value);
            this.last.NEXT = this.item;
            this.last = this.item;
            this.queueLength++;
        }

        public void Dequeue()
        {
            this.first = this.first.NEXT;
            this.queueLength--;
        }

        public void peek()
        {
            Console.WriteLine("Current First in Queue:"+this.first.NODEVALUE);
        }

        public void Print()
        {
            QueueNode temp  = this.first;
            while(temp != null)
            {
                Console.Write(temp.NODEVALUE+"<--");
                temp = temp.NEXT;
                
            }
        }

    }

      internal class QueueNode
    {
      private int nodeValue;
      private QueueNode next;

      public QueueNode(int value)
      {
        this.nodeValue = value;
        this.next = null;
          
      }
      public QueueNode NEXT
      {
        get{
          return this.next;
        }
        set {
          this.next = value;
        }

      }
      public int NODEVALUE{
        get{
          return this.nodeValue;
        }
        set 
        {
          this.nodeValue = value;
        }
      }
    }
}
