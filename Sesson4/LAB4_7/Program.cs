namespace LAB4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienBanHang nvbh = new NhanVienBanHang();
            Console.WriteLine("Nhan vien ban hang");
            nvbh.HienThi("Truong", "VP");
            Console.WriteLine("Luong: {0}", nvbh.TinhLuong(30, 15));
            CongNhan cn = new CongNhan();
            Console.WriteLine("Cong Nhan");
            cn.HienThi("Anh", "HN");
            Console.WriteLine("Luong: {0}", cn.TinhLuong(12, 45));

            Console.ReadKey();
        }
    }
}