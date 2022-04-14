using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

using CsvHelper;

namespace Bookstore
{

    class Book {
        public string ISBN { get; set;}

        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string YearOfPublication { get; set; }
        public string Publisher { get; set; }
    }
    class Bookstore
    {
        /**
            * Search for a book by author or namespace
            * Add a book to the collection 
            * Delete a book from the collection
            * https://www.kaggle.com/datasets/saurabhbagchi/books-dataset
                * Had to switch ; to ,
                * Had to replcae all \" with '
        **/

        /**
            TODO:
                - Add a book to the collection
                - Delete a book from the collection

        **/


        public static IEnumerable<Book> books;
        public static void Main(string[] args)
        {
            openFile("Bookstore.csv");

            bool running = true;

            while(running){
                Console.WriteLine("1. Search for a book by title; {0} books available", books.Count());
                Console.WriteLine("2. Add a book to the collection");
                Console.WriteLine("3. Delete a book from the collection");
                Console.WriteLine("4. Exit");
                Console.Write("Please choose an option: ");

                string input = Console.ReadLine();

                switch(input){
                    case "1":
                        Console.Write("Please enter the name of the book you are looking for: ");
                        string bookSearch = Console.ReadLine();
                        search(bookSearch);
                        break;
                    case "2":
                        add();
                        break;
                    case "3":
                        Console.Write("\nPlease enter the ISBN of a book you would like to delete or q to cancel: ");
                        string bookDelete = Console.ReadLine();
                        if(bookDelete == "q") break;
                        delete(ref books, bookDelete);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        public static void openFile(string file)
        {
            try 
            {
                using var streamReader = File.OpenText(file);
                using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                books = csvReader.GetRecords<Book>().ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void search(string searchTerm)
        {
            Console.WriteLine("\nSearching...");
            int found = 0;

            foreach(var book in books) /** O(n) time and space complexity **/
            {
                if(cleanString(book.BookTitle).Contains(cleanString(searchTerm)))
                {
                    found++;
                    Console.WriteLine("ISBN {0}: {1} by {2}", book.ISBN, book.BookTitle, book.Author);
                }
            }
            Console.WriteLine("Found {0} books\n", found);
        }


        public static void add()
        {
            Console.WriteLine("\nAdding a book...");
            Console.Write("Please enter the ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Please enter the title: ");
            string title = Console.ReadLine();
            Console.Write("Please enter the author: ");
            string author = Console.ReadLine();
            Console.Write("Please enter the year of publication: ");
            string year = Console.ReadLine();
            Console.Write("Please enter the publisher: ");
            string publisher = Console.ReadLine();


            try{

                Book newBok = new Book(){
                    ISBN = isbn,
                    BookTitle = title,
                    Author = author,
                    YearOfPublication = year,
                    Publisher = publisher
                };

                books = books.Concat(new List<Book>(){newBok});
                saveFile(books, "Bookstore.csv");
                Console.WriteLine("Book added");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /** 
            Clean string to help filter out annoying minor differences
                - Remove [ ' ]
                - Remove [ - ]
                - Remove [ , ]
                - To lower case
        **/
        public static string cleanString(string input)
        {

            return 
                input.Replace("-", " ") // replace - with space
                .Replace(",", "") // remove ,
                .Replace("\"", "'") // remove " and repalce '
                .ToLower();
        }

        public static void delete(ref IEnumerable<Book> bookList, string ISBN)
        {
            try {
                bookList = bookList.Where(book => book.ISBN != ISBN); // Remove books from current list of books
                saveFile(books, "Bookstore.csv"); // Save new list of books
                Console.WriteLine("Successfully removed {0}\n", ISBN);
            }
            catch(Exception e) {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        public static void saveFile(IEnumerable<Book> books, string file)
        {
            try{
                using var streamWriter = File.CreateText(file);
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(books);
                Console.WriteLine("Successfully saved");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}