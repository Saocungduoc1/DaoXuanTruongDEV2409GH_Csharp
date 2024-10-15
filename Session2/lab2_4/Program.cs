namespace lab2_4
{
    internal class Program
    {
        /// <summary>
        /// chương trình in ra các số nguyên tố từ 2-100
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai báo biến đánh dấu
            bool check_i;
            Console.Write("Danh sach cac so nguyen to tu 2-100: ");
            //duyệt từ 2-100
            for(int i = 2; i <= 100; i++)
            {
                check_i = true; //giả sử i là số nguyên tố
                for (int j = 2; j <= i / 2; j++) //duyệt từ 2-j/2
                {
                    if (i % j == 0)//nếu i chia hết cho j thì
                    {
                        check_i=false;//kết luận không là số nguyên tố
                        break;//thoát khỏi vòng lặp hiện tại
                    }    
                }  
                if(check_i)//nếu giả sử vấn đúng -> i là số nguyên tố
                    Console.Write(" {0}",i);
                    
            }


        }
    }
}