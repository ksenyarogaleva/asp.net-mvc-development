using System;
using System.Diagnostics;


namespace Tasks
{
    /// <summary>
    /// The main<c>Task2</c>
    /// Contains methods to find next bigger number of the initial number.
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Finds next bigger number for the initial number.
        /// </summary>
        /// <param name="number">Initial number.</param>
        /// <returns>Number that is next bigger to the initial number or -1 if nothing was found.</returns>
        public static int FindNextBiggerNumber(int number)
        {
            var sw = new Stopwatch();
            sw.Start();

            int counterOfChanges = 0;
            char[] array = number.ToString().ToCharArray();
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    counterOfChanges++;
                    Swap(ref array[i], ref array[i - 1]);
                    SortEndOfArray(array, i);
                    break;
                }
            }
            //System.Threading.Thread.Sleep(100);
            sw.Stop();
            Console.WriteLine($"\n//Time spent on finding next bigger number = {sw.Elapsed}//\n");

            if (counterOfChanges == 0)
                return -1;
            else
                return CharArrayToIntElement(array);
        }

        /// <summary>
        /// Rearranges two integers.
        /// </summary>
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Sorts ending part of char array in ascending order.
        /// </summary>
        /// <param name="arr">Char array.</param>
        /// <param name="position">An integer that contains index of the array from which sorting should be done.</param>
        public static void SortEndOfArray(char[] arr, int position)
        {
            for (int i = position; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);

        }

        /// <summary>
        /// Converts char array into an integer.
        /// </summary>
        /// <param name="array">Char array.</param>
        /// <returns>An integer to which char array was converted.</returns>
        public static int CharArrayToIntElement(char[] array)
        {
            int result = 0;
            int countPows = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                result += (int)char.GetNumericValue(array[i]) * (int)Math.Pow(10, countPows);
                countPows--;
            }

            return result;
        }
    }
}
