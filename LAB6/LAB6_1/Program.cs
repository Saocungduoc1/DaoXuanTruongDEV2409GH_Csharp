using System.Collections;

namespace LAB6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo ArrayList
            ArrayList inv = new ArrayList();
            //thêm phần tử vào danh sách
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 7.2, 8));
            inv.Add(new Product("B", 8.8, 4));
            //IN RA DANH SÁCH CÁC PHẦN TỬ
            Console.WriteLine("Product list: ");
            foreach (Product i in inv)
            {
                Console.WriteLine("  " + i);
            }

        }
    }
}