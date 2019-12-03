using System.Collections.Generic;

namespace LibraryApp.SortBooksByTag
{
    /// <summary>
    /// Class for sorting books by amount of pages.
    /// </summary>
    internal class SortBooksByPages : IComparer<Book>
    {
        /// <summary>
        /// Compares two books using amount of its pages.
        /// </summary>
        /// <param name="book1">First book.</param>
        /// <param name="book2">Second book.</param>
        /// <returns>The result of the comparing.</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Pages.CompareTo(book2.Pages);
        }
    }
}
