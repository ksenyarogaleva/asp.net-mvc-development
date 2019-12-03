using System.Collections.Generic;

namespace LibraryApp.SortBooksByTag
{
    /// <summary>
    /// Class for sorting books by year of its publishing.
    /// </summary>
    internal class SortBooksByYear : IComparer<Book>
    {
        /// <summary>
        /// Compares two books using its year of publishing.
        /// </summary>
        /// <param name="book1">First book.</param>
        /// <param name="book2">Second book.</param>
        /// <returns>The result of the comparing.</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Year.CompareTo(book2.Year);
        }
    }
}
