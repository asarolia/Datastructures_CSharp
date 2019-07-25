/*
 Stacks works in LIFO ( Last in first out) manner and thus can be implemented with LinkedList as well as Arrays.
 Arrays : Pro - can utilize memory cache because of contiguous memory Cons - limited in terms of resizing
 LinkedList : Pro - can be easily resized Cons - not really as such

 Thus, we will implement Stack using LinkedList as ADT ( Abstract Data Type). Supported operation for stacks :
   => push - add element to top of stack , O(1)
   => pop  - remove top element from stack , O(1)
   => peek - reads top element from stack, O(1)
   => lookup - searches for element in stack, O (n) 

 */
using System;

namespace Stacks
{
    public class LinkedStack
    {
      private StackNode newitem;
      private StackNode head;
      private StackNode tail;
      private int stackLength;

      public LinkedStack(int value)
      {
        this.newitem = new StackNode(value);
        this.head = this.newitem;
        this.tail = this.newitem;
        stackLength = 1;     
      }

    // method to push the element on the stack 
      public void push(int value)
      {
        // internally it should work in append fashion for linked List, adding new item on head
        this.newitem = new StackNode(value);
        this.newitem.NEXT = this.head;
        this.head = this.newitem;
        this.stackLength ++;

      }

      public void pop()
      {
        // internally it should just remove the latest head value from top
        this.head = this.head.NEXT;
       // Console.WriteLine("Current head is :"+this.head.NODEVALUE);
        this.stackLength --;

      }

      public void peek()
      {
        // it should return the top element
        Console.WriteLine("Peek Result :"+this.head.NODEVALUE);
      }

   
      public void print()
      {
        StackNode temp = this.head;
        while(temp != null)
        {
          Console.WriteLine(temp.NODEVALUE);
          temp = temp.NEXT;
        }
      }

    }

    internal class StackNode
    {
      private int nodeValue;
      private StackNode next;

      public StackNode(int value)
      {
        this.nodeValue = value;
        this.next = null;
          
      }
      public StackNode NEXT
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
