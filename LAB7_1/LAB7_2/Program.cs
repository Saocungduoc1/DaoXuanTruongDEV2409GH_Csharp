namespace LAB7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo mới đối tượng House trong namespace Business
            //bạn có thể usingowr trên đầu tệp tin để viết ngắn gọn hơn
            Business.House h = new Business.House();
            //gán thông tin
            h.HouseNo = "D294FF";
            h.Price = 525333;
            //in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
            //tạo mới đối tượng car trong namespace Business.Dealership
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.car c = new Business.Dealership.car();
            c.CarNo = "A099999";
            c.Price = 25332.84M;
            //in thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
        }
    }
}