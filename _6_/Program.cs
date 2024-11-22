using System;
using System.Security.Cryptography.X509Certificates;

namespace _6_
{
    class Book : IComparable<Book>
    {
        string title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Book (string title, string author, int year, double price)
        {
            this.title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public int CompareTo(Book other)
        {
            return this.Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            return $"{title} {Author} {Year} {Price}zł";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Book1", "Author1", 2010, 110));
            books.Add(new Book("Book2", "Author2", 2008, 10));
            books.Add(new Book("Book3", "Author3", 2004, 90));
            books.Add(new Book("Book4", "Author4", 2001, 19));

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("Sorted by price");
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("Sorted by year");
            var sortedByYear = books.OrderBy(x => x.Year);

            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("Sorted by author");
            var sortedByAuthor = books.OrderByDescending(x => x.Author);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book.ToString());
            }
            var sortedByPriceAndYear = books.OrderByDescending(x => x.Price).ThenBy(x => x.Year);
            Console.WriteLine("Sorted by price and year");
            foreach (Book book in sortedByPriceAndYear)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
