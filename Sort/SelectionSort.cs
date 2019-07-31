/*
elementory sort implemented just for understanding wherein after each iteration minimum value will be swapped in start, O(n^2)
 */
namespace Sort{

    using System;

    public class SelectionSort
    {
        private int[] inputArray = new Int32[]{14,33,27,10, 35,19,42,44}; //new Int32[10];
       private int minimum;
       public SelectionSort()
       {
            // Seed the input array with random numbers between 1 and 10
            // int i = 0;
            // Random rand = new Random();

            // while (i < 10)
            // {
            //     this.inputArray[i] = rand.Next(0,100);
            //     i++;
            // }

           
       }

       public void Sort()
       {
            // Print Array before sort :
            Console.WriteLine("Before Sorting:");
            foreach (var item in this.inputArray)
            {
                Console.Write( " " + item);
            }

            // naive approach using iteration
            int len = this.inputArray.Length;
            int temp;
            for (int i = 0; i <= len-1; i ++ )
            {
                minimum = i;
                for (int j = i+1; j <=len-1 ; j++)
                {
                    if(this.inputArray[minimum] > this.inputArray[j])
                    {
                        // set new minimum
                        minimum = j;

                    }
                }
                    // swap minimum to start of loop
                    if(minimum != i)
                    {
                        // that means we have found new minimum

                        temp = this.inputArray[i];
                        this.inputArray[i] = this.inputArray[minimum];
                        this.inputArray[minimum] = temp;
                    }

                   // Print Array after each iteartion :
                Console.WriteLine("\n Array after : {0} Iteration",(i+1).ToString());
                foreach (var item in this.inputArray)
                {
                    Console.Write( " " + item);
                }
            }

       }
    }
}