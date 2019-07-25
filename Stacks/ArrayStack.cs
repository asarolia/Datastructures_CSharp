namespace Stacks
{
    using System;

    public class ArrayStack
    {
        private int[] nodeArray;
        private int[] newnodeArray;

        private int index;

        public ArrayStack(int value)
        {
            nodeArray = new Int32[value];
            index = 0;
            
        }

        public void push(int value)
        {
            this.nodeArray[index] = value;
            index++;
        }

        public void pop()
        {
            this.nodeArray[index] = default(int);

        }

    }

}