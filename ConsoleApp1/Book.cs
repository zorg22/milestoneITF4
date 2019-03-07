using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Book
    {
        public Book(string title, string author, Genre genre, string description, int pages, double price, string published, string publisher, bool available)
        {
            _title = title;
            _author = author;
            _genre = genre;
            _description = description;
            _pages = pages;
            _price = price;
            _published = published;
            _publisher = publisher;
            _available = available;
        }

        private string _title;
        private string _author;
        private Genre _genre;
        private string _description;
        private int _pages;
        private double _price;
        private string _published;
        private string _publisher;
        private bool _available;

        public string Title
        {
            get { return _title; }
            private set
            {
                _title = value;
            }
        }
        public string Author
        {
            get { return _author; }
            private set
            {
                _author = value;
            }
        }
        public Genre Genre
        {
            get { return _genre; }
            private set
            {
                _genre = value;
            }
        }
        public string Description
        {
            get { return _description; }
            private set
            {
                _description = value;
            }
        }
        public int Pages
        {
            get { return _pages; }
            private set
            {
                _pages = value;
            }
        }
        public double Price
        {
            get { return _price; }
            private set
            {
                _price = value;
            }
        }
        public string Published
        {
            get { return _published; }
            private set
            {
                _published = value;
            }
        }
        public string Publisher
        {
            get { return _publisher; }
            private set
            {
                _publisher = value;
            }
        }
        public bool Available
        {
            get { return _available; }
            private set
            {
                _available = value;
            }
        }
        
        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Number of pages: {Pages}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"First published on: {Published}");
            Console.WriteLine($"Published by: {Publisher}");
            if (Available)
            {
                Console.WriteLine("This book is currently available.");
            } else
            {
                Console.WriteLine("This book is not available now");
            }
            Console.WriteLine("...");
        }
    }
}
