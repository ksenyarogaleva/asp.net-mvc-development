using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LibraryApp
{
    /// <summary>
    /// The main class <c>Book</c>
    /// Represents book.
    /// </summary>
    internal class Book : IComparable, IComparable<Book>, IEquatable<Book>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// Initializes book.
        /// </summary>
        /// <param name="isbn">Unique identifier of the book.</param>
        /// <param name="author">Author of the book.</param>
        /// <param name="name">Name of the book.</param>
        /// <param name="publisher">Publishing house.</param>
        /// <param name="year">Year of publishing of the book.</param>
        /// <param name="pages">Amount of pages in the book.</param>
        /// <param name="price">Price of the book.</param>
        public Book(long isbn, string author, string name, string publisher, int year, int pages, decimal price)
        {
            if (isbn.ToString().Length != 13 || isbn < 0)
            {
                throw new ArgumentException("ISBN number should contain 13 digits.");
            }
            else
            {
                this.ISBN = isbn;
            }

            if (CheckString(author))
            {
                this.Author = author;
            }
            else
            {
                throw new ArgumentException("Wrong format of Author string.");
            }

            if (CheckString(name))
            {
                this.BookName = name;
            }
            else
            {
                throw new ArgumentException("Wrong format of Name of the book string.");
            }

            if (CheckString(publisher))
            {
                this.Publisher = publisher;
            }
            else
            {
                throw new ArgumentException("Wrong format of Publisher string.");
            }

            if (year.ToString().Length == 4 && year < 2021)
            {
                this.Year = year;
            }
            else
            {
                throw new ArgumentException("Wrong format of the year of book publishing.");
            }

            if (pages <= 0)
            {
                throw new ArgumentException("The book can't contain 0 or less pages.");
            }
            else
            {
                this.Pages = pages;
            }

            if (price <= 0)
            {
                throw new ArgumentException("The price of the book should be positive.");
            }
            else
            {
                this.Price = price;
            }
        }

        /// <summary>
        /// Method for checking if string is null of contains only white spaces.
        /// </summary>
        /// <param name="s">String to check.</param>
        /// <returns>'True' if string is okay.'False' if it's null or contains only white spaces.</returns>
        public static bool CheckString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            return true;
        }

        public long ISBN { get; private set; }

        public string Author { get; private set; }

        public string BookName { get; private set; }

        public string Publisher { get; private set; }

        public int Year { get; private set; }

        public int Pages { get; private set; }

        public decimal Price { get; private set; }

        /// <summary>
        /// Compares book to object.
        /// </summary>
        /// <param name="obj">Object to compare with book.</param>
        /// <returns>The result of the comparing.</returns>
        public int CompareTo(object obj)
        {
            if (obj is Book && obj != null)
            {
                Book book = (Book)obj;
                return this.CompareTo(book);
            }
            else
            {
                throw new ArgumentException("Can't compare book with this object.");
            }
        }

        /// <summary>
        /// Checks if two books are equal.
        /// </summary>
        /// <param name="other">Book.</param>
        /// <returns>'True' if books are equal.'False' if not.</returns>
        public bool Equals(Book other)
        {
            if (this.ISBN == other.ISBN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Compares two books.
        /// </summary>
        /// <param name="other">Book</param>
        /// <returns>The result of the comparing.</returns>
        public int CompareTo(Book other)
        {
            if (other != null)
            {
                return string.Compare(this.BookName, other.BookName);
            }
            else
            {
                throw new ArgumentException("Can't compare book to null.");
            }
        }

        /// <summary>
        /// Checks if book is equal to object.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>The result of checking.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Book && obj != null)
            {
                Book book = obj as Book;
                return this.ISBN == book.ISBN && this.BookName == book.BookName && this.Author == book.Author && this.Publisher == book.Publisher && this.Year == book.Year && this.Pages == book.Pages;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Converts book information into its string representation.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return $"ISBN: {this.ISBN}\nAuthor: {this.Author}\nBook name: {this.BookName}\nPublisher:{this.Publisher}\nYear: {this.Year}\nPages: {this.Pages}\nPrice: {this.Price}\n\n";
        }

        public string ToString(string type,IFormatProvider format)
        {
            if (format == null)
            {
                format = CultureInfo.CurrentCulture;
            }

            if (string.IsNullOrEmpty(type))
            {
                type = "simple";
            }

            switch (type)
            {
                case "simple":
                    return this.ToString();
                case "Author+Book name":
                    return $"Author: {this.Author}\nBook name:{this.BookName}\n\n";
                case "Author+Book name+Publisher+Year":
                    return $"Author: {this.Author}\nBook name:{this.BookName}\nPublisher:{this.Publisher}\nYear: {this.Year}\n\n";
                case "simple without price":
                    return $"ISBN: {this.ISBN}\nAuthor: {this.Author}\nBook name: {this.BookName}\nPublisher:{this.Publisher}\nYear: {this.Year}\nPages: {this.Pages}\n\n";
                case "simple without publisher":
                    return $"ISBN: {this.ISBN}\nAuthor: {this.Author}\nBook name: {this.BookName}\nYear: {this.Year}\nPages: {this.Pages}\nPrice: {this.Price}\n\n";
                case "ISBN+Author+Book name":
                    return $"ISBN: {this.ISBN}\nAuthor: {this.Author}\nBook name: {this.BookName}\n\n";
                case "Author+Book name+Price":
                    return $"Author: {this.Author}\nBook name:{this.BookName}\nPrice: {this.Price}\n\n";
                default:
                    throw new FormatException("Incorrect format type");
            }
        }

        /// <summary>
        /// Find hash code of the book.
        /// </summary>
        /// <returns>Hash code of the book.</returns>
        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode() + this.BookName.GetHashCode() + this.Publisher.GetHashCode() + this.Year.GetHashCode() + this.Pages.GetHashCode() + this.Price.GetHashCode();
        }
    }
}
