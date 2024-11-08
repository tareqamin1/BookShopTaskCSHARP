//using Classes and IF statement and For loops
//do the following :
//نظام مكتبة
//قمت باضافة Class Book  ( BookName, Category, Author, IsBorrowed)

//قم بانشاء List<Book> واضف فيها مجموعة من المعلومات بشكل ثابت
//واجعل المستخدم يقوم بادخال مجموعة اخرى من الكتب

//المطلوب :
//1.قم بطباعة جميع الكتب بشكل مرتب
//2.  اجعل المستخدم يقوم بعملية بحث عن اسم الكتاب معين ضمن الكتب المتاحة للاستعارة واظهر له نتيجة البحث
//3. اجعل المستخدم بقوم باستعارة كتاب معين
//4. اجعل المستخدم بقوم باسترجاع كتاب تم استعارته
//5. اظهر للمستخدم جميع الكتب غير المستعارة
//6. اظهر للمستخدم إحصائية بمعدل الكتب التي تمت استعارتها



using System.Collections.Generic;

namespace BookShopTaskCSHARP.BookShop;

class Program
{
    public static void Main(string[] args)
    {
        string UserName = "tareq";
        string PassWord = "Tareq123@";
        Console.WriteLine("Please Enter Your UserName :");
        string LoginUserName = Console.ReadLine();
        Console.WriteLine("Please Enter Your Password :");
        string LoignPassword = Console.ReadLine();
        BookShop BookShop = new BookShop();
        if (LoginUserName == UserName && LoignPassword == PassWord)
        {
            List<Book> books = new List<Book>();

            List<Book> SystemBooks = BookShop.GetSystemBookList();
            books.AddRange(SystemBooks);

            ReadBooks(books);

            List<Book> adminBooks = BookShop.GetAdminBooks();
            books.AddRange(adminBooks);

            ReadBooks(books);

            bool IsAnyBookAvailable = true;
            while (IsAnyBookAvailable)
            {
                Console.WriteLine("Write The Book Name You Want To Borrow :");
                string BookName = Console.ReadLine();
                foreach (var item in books)
                {
                    if (BookName == item.BookName)
                    {
                        if (item.IsBorrowed)
                        {
                            Console.WriteLine("This Book Is Borrowed");
                        }
                        else
                        {
                            Console.WriteLine($"You've Borrowed The Book {BookName}!");

                            item.IsBorrowed = true;
                        }



                        break;
                    }
                }
                ReadAvailableBooks(books);
                ReadBorrowedBooks(books);
                IsAnyBookAvailable = IsAnyBookAvailabe(books);
            }
            bool IsAnyBookBorrowed = true;
            while (IsAnyBookBorrowed)
            {
                Console.WriteLine("Write The Book Name You Want To Return :");
                string BookName = Console.ReadLine();
                foreach (var item in books)
                {
                    if (BookName == item.BookName)
                    {
                        if (item.IsBorrowed)
                        {
                            Console.WriteLine($"You've Returned The Book {BookName}!");

                            item.IsBorrowed = false;
                        }
                        else
                        {
                            Console.WriteLine(" This book is already Available");
                        }
                        break;
                    }
                }
                ReadAvailableBooks(books);
                ReadBorrowedBooks(books);
                IsAnyBookBorrowed = IsAnyBookBorowed(books);
            }
            ReadBooks(books);
        }
        else
        {
            Console.WriteLine("Invalid UserName or Password!");
        }
    }
    public static void ReadBooks(List<Book> books)
    {
        Console.WriteLine("All Books :");
        foreach (Book book in books)
        {
            Console.WriteLine($" This Is The Book Name :{book.BookName}");
            Console.WriteLine($" This Is The Book Category :{book.Category}");
            Console.WriteLine($" This Is The Book Author :{book.Author}");
            if (book.IsBorrowed)
            {
                Console.WriteLine($" This book Is Borrowed!");
            }
            else
            {
                Console.WriteLine($" This book Is Available!");
            }
            Console.WriteLine("");
        }
    }
    public static void ReadAvailableBooks(List<Book> books)
    {
        Console.WriteLine("Availabe Books");
        foreach (Book book in books)
        {

            if (!book.IsBorrowed)
            {
                Console.WriteLine($" This Is The Book Name :{book.BookName}");
                Console.WriteLine($" This Is The Book Category :{book.Category}");
                Console.WriteLine($" This Is The Book Author :{book.Author}");
                Console.WriteLine("");
            }

        }
    }
    public static void ReadBorrowedBooks(List<Book> books)
    {
        Console.WriteLine("Borrowed Books");
        foreach (Book book in books)
        {

            if (book.IsBorrowed)
            {
                Console.WriteLine($" This Is The Book Name :{book.BookName}");
                Console.WriteLine($" This Is The Book Category :{book.Category}");
                Console.WriteLine($" This Is The Book Author :{book.Author}");
                Console.WriteLine("");
            }

        }
    }
    public static bool IsAnyBookAvailabe(List<Book> books)
    {
        foreach (Book book in books)
        {
            if (book.IsBorrowed == false)
            {
                return true;
            }
        }
        return false;


    }
    public static bool IsAnyBookBorowed(List<Book> books)
    {
        foreach (Book book in books)
        {
            if (book.IsBorrowed == true)
            {
                return true;
            }
        }
        return false;


    }
}







