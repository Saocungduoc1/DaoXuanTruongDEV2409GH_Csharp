namespace LAB4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);
            // in ra số tiền trong tài khoản
            Console.WriteLine("SO TIEN TRONG TAI KHOAN: " + account.GetBalance());
            // nạp thêm 500 vào tài khoản
            account.Deposit(500);
            // in số tiền trong tài khoản sau khi nạp
            Console.WriteLine("SO TIEN TRONG TAI KHOAN SAU KHI NAP:" + account.GetBalance());
            // Rút 300 từ tài khoản
            account.WithDraw(300);
            // In ra số tiền trong tài khoản sau khi rút
            Console.WriteLine("SO TIEN TRONG TAI KHOAN SAU KHI RUT:" + account.GetBalance());
            Console.ReadKey();
        }

    }
}