namespace lab2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số giây từ người dùng
            Console.Write("Nhap vao so giay: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            // Tính toán giờ, phút, giây
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            // In ra kết quả theo định dạng hh:mm:ss
            Console.WriteLine($"Đinh dang thoi gian: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}