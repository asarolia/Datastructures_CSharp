namespace Sort{
    using System;

    public class InsertionSort
    {
          private int[] inputArray = new Int32[]{3, 7, 4, 9, 5, 2, 6, 1}; //new Int32[10]; //{3, 7, 4, 9, 5, 2, 6, 1}// {14,33,27,10, 35,19,42,44}
       public InsertionSort()
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
            for (int i = 1; i <= len-1; i ++ )
            {
                // compare the latest element with last fetched 
                if(this.inputArray[i-1] > this.inputArray[i])
                {
                    // swap latest fetched data towards sorted list
                    temp = this.inputArray[i];
                    this.inputArray[i] = this.inputArray[i-1];
                    this.inputArray[i-1] = temp;


                }
                    // Finds the insertion position in sorted list for latest fetched element
                    for (int k = i-1 ; k >= 0; k--)
                    {
                        if((this.inputArray[k+1] < this.inputArray[k]))
                        {
                            // swap again
                            temp = this.inputArray[k+1];
                            this.inputArray[k+1] = this.inputArray[k];
                            this.inputArray[k] = temp;
                        }

                    }

                   // Print Array after each iteartion :
                Console.WriteLine("\n Array after : {0} Iteration",(i).ToString());
                foreach (var item in this.inputArray)
                {
                    Console.Write( " " + item);
                }
            }

       }
    }
}