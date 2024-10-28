namespace EX3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book b1 = new Book();
            Book b2 = new Book("Đào Xuân Trường", 10, "VN", "Mắt Biếc", 50);
            b1.Display();
            b2.Display();

            b1.flipPageForWard();
            b2.flipPageBackWard();
            Console.ReadKey();
        }
    }
}