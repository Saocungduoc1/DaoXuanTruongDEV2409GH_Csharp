namespace LAB4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //Nhập dữ liệu
            rec.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la: {0:N}",rec.Circumference());
            //khởi tạo hình tròn
            Circle cir = new Circle();
            //nhập sữ liệu
            cir.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la: {0:N}",cir.Area());
            Console.WriteLine("Chu vi hinh tron là: {0:N}", cir.Circumference());
        }
    }
}