namespace lab2_6
{
    internal class Program
    {
        /// <summary>
        /// sử dụng foreach in ra danh sách các phần tử của mảng
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai báo và khởi tạo mảng tên
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sach sinh vien:\n");
            foreach(var n in names)
            {
                Console.WriteLine(n);
            }
          
        }
    }
}