namespace lab3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soDong = 10;
            for (int i = 1; i < soDong; i++)
            {
                Console.Write(new string(' ',(soDong-i)));
                int num = i;
                for(int j = 1; j <= i; j++) 
                {
                    Console.Write(num % 10);
                    num++;
                }
                num -= 2;
                for (int j = 1; j < i; j++)
                {
                    Console.Write(num%10);
                    num--;
                } 
                Console.WriteLine();
            }
        }
    }
}