using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryApp
{
    /// <summary>
    /// Storage of the books.
    /// </summary>
    internal class BookListStorage
    {
        private readonly string pathToStorage = "library.dat";

        public BookListStorage(string path)
        {
            this.pathToStorage = path;
        }

        public BookListStorage()
        {
        }

        /// <summary>
        /// Loads books from storage.
        /// </summary>
        /// <returns>List of loaded books.</returns>
        public List<Book> GetBooksFromStorage()
        {
            using (var reader = new BinaryReader(new FileStream(this.pathToStorage, FileMode.OpenOrCreate)))
            {
                List<Book> books = new List<Book>();
                while (reader.PeekChar() > -1)
                {
                    long isbn = reader.ReadInt64();
                    string author = reader.ReadString();
                    string bookname = reader.ReadString();
                    string publisher = reader.ReadString();
                    int year = reader.ReadInt32();
                    int pages = reader.ReadInt32();
                    decimal price = reader.ReadDecimal();

                    Book book = new Book(isbn, author, bookname, publisher, year, pages, price);
                    if (!books.Contains(book))
                    {
                        books.Add(book);
                    }
                    else
                    {
                        throw new ArgumentException("This book has already been loaded from the storage.");
                    }
                }

                return books;
            }
        }

        /// <summary>
        /// Saves books to storage.
        /// </summary>
        /// <param name="books">List of books to save in storage.</param>
        public void SaveBookToStorage(List<Book> books)
        {
            if (books == null)
            {
                throw new ArgumentException("Books can't be null.");
            }

            using (var writer = new BinaryWriter(new FileStream(this.pathToStorage, FileMode.Create)))
            {
                foreach (Book book in books)
                {
                    writer.Write(book.ISBN);
                    writer.Write(book.Author);
                    writer.Write(book.BookName);
                    writer.Write(book.Publisher);
                    writer.Write(book.Year);
                    writer.Write(book.Pages);
                    writer.Write(book.Price);
                }
            }

            Console.WriteLine($"Book(s) added to storage.");
        }
    }
}
