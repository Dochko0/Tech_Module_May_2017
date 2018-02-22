using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.BookLibrary
{
    

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
                    ReleaseDate = DateTime.Parse(bookDescription[3]),
                    ISBN = bookDescription[4],
                    Price = decimal.Parse(bookDescription[5])
                };
                bookPricesList.Books.Add(property);
            }

            var result = bookPricesList.Books.GroupBy(x => x.Autor).Select(g => new { Name = g.Key, Total = g.Sum(s => s.Price) }).OrderByDescending(x => x.Total).ThenBy(y => y.Name).ToList();


            foreach (var r in result)
            {
                Console.WriteLine($"{r.Name} -> {r.Total:f2}");
            }
        }
    }    
}
