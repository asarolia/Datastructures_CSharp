/*
Elementory sort implemented just for understanding where max element in each iteration is bubbled up to end, O(n^2)
 */
using System;

namespace Sort
{
    public class BubbleSort
    {
        private int[] inputArray = new Int32[]{14,33,27,35,10}; //new Int32[10];

        public BubbleSort()
        {
            // Seed the input array with random numbers between 1 and 10
            // int i = 0;
            // Random rand = new Random();

            // while (i < 10)
            // {
            //     this.inputArray[i] = rand.Next(0,11);
            //     i++;
            // }
            

            
        }

        // method to sort the input array 
        public void SortAscending()
        {
            // Print Array before sort :
            Console.WriteLine("Before Sorting:");
            foreach (var item in this.inputArray)
            {
                Console.Write( " " + item);
            }
            // naive solution with iterative appraoch 
            int len = this.inputArray.Length;
            int temp;
            for (int i =0; i <= len-1; i++ )
            {               
                for (int j = 1; j<=len-1-i; j++)
                {
                    
                    if( this.inputArray[j-1] > this.inputArray[j])
                    {
                        // swap them 
                        temp = this.inputArray[j];
                        this.inputArray[j] = this.inputArray[j-1];
                        this.inputArray[j-1] = temp;
                    } 
                    

                }

                    // Print Array after each iteartion :
                Console.WriteLine("\n Array after : {0} Iteration",(i+1).ToString());
                foreach (var item in this.inputArray)
                {
                    Console.Write( " " + item);
                }
            }

            // Print Array after sort :
            Console.WriteLine("\n After Sorting:");
            foreach (var item in this.inputArray)
            {
                Console.Write( " " + item);
            }

        }
     

    }
}
