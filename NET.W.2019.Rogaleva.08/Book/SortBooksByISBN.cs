using System.Collections.Generic;

namespace LibraryApp.SortBooksByTag
{
    internal class SortBooksByISBN : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            return book1.ISBN.CompareTo(book2.ISBN);
        }
    }
}
