
namespace LibraryManagementSystem
{
    public class Library
    {
        private readonly List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("\nBook added successfully");
        }


        public void ViewBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available");
            }
            else
            {
                Console.WriteLine("\nBooks in the library:");
                foreach (var book in books)
                {

                    Console.WriteLine(book);
                }
            }
        }

        //helper method to find books
        public Book? FindBookById(int id)
        {
            return books.Find(b => b.ID == id);
        }

        public (string message, bool success) BorrowBook(int id)
        {
            Book? book = FindBookById(id);
            if (book == null)
            {
                return ("\nBook not found.", false);
            }
            else if (book.IsBorrowed)
            {
                return ("\nBook is already borrowed.", false);
            }
            else
            {
                book.IsBorrowed = true;
                return ("\nBook borrowed successfully.", true);
            }
        }

        public (string message, bool success) ReturnBook(int id)
        {
            Book? book = FindBookById(id);
            if (book == null)
            {
                return ("\nBook not found.", false);
            }
            else if (!book.IsBorrowed)
            {
                return ("\nBook was not borrowed.", false);
            }
            else
            {
                book.IsBorrowed = false;
                return ("\nBook returned successfully.", false);
            }
        }
    }
}