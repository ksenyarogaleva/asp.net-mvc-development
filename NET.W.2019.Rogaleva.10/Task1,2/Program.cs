using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book(1234567891234, "Джеффри Рихтер", "CLR via C#", "Питер", 2019, 897, 35.10m);
            Book book2 = new Book(9876543021567, "Фрэнсис Скотт Фицджеральд", "Великий Гэтсби", "Москва", 2012, 334, 13.20m);
            Book book3 = new Book(6189056378123, "Эккель", "Философия Java", "Питер", 2015, 911, 30.70m);

            List<Book> books = new List<Book> { book1, book2 };
            BookListService service = new BookListService("books.dat");
            foreach (var item in books)
            {
                Console.WriteLine(item.ToString());
            }

            service.AddBook(book3);
            List<Book> b = service.GetBooks();
            var sort1 = new SortBooksByTag.SortBooksByAuthor();
            b.Sort(sort1);
            foreach (var book in b)
            {
                Console.Write(book.ToString());
            }

            var sort2 = new SortBooksByTag.SortBooksByYear();
            b.Sort(sort2);
            foreach (var book in b)
            {
                Console.Write(book.ToString());
            }

            service.RemoveBook(book2);

            Console.ReadKey();
        }
    }
}
