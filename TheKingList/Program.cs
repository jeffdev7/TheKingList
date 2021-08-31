using System;
using System.Collections.Generic;
using System.Linq;

namespace TheKingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Books that I've already read by Stephen King:\n");
            List<Book> Books = new List<Book>();
            Books.Add(new Book { Id = 01, Name = "it" });
            Books.Add(new Book { Id = 02, Name = "The Stand" });
            Books.Add(new Book { Id = 03, Name = "The Shining" });
            Books.Add(new Book { Id = 04, Name = "Misery" });
            Books.Add(new Book { Id = 05, Name = "Salem's lot" });
            Books.Add(new Book { Id = 06, Name = "Pet Sematary" });
            Books.Add(new Book { Id = 07, Name = "11/25/63" });
            Books.Add(new Book { Id = 08, Name = "Doctor Sleep" });
            Books.Add(new Book { Id = 09, Name = "The Green Mile" });
            Books.Add(new Book { Id = 10, Name = "On writing" });
            Books.Add(new Book { Id = 11, Name = "Joyland" });
            Books.Add(new Book { Id = 12, Name = "Firestarter" });
            Books.Add(new Book { Id = 13, Name = "Gerald's game" });
            Books.Add(new Book { Id = 14, Name = "Cujo" });
            Books.Add(new Book { Id = 15, Name = "Later" });

            foreach (var b in Books)
            {
                Console.WriteLine(" " + b.Id + " " + b.Name);
            }

            var buch = Books.FirstOrDefault(b => b.Id == 06);
            Console.WriteLine($"\n {buch.Name} was the first book that I read by SK.");

            Program quote = new Program();
            quote.ShowQuote();

            //Ways to search through a list:

            //1- My favorite
            //var b = Books.FirstOrDefault(b => b.Id == 2);
            //Console.WriteLine($"Id: {b.Id}  {b.Name}");

            //and
            //var buch = Books.Where(b => b.Name.ToLower().Contains("do")).ToList();
            //foreach (var b in buch)
            //{
            //    Console.WriteLine($"Id: {b.Id}  {b.Name}");
            //}
        }
        void ShowQuote() => Console.WriteLine("\n Books are a uniquely portable magic. - Stephen King");
    }
}
