namespace LAB5_1
{
    internal class Program
    {
        /// <summary>
        /// MỘT SỐ THAO TÁC VỚI MẢNG 1 CHIỀU
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //KHAI BÁO VÀ KHỞI TẠO MẢNG 1 CHIỀU
            int[] m = { 5,3,8,3,0,2,1,7,8 };
            //duyệt mảng và in dữ liệu
            Console.Write("Cac phan tu cua mang: ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0}", m[i]);
            }
            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhan tu lon nhat:" + max);
            //kiểm tra mảng có đối xứng không?
            bool kt = true;
            for(int i = 0;i < m.Length / 2; i++)
            {
                if (m[i] !=m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
    }
}