//sử dụng namespace
using Store;
namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Test";
            dealer.Email = "Test1";
            dealer.Phone = "1234567890";
            //in thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " +  dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);
            //tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();
            //gán giá trị
            si.ItemNo = 678878;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #:     ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name:   ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price:  ");
            Console.WriteLine(si.Price);
            Console.Read();
        }
    }
}