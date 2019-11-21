using System;
using System.Collections;
using System.Text;

namespace NET.W._2019.Rogaleva._04
{
    /// <summary>
    /// The main <c>DoubleToBytes</c> class.
    /// </summary>
    public static class DoubleToBytes
    {
        /// <summary>
        /// Converts 64bit double precision number into string with its byte representation.
        /// </summary>
        /// <param name="number">Double number.</param>
        /// <returns>String representation of number's byte representation.</returns>
        public static string DoubleToBytesConverter(double number)
        {
            BitArray bitArray = new BitArray(BitConverter.GetBytes(number));
            StringBuilder stringOfBytes = new StringBuilder(64);
            for(int i = bitArray.Length - 1; i >= 0; i--)
            {
                if (bitArray[i] == false)
                    stringOfBytes.Append('0');
                else
                    stringOfBytes.Append('1');
            }

            return stringOfBytes.ToString();

        }
        

    }
}
