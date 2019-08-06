/*
Most efficient sort with best, average and worst case time complexity as O(nlogn)
Implementation algo:
[] = MergeSort(ArrayA,i,j)   // here, MergeSort function will return sorted array.ArrayA is the input and indices i&j controls sort range of elements in array
                             // As we have to sort entire array thus i => 0 and j => length of array
     { 
         if (i == j)   // base condition check
         {
             // means only one element , just return that element or nothing
             return;
         }else
         {
             //split the array in 2 half in recursive manner by calculating mid
             mid = (i+j)/2;
             MergeSort(ArrayA,0,mid);    // returns sorted list of one half
             MergeSort(ArrayB,mid+1,j);  // returns sorted list of second half
             Merge(ArrayA,i,j,mid);      // Merge the final sorted 2 list
         }
     }

     Merge(ArrayA,i,j,mid)
     {
         ArrayB[]  // temp array to store the sorted data
         start = i;
         pos = i;  // index counter for array B
         l = i, k = mid+1   // temp variable

        // compare smallest elements 
         while(l <= mid && k <= j)
         {
             if(ArrayA[l] > ArrayA[k])
             {
                 ArrayB[pos] = ArrayA[k];
                 pos++, k++;
             }else{
                 ArrayB[pos] = ArrayA[l];
                 pos++, l++;
             }
         }
         // once one half of array is done copy all elements from other half

         // copy back the ArrayB content to ArrayA from i to j
     }


 */


namespace Sort{

using System;
using System.Collections.Generic;

    public class MergeSort
    {
        // private input array for test 
       public int[] inputArray = new Int32[]{4,9,1,3,15,39,11,21,6,9,2};
        
        public void Sort()
        {
            int len = inputArray.Length-1;
            MergeAndSort(inputArray,0,len);
        }

        // recursive function 
        public int[] MergeAndSort(int[] input,int i, int j)
        {
            // base case when we want to stop the recursion 
            if(i == j)
            {
                return input;
            }
            else{
            // split the array in 2 halves
            // calculate mid for array split in left and right part
            int mid = (i+j)/2;
            
          // Now, create recursive function to sort & merge the Left and Right Array
            MergeAndSort(input,i,mid);  
            MergeAndSort(input,mid+1,j);

            return Merge(input,i,j,mid);             


            }
            
        }

        public int[] Merge(int[] input, int i, int j, int mid)
        {
            // create arrayList for result 
            Int32[] ArrayB = new Int32[100];
            int lcounter = i;
            int rcounter = mid+1;
            int start = i;
            int pos = i;
            mid = (i+j)/2;

                while (lcounter <= mid && rcounter <= j)
                {
                    // compare left array item with right array item
                    if (input[lcounter] > input[rcounter])
                    {
                        
                        ArrayB[pos++] = input[rcounter++];
                    }
                    else
                    {
                        ArrayB[pos++] = input[lcounter++];

                    }
                }

                // Move rest of the array elements if any 
                if(lcounter > mid)
                {
                    while( rcounter <= j)
                    {
                        ArrayB[pos++] = input[rcounter++];
                    }

                }else{
                    if(rcounter > j)
                    {
                        while(lcounter <= mid)
                        {
                            ArrayB[pos++] = input[lcounter++];
                        }
                    }
                }

                // copy the contents from ArrayB to input
                for (int cnt = start; cnt <= j; cnt++)
                {
                    input[cnt] = ArrayB[cnt];

                }
                string s = "";
                foreach (var item in input)
                {
                    s = s + " " + item;
                }
                Console.WriteLine(s);
                Console.ReadLine();

             return input;
        }
    }
}