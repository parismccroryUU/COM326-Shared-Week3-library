using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        //private fields
        private string _title;
        private string _author;
        private string _isbn;

        // public properties
        public string Title 
        {
            get { return _title; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title cannot be blank or contain numbers.");
                }
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author cannot be blank or contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }


        // Constructor
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this._title = bookTitle;
            this._author = bookAuthor;
            this._isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
