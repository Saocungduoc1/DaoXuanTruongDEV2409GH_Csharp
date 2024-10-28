namespace LAB3_4
{
    internal class Program
    {
        /// <summary>
        /// CHƯƠNG TRÌNH MINH HỌA VIỆC SỬ DỤNG TỪ KHÓA REF VÀ OUT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Truoc khi hoan vi a={0},b={1}", a, b);
            u.SwapFake(a, b);
            Console.WriteLine("sau khi hoan vi dang fake a={0},b={1}",a,b); u.SwapFake(a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("sau khi hoan vi dang really a={0},b={1}", a, b);
            u.ArreaCircle(100, out area);
            Console.WriteLine("chu vi honh tron ban kinh 100 la: {0}", area);
        }
    }
}