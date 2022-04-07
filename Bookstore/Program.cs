using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

using CsvHelper;

namespace Bookstore
{
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


        public static IEnumerable<Book> books;
    
        public record Book(string ISBN, string BookTitle, string Author, double YearOfPublication, string Publisher);
       
        public static void Main(string[] args)
        {
            openFile("books.csv");

            bool running = true;

            while(running){
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Search for a book by author or name");
                Console.WriteLine("2. Add a book to the collection");
                Console.WriteLine("3. Delete a book from the collection");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Save");

                string input = Console.ReadLine();

                switch(input){
                    case "1":
                        Console.WriteLine("Please enter the name of the book you are looking for:");
                        string bookSearch = Console.ReadLine();
                        search(bookSearch);
                        break;
                    case "2":
                        // add();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the ISBN of a book you would like to delete or q to cancel");
                        string bookDelete = Console.ReadLine();
                        if(bookDelete == "q") break;
                        // delete(ref books, bookDelete);
                        break;
                    case "4":
                        running = false;
                        break;
                    case "5":
                        // saveFile(books, "books.csv");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            // search(books, "More Than a Dream");
        }

        public static void openFile(string file)
        {
            using var streamReader = File.OpenText(file);
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            books = csvReader.GetRecords<Book>();
        }

        public static void search(string searchTerm)
        {
            int found = 0;
            foreach(var book in books) /** O(n) time and space complexity **/
            {
                if(book.BookTitle.ToLower().Contains(searchTerm.ToLower()))
                {
                    found++;
                    Console.WriteLine("\nISBN {0}: {1} by {2} \n", book.ISBN, book.BookTitle, book.Author);
                }
            }
            Console.WriteLine("Found {0} books", found);
        }

        // static void add(ref IEnumerable<Book> books, Book book)
        // {
        //     books.Add(book);
        // }

        // public void delete(ref IEnumerable<Book> books, string ISBN)
        // {
        //     try {
        //         books = books.Where(book => book.ISBN != ISBN);
        //         Console.WriteLine("Successfully removed {0}", ISBN);
        //     }
        //     catch(Exception e) {
        //         Console.WriteLine("Error: {0}", e.Message);
        //     }
        // }

        // public void saveFile(IEnumerable<Book> books, string file){
        //     using var streamWriter = File.CreateText(file);
        //     using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
        //     csvWriter.WriteRecords(books);
        //     openFile();
        // }
    }
}