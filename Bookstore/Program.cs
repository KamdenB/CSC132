using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

using CsvHelper;

namespace Bookstore
{
    class Program
    {
        /**
            * Search for a book by author or namespace
            * Add a book to the collection 
            * Delete a book from the collection
            * https://www.kaggle.com/datasets/saurabhbagchi/books-dataset
                * Had to switch ; to ,
                * Had to replcae all \" with '
        **/

        record Book(string ISBN, string BookTitle, string Author, double YearOfPublication, string Publisher);
       
        static void Main(string[] args)
        {
            using var streamReader = File.OpenText("books.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            IEnumerable<Book> books;
            books = csvReader.GetRecords<Book>();

            bool running = true;

            while(running){
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Search for a book by author or name");
                Console.WriteLine("2. Add a book to the collection");
                Console.WriteLine("3. Delete a book from the collection");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();

                switch(input){
                    case "1":
                        Console.WriteLine("Please enter the author or name of the book you are looking for:");
                        string bookSearch = Console.ReadLine();
                        search(books, bookSearch);
                        break;
                    case "2":
                        // add();
                        break;
                    case "3":
                        // delete(books, input);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            // search(books, "More Than a Dream");
        }

        static void search(IEnumerable<Book> books, string searchTerm)
        {
            int found = 0;
            foreach(var book in books) /** O(n) **/
            {
                if(book.BookTitle.Contains(searchTerm) || book.Author.Contains(searchTerm))
                {
                    found++;
                    Console.WriteLine("\nISBN {0}: {1} by {2} \n", book.ISBN, book.BookTitle, book.Author);
                }
            }
            Console.WriteLine("Found {0} books", found);
        }

        // static void add(IEnumerable<Book> books, Book book)
        // {
        //     books.Add(book);
        // }

        // static void delete(ref IEnumerable<Book> books, string ISBN)
        // {
        //    books = books.Where(book => book.ISBN != ISBN);
        // }
    }
}