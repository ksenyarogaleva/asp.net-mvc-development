using System.Collections.Generic;

namespace LibraryApp.SortBooksByTag
{
    /// <summary>
    /// Class for sorting books by author name.
    /// </summary>
    internal class SortBooksByAuthor : IComparer<Book>
    {
        /// <summary>
        /// Compares two books using its names.
        /// </summary>
        /// <param name="book1">First book.</param>
        /// <param name="book2">Second book.</param>
        /// <returns>The result of the comparing.</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Author.CompareTo(book2.Author);
        }
    }
}
