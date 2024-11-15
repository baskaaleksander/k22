// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Intrinsics.X86;

namespace k22.zadanie_interface
{

    class Program
    {
        class Book : IComparable<Book>
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public double Price;
            public Book (string title, string author, int year, double price)
            {
                Title = title;
                Author = author;
                Year = year;
                Price = price;
            }
            public override string ToString()
            {
                return $"{Title} {Author} {Year} {Price}zł";
            }
            public int CompareTo(Book other)
            {
                return Price.CompareTo(other.Price);
            }
        }
        static void Main(string[] args)
        {
            // List<Book> books = new List<Book>();
            // books.Add(new Book("W pustyni i w puszczy", "Henryk Sienkiewicz", 1911, 19.90));
            // books.Add(new Book("Krzyżacy", "Henryk Sienkiewicz", 1900, 22.90));
            // books.Add(new Book("Ogniem i mieczem", "Henryk Sienkiewicz", 1884, 24.90));
            // foreach (Book ksiazka in books){
            //     Console.WriteLine(ksiazka.ToString());
            // }
            // Console.WriteLine("Posortwoane");
            // books.Sort();
            // foreach (Book ksiazka in books){
            //     Console.WriteLine(ksiazka.ToString());
            // }
            // Console.WriteLine("Posortowane po roku");
            // var sortedByYear = books.OrderBy(x => x.Year);
            // foreach (Book ksiazka in sortedByYear){
            //     Console.WriteLine(ksiazka.ToString());
            // }
            // Console.WriteLine("Posortowane po autorze");
            // var sortedByAuthor = books.OrderBy(x => x.Author);
            // foreach (Book ksiazka in sortedByAuthor){
            //     Console.WriteLine(ksiazka.ToString());
            // }

            // var comparer = Comparer<Book>.Create((b1, b2) => b1.Price.CompareTo(b2.Price));
            // int comparisonResult = comparer.Compare(books[0], books[1]);
            List<Book> books = new List<Book>();

            while (true){
                Console.WriteLine("Menu");
                Console.WriteLine("1. Wyświetl wszystkie książki");
                Console.WriteLine("2. Sortuj książki po cenie");
                Console.WriteLine("3. Sortuj książki po roku");
                Console.WriteLine("4. Sortuj książki po autorze");
                Console.WriteLine("5. Dodaj książkę");
                Console.WriteLine("6. Usuń książkę");
                Console.WriteLine("7. Wyjdź");
                Console.WriteLine("Wybierz opcję");
                int wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        foreach (Book ksiazka in books){
                            Console.WriteLine(ksiazka.ToString());
                        }
                        break;
                    case 2:
                        books.Sort();
                        foreach (Book ksiazka in books){
                            Console.WriteLine(ksiazka.ToString());
                        }
                        break;
                    case 3:
                        var sortedByYear = books.OrderBy(x => x.Year);
                        foreach (Book ksiazka in sortedByYear){
                            Console.WriteLine(ksiazka.ToString());
                        }
                        break;
                    case 4:
                        var sortByAuthor = books.OrderBy(x => x.Author);
                        foreach (Book ksiazka in sortByAuthor){
                            Console.WriteLine(ksiazka.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Dodawanie książki");
                        Console.WriteLine("Podaj tytuł");
                        string tytul = Console.ReadLine();
                        Console.WriteLine("Podaj autora");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Podaj rok wydania");
                        int rok = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj cenę");
                        double cena = double.Parse(Console.ReadLine());
                        books.Add(new Book(tytul, autor, rok, cena));
                        Console.WriteLine("Książka dodana");
                        break;
                    case 6:
                        Console.WriteLine("Usuń książkę");
                        Console.WriteLine("Podaj tytuł książki");
                        string tytulKsiazki = Console.ReadLine();
                        Book ksiazkaDoUsuniecia = null;
                        foreach (Book ksiazka in books){
                            if (ksiazka.Title.ToUpper() == tytulKsiazki.ToUpper()){
                                ksiazkaDoUsuniecia = ksiazka;
                            }
                            books.Remove(ksiazkaDoUsuniecia);
                        }
                        Console.WriteLine("Książka usunięta");
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }
        }
    }
    }
}
