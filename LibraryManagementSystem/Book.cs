namespace LibraryManagementSystem

{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title, string author, bool isBorrowed)
        {
            ID = id;
            Title = title;
            Author = author;
            IsBorrowed = isBorrowed;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Title: {Title}, Author: {Author}, IsBorrowed: {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }

}