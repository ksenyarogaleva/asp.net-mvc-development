using System.Collections.Generic;

namespace LibraryApp.SortBooksByTag
{
    /// <summary>
    /// Class for sorting books by its publishers.
    /// </summary>
    internal class SortBooksByPublisher : IComparer<Book>
    {
        /// <summary>
        /// Compares two books using its publishers.
        /// </summary>
        /// <param name="book1">First book.</param>
        /// <param name="book2">Second book.</param>
        /// <returns>The result of the comparing.</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Publisher.CompareTo(book2.Publisher);
        }
    }
}
