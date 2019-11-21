using System;
using System.Diagnostics;
using System.Linq;

namespace GreatCommonDivisor
{
    /// <summary>
    /// The main <c>GCD</c> class.
    /// Computes the greatest common divisor of integers with the use of Euclidean and Stein's algorythms.
    /// </summary>
    public class GCD
    {
        /// <summary>
        /// Computes the greatest common divisor for more than two integers using Euclidean algorythm.
        /// </summary>
        /// <param name="numbers">Integers which greatest common divisor should be found.</param>
        /// <returns>The greatest common divisor.</returns>
        public static int EuclideanAlgorythm(params int[] numbers)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            if (numbers.Length == 0)
                return 0;
            int divisor = Math.Abs(numbers[0]);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                divisor = EuclideanAlgorythm(divisor, Math.Abs(numbers[i + 1]));
            }
            sw1.Stop();
            return divisor;
        }

        /// <summary>
        /// Computes the greatest common divisor for two integers using Euclidean algorythm.
        /// </summary>
        /// <param name="num1">First integer.</param>
        /// <param name="num2">Second integer.</param>
        /// <returns>The greatest common divisor.</returns>
        public static int EuclideanAlgorythm(int num1, int num2)
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            if (num1 == 0)
                num1 = num2;
            if (num2 == 0)
                num2 = num1;
            if (num1 == 1 || num2 == 1)
                return 1;
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            sw2.Stop();
            return num1;

        }
        /// <summary>
        /// Computes the greatest common divisor for more than two integers using Stein's algorythm.
        /// </summary>
        /// <param name="numbers">Integers which greatest common divisor should be found.</param>
        /// <returns>The greatest common divisor.</returns>
        public static int SteinAlgorythm(params int[] numbers)
        {
            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            if (numbers.Length == 0)
                return 0;
            int divisor = Math.Abs(numbers[0]);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                divisor = SteinAlgorythm(divisor, Math.Abs(numbers[i + 1]));
            }
            sw3.Stop();
            return divisor;
        }

        /// <summary>
        /// Computes the greatest common divisor for two integers using Stein's algorythm.
        /// </summary>
        /// <param name="num1">First integer.</param>
        /// <param name="num2">Second integer.</param>
        /// <returns>The greatest common divisor.</returns>
        public static int SteinAlgorythm(int num1, int num2)
        {
            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            if (num1 == 0)
                return num2;
            if (num2 == 0)
                return num1;
            if (num1 == 1 || num2 == 1)
                return 1;
            if ((num1 & 1) == 0)
            {
                sw4.Stop();
                return ((num2 & 1) == 0)
                   ? SteinAlgorythm(num1 >> 1, num2 >> 2) << 1
                   : SteinAlgorythm(num1 >> 1, num2);
            }
            else
            {
                sw4.Stop();
                return ((num2 & 1) == 0)
                    ? SteinAlgorythm(num1, num2 >> 1)
                    : SteinAlgorythm(num2, num1 > num2 ? num1 - num2 : num2 - num1);
            }     
        }
    }
}

