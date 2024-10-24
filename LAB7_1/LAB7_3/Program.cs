namespace LAB7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KHAI BÁO MẢNG
            byte[] a = new byte[5];
            //nhập mảng
            try
            {
                for (int i = 0; i <= 5; i ++) 
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }    
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("khong duoc nhap gia tri nam ngoai mien 0-255");
                
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("LOI VUOT QUA PHAM VI CUA MANG");
            }
            //IN MẢN
            Console.WriteLine("NOI DUNG MANG");
            for (int i = 0; i<5 ; i ++)
                Console.Write(" {0}", a[i]);
        }
    }
}