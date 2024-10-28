using System.Runtime.InteropServices;

namespace LAB2_8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Nhập năm và tháng
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());

            // Xác định số ngày trong tháng của năm đó
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // In kết quả ra màn hình
            Console.WriteLine($"Số ngày trong tháng {month} năm {year} là: {daysInMonth}");

        }
    }
}