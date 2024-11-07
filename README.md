# Library Management Console

This is a console application that manages a simple library system, designed to allow users to add, view, borrow, and return books. The application is built with C#, focusing on object-oriented programming, condition statements, and loops.

## Objective

The goal of this project is to create a console-based Library Management System that demonstrates your understanding of fundamental programming concepts in C#. It involves building classes, creating user interactions through a menu system, and implementing program logic to handle various operations on books.

---

## Features

1. **Add a Book**: Allows users to add a new book to the library.
2. **View Books**: Displays all the books available in the library, including their availability status.
3. **Borrow a Book**: Marks a book as borrowed if it is available.
4. **Return a Book**: Marks a book as returned if it was previously borrowed.
5. **Exit**: Exits the application.

---

## Requirements

### Classes and Objects

1. **Book Class**
   - Properties:
     - `ID` (int): Unique identifier for each book.
     - `Title` (string): Title of the book.
     - `Author` (string): Author of the book.
     - `IsBorrowed` (bool): Tracks if the book is currently borrowed.
   
2. **Library Class**
   - Methods:
     - `AddBook(Book book)`: Adds a new book to the library's collection.
     - `ViewBooks()`: Displays a list of all books in the library, along with their status (available/borrowed).
     - `BorrowBook(int id)`: Allows a user to borrow a book if it is not already borrowed.
     - `ReturnBook(int id)`: Allows a user to return a borrowed book.

---

## Program Flow

1. **Main Menu**: The application displays a main menu to guide users through the available options.
2. **Loops**: A loop is used to keep the program running until the user decides to exit.
3. **Condition Statements**: Conditional statements handle user input validation, manage program flow, and provide feedback for successful or failed operations.

---

## Example Usage

Below is an example interaction with the Library Management Console application:

```plaintext
Welcome to the Library Management System
1. Add a new book
2. View all books
3. Borrow a book
4. Return a book
5. Exit

Select an option: 1
Enter book ID: 1
Enter book title: The Great Gatsby
Enter book author: F. Scott Fitzgerald
Book added successfully!

Select an option: 2
Books in the library:
ID: 1, Title: The Great Gatsby, Author: F. Scott Fitzgerald, Status: Available

Select an option: 3
Enter book ID to borrow: 1
Book borrowed successfully!

Select an option: 2
Books in the library:
ID: 1, Title: The Great Gatsby, Author: F. Scott Fitzgerald, Status: Borrowed

Select an option: 4
Enter book ID to return: 1
Book returned successfully!
```
---

## How to Run
1. Clone the repository or download the source files.
2. Open the project in an IDE that supports C# (e.g., Visual Studio).
3. Build and run the project.
4. Follow the on-screen prompts to interact with the Library Management Console.
