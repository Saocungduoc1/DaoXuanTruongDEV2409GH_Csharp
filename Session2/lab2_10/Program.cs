namespace lab2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Duyệt qua các số từ 100 đến 999
            for (int i = 100; i <= 999; i++)
            {
                // Lấy hàng trăm, hàng chục, và hàng đơn vị
                int hundreds = i / 100;      // Lấy chữ số hàng trăm
                int tens = (i / 10) % 10;    // Lấy chữ số hàng chục
                int units = i % 10;          // Lấy chữ số hàng đơn vị

                // Tính tổng của ba chữ số
                int sum = hundreds + tens + units;

                // Kiểm tra tổng có phải là số chẵn không
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i); // In ra số nếu tổng là chẵn
                }
            }
        }
    }
}