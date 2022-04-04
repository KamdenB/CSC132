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
            * Print all books in the collection
            * https://www.kaggle.com/datasets/saurabhbagchi/books-dataset
        **/

        record Book(string ISBN, string BookTitle, string Author, double YearOfPublication, string Publisher);
        static void Main(string[] args)
        {
            using var streamReader = File.OpenText("books.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            var books = csvReader.GetRecords<Book>();

            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
