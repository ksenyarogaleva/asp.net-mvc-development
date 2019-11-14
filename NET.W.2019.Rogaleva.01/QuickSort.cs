using System;

namespace QuickSort
{
    /// <summary>
    /// The main<c>QuickSort</c> class.
    /// Contains methods for quick sorting algorythm that puts elements of array in order.
    /// </summary>
    public class QuickSort
    {

        /// <summary>
        /// Method <c>Main()</c> is program entry point.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] array = SetRandomArray();
            Console.WriteLine("Initial array:");
            PrintArray(array);
            QuickSortMethod(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array:");
            PrintArray(array);

            Console.ReadKey();
        }

        /// <summary>
        /// Initializes one-dimensional array of random size with random elements.
        /// </summary>
        /// <returns>Initialized one-dimension array.</returns>
        public static int[] SetRandomArray()
        {
            Random rand = new Random();
            int size = rand.Next(10, 15);
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

        /// <summary>
        /// Sorts elemenets of one-dimension array,using quick sorting algorythm.
        /// </summary>
        /// <param name="arr1">One-dimension array.</param>
        /// <param name="begin">The pointer to the left border of array./param>
        /// <param name="end">The pointer to the right border of array.</param>
        public static void QuickSortMethod(int[] arr1, int begin, int end)
        {
            int left = begin;
            int right = end;
            int middle = arr1[(left + right) / 2];

            do
            {
                while (arr1[left] < middle)
                    left++;
                while (middle < arr1[right])
                    right--;
                if (right >= left)
                {
                    SwapArrayElements(ref arr1[left], ref arr1[right]);
                    left++;
                    right--;
                }
            } while (right > left);

            if (begin < right) QuickSortMethod(arr1, begin, right);
            if (left < end) QuickSortMethod(arr1, left, end);

        }

        /// <summary>
        /// Swaps two elements of the array.
        /// </summary>
        /// <param name="i">Element of the array.</param>
        /// <param name="j">Element of the array.</param>
        public static void SwapArrayElements(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;

        }
    }
}
