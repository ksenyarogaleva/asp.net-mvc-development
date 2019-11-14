using System;

namespace MergeSort
{
    /// <summary>
    /// The main<c>MergeSort</c> class.
    /// Contains methods for merge sorting algorythm.
    /// </summary>
    public class MergeSort
    {

        /// <summary>
        /// Method <c>Main()</c> is program entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = SetRandomArray();
            Console.WriteLine("Initial array:");
            PrintArray(array);
            Console.WriteLine("Sorted array");
            PrintArray(Merge(array));

            Console.ReadKey();
        }

        /// <summary>
        /// Array merge method.
        /// Compare elements of subarrays and then merges them in right order.
        /// </summary>
        /// <param name="array">One-dimension array.</param>
        /// <param name="leftIndex">An integer that contains index of the beginning of the first subarray.</param>
        /// <param name="middleIndex">An integer that contains index of the ending of the first subarray.</param>
        /// <param name="rightIndex">An integer that contains index of the ending of the second subarray.</param>
        public static void MergeMethod(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftPointer = leftIndex;
            int rightPointer = middleIndex + 1;
            int[] tempArray = new int[rightIndex - leftIndex + 1];
            int index = 0;

            while (leftPointer <= middleIndex && rightPointer <= rightIndex)
            {
                if (array[leftPointer] < array[rightPointer])
                {
                    tempArray[index] = array[leftPointer];
                    leftPointer++;
                }
                else
                {
                    tempArray[index] = array[rightPointer];
                    rightPointer++;
                }
                index++;
            }

            for (int i = leftPointer; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = rightPointer; i <= rightIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[leftIndex + i] = tempArray[i];
            }

        }

        /// <summary>
        /// Splits initial array into subarrays.
        /// </summary>
        /// <param name="array">One-dimension array.</param>
        /// <param name="left">An integer that means the position of the first element of the current array.</param>
        /// <param name="right">An integer that means the position of the last element of the current array.</param>
        /// <returns>Sorted one-dimension array.</returns>
        public static int[] Partition(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Partition(array, left, middle);
                Partition(array, middle + 1, right);
                MergeMethod(array, left, middle, right);
            }
            return array;
        }

        /// <summary>
        /// Merge Sorting method.
        /// Calls method for splitting current array into subarrays.
        /// </summary>
        /// <param name="array">Initial one-dimension array.</param>
        /// <returns>The result of the partition of initial array into subarrays.</returns>
        public static int[] Merge(int[] array)
        {
            return Partition(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Initializes one-dimensional array of random size with random elements.
        /// </summary>
        /// <returns>Initialized one-dimension array.</returns>
        public static int[] SetRandomArray()
        {
            Random rand = new Random();
            int size = rand.Next(5, 10);
            int[] arr1 = new int[size];
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = rand.Next(-100, 100);
            return arr1;
        }

        /// <summary>
        /// Prints one-dimension array to the screen.
        /// </summary>
        /// <param name="arr1">One-dimension array.</param>
        public static void PrintArray(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + "  ");
            Console.WriteLine();
        }
    }
}
