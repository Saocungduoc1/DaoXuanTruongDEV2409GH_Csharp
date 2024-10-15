using System.Text;

namespace lab2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                // Nhập vào 3 số a, b, c
                Console.Write("Nhập vào cạnh a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Nhập vào cạnh b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Nhập vào cạnh c: ");
                double c = double.Parse(Console.ReadLine());

                // Kiểm tra điều kiện tam giác
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Tam giác đều
                    if (a == b && b == c)
                    {
                        Console.WriteLine("Đây là tam giác đều.");
                    }
                    // Tam giác cân
                    else if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Đây là tam giác cân.");
                    }
                    // Tam giác vuông
                    else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        Console.WriteLine("Đây là tam giác vuông.");
                    }
                    // Tam giác thường
                    else
                    {
                        Console.WriteLine("Đây là tam giác thường.");
                    }
                }
                else
                {
                    Console.WriteLine("a, b, c không tạo thành ba cạnh của một tam giác.");
                }
            }
        }
    }
}