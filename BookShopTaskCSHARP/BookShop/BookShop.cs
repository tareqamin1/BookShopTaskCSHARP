namespace BookShopTaskCSHARP.BookShop
{
    public class BookShop
    {
       
        public List<Book> GetSystemBookList()
        {

            List<Book> Bookshop = new List<Book>
            {
                new Book
                {
                    BookName = "The Great Gatsby",
                    Category = "Fiction",
                    Author = "F.Scott Fitzgerald",
                    IsBorrowed = true

                },
                new Book
                {
                    BookName = "To Kill a Mockingbird",
                    Category = "Fiction",
                    Author = "Harper Lee",
                    IsBorrowed = true
                },
                new Book
                {
                    BookName = "1984",
                    Category = "Dystopian",
                    Author = "George Orwell",
                    IsBorrowed = false
                },
                new Book
                {
                    BookName = "A Brief History of Time",
                    Category = "Science",
                    Author = "Stephen Hawking",
                    IsBorrowed = true
                },
                new Book
                {
                    BookName = "The Catcher in the Rye",
                    Category = "Fiction",
                    Author = "J.D. Salinger",
                    IsBorrowed = true
                }
            };
            return Bookshop;


        }
        public List<Book> GetAdminBooks()
        {
            List<Book> Bookshop = new List<Book>();
            Console.WriteLine("Please Enter The Number of books that you need to Add ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Book book = new Book();
                Console.WriteLine("Enter Book Name");
                book.BookName = Console.ReadLine();
                Console.WriteLine("Please Enter The Author :");
                book.Author = Console.ReadLine();
                Console.WriteLine("Please Enter The Category :");
                book.Category = Console.ReadLine();

                book.IsBorrowed = false;

                Bookshop.Add(book);
            }
            return Bookshop;
        }
    }
}
