
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
        public Book? FindBookById(int id)
        {
            return books.Find(b => b.ID == id);
        }


        public bool BorrowBook(int id)
        {
            Book? book = FindBookById(id);
            if (book == null)
            {
                Console.WriteLine("\nBook not found.");
                return false;
            }
            else if (book.IsBorrowed)
            {
                Console.WriteLine("\nBook is already borrowed.");
                return false;
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine("\nBook borrowed successfully.");
                return true;
            }
        }

        public bool ReturnBook(int id)
        {
            Book? book = FindBookById(id);
            if (book == null)
            {
                Console.WriteLine("\nBook not found.");
                return false;
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("\nBook was not borrowed.");
                return false;
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine("\nBook returned successfully.");
                return true;
            }
        }
    }
}