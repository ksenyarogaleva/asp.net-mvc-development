using System;
using System.Collections.Generic;


namespace Tasks
{

    /// <summary>
    /// The main<c>Task4</c> class.
    /// Contains methods for filtering list of integer elements depending on teh condition.
    /// </summary>
    public class Task4
    {

        /// <summary>
        /// Filters list.
        /// </summary>
        /// <param name="list">List of integer elements.</param>
        /// <param name="number">An integer.</param>
        /// <returns>List with elements that contain the given digit.</returns>
        public static List<int> FilterDigit(List<int> list, int number)
        {
            List<int> filteredList = new List<int>();
            for (int i = 0; i < list.ToArray().Length; i++)
            {
                bool check = true;
                if (list[i] != number && list[i] % 10 != number && list[i] / 10 != number)
                    check = false;
                if (check && !filteredList.Contains(list[i]))
                    filteredList.Add(list[i]);
            }

            return filteredList;
        }
    }
}
