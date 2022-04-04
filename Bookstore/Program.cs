using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

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


        record Book(string ISBN, string BookTitle, string Author, string yearOfPublication, string Publisher, string imageUrlS, string imageUrlM, string imageUrlL);
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("books.csv");
            List<string> books = new List<string>();
            string book;
            while((book = sr.ReadLine()) != null)
            {
                books.Add(book);
            }
        }
    }
}
