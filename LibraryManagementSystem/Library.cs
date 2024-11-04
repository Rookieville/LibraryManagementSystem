using System;
using System.Collections.Generic;



namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully");
        }


        public void ViewBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available");
            }
            else
            {
                Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {

                    Console.WriteLine(book);
                }
            }
        }

        //helper method to find books
        public Book FindBookById(int id)
        {
            foreach (var book in books)
            {
                if (book.ID == id)
                {
                    return book;
                }
            }
            return null;
        }


        public void BorrowBook(int id)
        {
            Book book = FindBookById(id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
            }
            else if (book.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine("Book borrowed successfully");
            }
        }

        public void ReturnBook(int id)
        {
            Book book = FindBookById(id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("Book is not borrowed");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine("Book returned successfully");
            }
        }
    }
}