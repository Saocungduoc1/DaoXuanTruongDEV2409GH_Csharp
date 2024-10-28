namespace lab2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name, address;
            double mark1, mark2, average;
            DateTime birthday;
            Console.Write("Nhap ma so: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Dia chi: ");
            address = Console.ReadLine();
            Console.Write("Ngay sinh : ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Luong: ");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thuong luong: ");
            mark2 = Convert.ToDouble(Console.ReadLine());
            

            average = mark1+ mark2;

            Console.WriteLine("\n Thong tin nhan vien");
            Console.WriteLine("Ma so:{0}", id);
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("Dia chi:{0}", address);
            Console.WriteLine("Ngày sinh: {0:dd/MM/yyyy}", birthday);

            Console.WriteLine("Luong: {0:N}, Thuong luong:{1:N}", mark1, mark2);

            Console.WriteLine("luong nhan ve: {0:N}", average);


        }
    }
}