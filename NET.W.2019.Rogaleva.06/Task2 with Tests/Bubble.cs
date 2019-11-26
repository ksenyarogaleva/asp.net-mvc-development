using System;
using System.Linq;

namespace BubbleSort
{
    /// <summary>
    /// The main class <c>Bubble</c>
    /// Contains methods with different kinds of bubble sorting of the jagged array.
    /// </summary>
    public static class Bubble
    {
        /// <summary>
        /// Sorts jagged array in ascending order of the sum of the elements of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortAscOfRowSum(int[][] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Sum() > array[j + 1].Sum())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps 2 rows of jagged array.
        /// </summary>
        /// <param name="arr1">First row of jagged array.</param>
        /// <param name="arr2">Second row of jagged array.</param>
        public static void Swap(ref int[] arr1, ref int[] arr2)
        {
            int[] temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }

        /// <summary>
        /// Sorts jagged array in descending order of the sum of the elements of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortDecOfRowSum(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Sum() < array[j + 1].Sum())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts jagged array in ascending order of maximum element of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortAscMaxEl(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Max() > array[j + 1].Max())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts jagged array in descending order of maximum element of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortDecMaxEl(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Max() < array[j + 1].Max())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts jagged array in ascending order of minimum element of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortAscMinEl(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Min() > array[j + 1].Min())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts jagged array in descending order of minimum element of the rows.
        /// Uses bubble sorting.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        public static void BubbleSortDecMinEl(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Min() < array[j + 1].Min())
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}