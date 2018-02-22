using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library bookPricesList = new Library();
            var num = int.Parse(Console.ReadLine());
            bookPricesList.Books = new List<Book>();

            var bookList = new List<Book>();

            for (int i = 0; i < num; i++)
            {
                var bookDescription = Console.ReadLine().Split(' ').ToList();
                Book property = new Book
                {
                    Title = bookDescription[0],
                    Autor = bookDescription[1],
                    Publisher = bookDescription[2],
                    ReleaseDate = DateTime.ParseExact(bookDescription[3], "d.M.yyyy", CultureInfo.InstalledUICulture),
                    ISBN = bookDescription[4],
                    Price = decimal.Parse(bookDescription[5])
                };
                bookPricesList.Books.Add(property);
            }
            DateTime releasedAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            var result = bookPricesList.Books.Where(x=>x.ReleaseDate>releasedAfter).
                OrderBy(x => x.ReleaseDate).ThenBy(y => y.Title).ToList();


            foreach (var r in result)
            {
                Console.WriteLine($"{r.Title} -> {r.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
