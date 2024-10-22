public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of books
        List<Book> books = new List<Book>
        {
            new Book(1, "Book One", "Author A", "Publisher X", 2010, 15.50m),
            new Book(2, "Book Two", "Author B", "Publisher Y", 2014, 20.75m),
            new Book(3, "Book Three", "Author A", "Publisher Z", 2014, 22.30m),
            new Book(4, "Book Four", "Author C", "Publisher X", 2012, 18.99m),
            new Book(5, "Book Five", "Author B", "Publisher W", 2014, 25.00m),
            new Book(6, "Book Six", "Author A", "Publisher X", 2015, 19.99m),
            new Book(7, "Book Seven", "Author D", "Publisher Y", 2016, 30.00m),
            new Book(8, "Book Eight", "Author E", "Publisher W", 2018, 24.99m),
            new Book(9, "Book Nine", "Author F", "Publisher Z", 2011, 14.95m),
            new Book(10, "Book Ten", "Author G", "Publisher Nhi Dong", 2014, 10.00m)
        };

        // In danh sách các quyển sách tăng dần theo giá
        Console.WriteLine("Sach tang dan theo gia:");
        var sortedBooks = books.OrderBy(b => b.Price).ToList();
        foreach (var book in sortedBooks)
        {
            Console.WriteLine(book);
        }

        // Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
        Console.WriteLine("\nEnter a book title to search for:");
        string searchTitle = Console.ReadLine();
        var foundBook = books.FirstOrDefault(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
        if (foundBook != null)
        {
            Console.WriteLine($"Found: {foundBook}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        // Đưa ra những quyển sách xuất bản năm 2014
        Console.WriteLine("\nSach xuat ban 2014:");
        var books2014 = books.Where(b => b.Year == 2014).ToList();
        foreach (var book in books2014)
        {
            Console.WriteLine(book);
        }

        // Xóa những quyển sách của nhà xuất bản "Nhi Dong"
        books.RemoveAll(b => b.Publisher.Equals("Nhi Dong", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("\nBooks after removing 'Nhi Dong' publisher:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}