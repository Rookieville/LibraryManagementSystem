using System;

namespace LibraryManagementSystem
{
    public class Program
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
                        Console.Write("\nEnter book id:");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter book title:");
                        string title = Console.ReadLine();

                        Console.Write("Enter book author:");
                        string author = Console.ReadLine();

                        Book newBook = new Book(id, title, author);
                        library.AddBook(newBook);
                        Console.WriteLine("\nBook added successfully!");
                        break;

                    case 2:
                        library.ViewBooks();
                        break;

                    case 3:
                        Console.Write("\nEnter book ID to borrow: ");
                        int borrowID = int.Parse(Console.ReadLine());
                        library.BorrowBook(borrowID);
                        break;

                    case 4:
                        Console.Write("\nEnter book ID to return: ");
                        int returnID = int.Parse(Console.ReadLine());
                        library.ReturnBook(returnID);
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
    }
}
