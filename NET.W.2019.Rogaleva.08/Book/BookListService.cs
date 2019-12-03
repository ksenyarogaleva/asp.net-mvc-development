using System;
using System.Collections.Generic;

namespace LibraryApp
{
    /// <summary>
    /// Contains main operations with the list of books.
    /// </summary>
    internal class BookListService
    {
        private readonly BookListStorage storage;

        private List<Book> books = new List<Book>();

        public BookListService(string path)
        {
            this.storage = new BookListStorage(path);
        }

        public enum Tag
        {
            ISBN,
            Author,
            BookName,
            Publisher,
            Year,
            Pages,
            Price,
        }

        /// <summary>
        /// Adds book if it hasn't already been added.
        /// </summary>
        /// <param name="book">Book to add.</param>
        public void AddBook(Book book)
        {
            CheckTheBook(book);

            if (!this.books.Contains(book))
            {
                this.books.Add(book);
                Console.WriteLine("book added to list");
                this.storage.SaveBookToStorage(this.books);
            }
            else
            {
                throw new ArgumentException("This book has been already added.");
            }
        }

        /// <summary>
        /// Removes book if this book exists.
        /// </summary>
        /// <param name="book">Book to remove.</param>
        public void RemoveBook(Book book)
        {
            CheckTheBook(book);
            this.books = this.GetBooks();
            if (this.books.Contains(book))
            {
                this.books.Remove(book);
                this.storage.SaveBookToStorage(this.books);
            }
            else
            {
                throw new ArgumentException("Such book wasn't found.");
            }
        }

        /// <summary>
        /// Gets Book grom the storage.
        /// </summary>
        /// <returns>List of books from the storage.</returns>
        public List<Book> GetBooks()
        {
            return this.storage.GetBooksFromStorage();
        }

        /// <summary>
        /// Finds book in list by tag.
        /// </summary>
        /// <param name="tag">Tag for finding by it.</param>
        /// <returns>List with requirable books.</returns>
        public List<Book> FindBooksByTag(Tag tag)
        {
            List<Book> findedBooks = new List<Book>();
            switch (tag)
            {
                case Tag.ISBN:
                    long isbn = Convert.ToInt64(Console.ReadLine());
                    foreach (Book book in this.books)
                    {
                        if (book.ISBN == isbn)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.Author:
                    string author = Console.ReadLine();
                    foreach (Book book in this.books)
                    {
                        if (book.Author == author)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.BookName:
                    string name = Console.ReadLine();
                    foreach (Book book in this.books)
                    {
                        if (book.BookName == name)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.Publisher:
                    string publisher = Console.ReadLine();
                    foreach (Book book in this.books)
                    {
                        if (book.Publisher == publisher)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.Year:
                    int year = int.Parse(Console.ReadLine());
                    foreach (Book book in this.books)
                    {
                        if (book.Year == year)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.Pages:
                    int pages = int.Parse(Console.ReadLine());
                    foreach (Book book in this.books)
                    {
                        if (book.Pages == pages)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
                case Tag.Price:
                    decimal price = decimal.Parse(Console.ReadLine());
                    foreach (Book book in this.books)
                    {
                        if (book.Price == price)
                        {
                            findedBooks.Add(book);
                        }
                    }

                    break;
            }

            return findedBooks;
        }

        /// <summary>
        /// Checks if book is null.
        /// </summary>
        /// <param name="book">Book to check.</param>
        /// <returns>'True' if book is not null.</returns>
        private static bool CheckTheBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            return true;
        }

    }
}
