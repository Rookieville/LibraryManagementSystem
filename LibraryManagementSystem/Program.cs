
namespace LibraryManagementSystem
{
    public static class Program
    {
        public static void Main()
        {
            Library library = new Library();
            bool exit = false;

            //loop to display the menu until the user exits
            while (!exit)
            {
                Console.WriteLine("\nWelcome to the Library Management System");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Borrow a book");
                Console.WriteLine("4. Return a book");
                Console.WriteLine("5. Exit the application\n");

                Console.Write("Select an option: ");

                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Invalid option. Please try again.");

                    continue;
                }

                switch (option)
                {
                    case 1:
                        AddNewBook(library);
                        break;

                    case 2:
                        library.ViewBooks();
                        break;

                    case 3:
                        BorrowBook(library);
                        break;

                    case 4:
                        ReturnBook(library);
                        break;

                    case 5:
                        Console.WriteLine("\nExiting the application...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;

                }
            }




        }


        private static int GetValidBookId(Library library, bool isAddingNewBook = false)
        {
            int id;
            while (true)
            {
                Console.Write("\nEnter book ID: ");
                var idInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(idInput) || !int.TryParse(idInput, out id))
                {
                    Console.WriteLine("Invalid input! Please enter a non-empty numeric ID.");
                    continue;
                }

                if (isAddingNewBook && library.FindBookById(id) != null)
                {
                    Console.WriteLine("A book with this ID already exists. Please enter a different ID.");
                    continue;
                }

                break;
            }
            return id;
        }

        private static string GetValidBookTitle()
        {
            string? title;
            while (true)
            {
                Console.Write("Enter book title: ");
                title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Invalid input! Title cannot be empty.");
                    continue;
                }
                break;
            }
            return title;
        }

        private static string GetValidBookAuthor()
        {
            string? author;
            while (true)
            {
                Console.Write("Enter book author: ");
                author = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(author))
                {
                    Console.WriteLine("Invalid input! Author cannot be empty.");
                    continue;
                }
                break;
            }
            return author;
        }

        private static void AddNewBook(Library library)
        {
            int id = GetValidBookId(library, true);
            string title = GetValidBookTitle();
            string author = GetValidBookAuthor();

            Book book = new Book(id, title, author);
            library.AddBook(book);
        }

        private static void BorrowBook(Library library)
        {
            int borrowID = GetValidBookId(library);
            if (!library.BorrowBook(borrowID))
            {
                Console.WriteLine("Unable to borrow book.");
            }
        }

        private static void ReturnBook(Library library)
        {
            int returnID = GetValidBookId(library);
            if (!library.ReturnBook(returnID))
            {
                Console.WriteLine("Unable to return book.");
            }
        }
    }
}



