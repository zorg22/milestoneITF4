using System;
using System.Collections.Generic;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();
            List<Book> results = new List<Book>();
            Book LOTR = new Book("Władca Pierścieni: Drużyna Pierścienia", "J.R.R. Tolkien", Genre.Fantasy, "Początek opowieści o wyparie Frodo i Sama do Mordoru, ŻEBY URATOWADŹ ŚWIAT!", 423, 35.99, "29 July 1954", "Allen & Unwin", true);
            Book CatCradle = new Book("Kocia Kołyska", "Kurt Vonnegut", Genre.Fantasy, "Historia Feliksa Hoenikera, twórcy bomby atomowej", 304, 42.50, "1963", "Henry Holt and Company", true);
            Book Slaughterhouse = new Book("Rzeźnia numer 5", "Kurt Vonnegut", Genre.Science, "Historia Amerykanina w niewoli Niemieckiej, który przeżył bombardowanie Drezna.", 666, 45.29, "31.03.1969", "Henry Holt and Company", true);

            Books.Add(LOTR);
            Books.Add(CatCradle);
            Books.Add(Slaughterhouse);

            Console.WriteLine("Choose your operation:");
            Console.WriteLine("Type 'show' to show all books and their details.");
            Console.WriteLine("Type 'search' to filter the list of books.");
            //Console.WriteLine("Type 'buy' to start the purchase.");
            //Console.WriteLine("Type 'add' to add a book to the list.");
            
            string instruction = Console.ReadLine();
            switch (instruction)
            {
                case "show":
                    Books.ForEach(el => el.ShowDetails());
                    break;
                case "search":
                    Console.WriteLine("Select the searched type: title / author / genre / availability ");
                    string searchedType = Console.ReadLine();
                    switch (searchedType)
                    {
                        case "title":
                            Console.WriteLine("Enter the searched title: ");
                            string searchedTitle = Console.ReadLine();
                            GetBooksByTitle(searchedTitle);
                            results.ForEach(el => { Console.WriteLine(" "); el.ShowDetails(); });
                            results.Clear();
                            break;
                        case "author":
                            Console.WriteLine("Enter the searched author: ");
                            string searchedAuthor = Console.ReadLine();
                            GetBooksByAuthor(searchedAuthor);
                            results.ForEach(el => { Console.WriteLine(" "); el.ShowDetails(); });
                            results.Clear();
                            break;
                    }
                    break;
            }


            void GetBooksByTitle(string title)
            {
                Books.ForEach(el =>
                {

                    if (el.Title == title)
                    {
                        results.Add(el);
                    }
                });
            }
            void GetBooksByAuthor(string author)
            {
                Books.ForEach(el =>
                {

                    if (el.Author == author)
                    {
                        results.Add(el);
                    }
                });
            }
            Console.ReadKey();
        }
    }
}
