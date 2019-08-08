namespace Sort
{

	using System;

	public class QuickSort
	{
		// private input array for test 
		public int[] inputArray = new Int32[] { 4, 9, 1, 3, 15, 39, 11, 21, 6, 2 };
		//new Int32[] { 10, 80, 30, 90, 40, 50, 70 }; 
		//new Int32[] { 4, 9, 1, 3, 15, 39, 11, 21, 6, 9, 2 };

		public int pivot;
		public int partitionIndex;

		public void Sort()
		{
			
			InitiateQuickSort(inputArray, 0, inputArray.Length - 1);
			//Print sorted array 
            string s = "";
			foreach (var item in inputArray)
			{
				s = s + " " + item;
			}
			Console.WriteLine(s);

		}

		private void InitiateQuickSort(int[] inputArray, int i, int j)
		{
			

			// Base condition 
			if (i >= j)
			{
				return;
			}
			else
			{

			
				// Get the next partition index using current pivot
				partitionIndex = partition(inputArray, i, j);
				InitiateQuickSort(inputArray, i, partitionIndex - 1);
				InitiateQuickSort(inputArray, partitionIndex + 1, j);


			}

		}

		private int partition(int[] inputArray, int i, int j)
		{
			int right = j - 1;
			int left = i;
			int pivot = inputArray[j];
			int temp;
			int pos = i-1;

			// loop through elements 

			while (left <= right)
			{
				if (inputArray[left] > pivot)
				{
					left++;
				}
				else
				{
					//if (pos < left)
				//	{
						// means not first element and current element is less than pivot, lets swap with last min
						pos++;
						temp = inputArray[left];
						inputArray[left] = inputArray[pos];
						inputArray[pos] = temp;
						
					
			//		}
					left++;
				}

			}

			string s = "";
			foreach (var item in inputArray)
			{
				s = s + " " + item;
			}
			Console.WriteLine("Before pivot swap array: "+ s);

			// post this we have all elements in sorted format except pivot , thus swap pivot element
			temp = inputArray[j];
			inputArray[j] = inputArray[pos+1];
			inputArray[pos+1] = temp;

			Console.WriteLine("Pivot after swap :" + inputArray[pos+1]);

			// string s = "";
			// foreach (var item in inputArray)
			// {
			// 	s = s + " " + item;
			// }
			// Console.WriteLine(s);



			return (pos+1);
		}
	}
}