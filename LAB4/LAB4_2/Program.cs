namespace LAB4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of college:");
            StudentCollege sv1 = new StudentCollege("Hanh", 1888, 9, 8, 7);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());
            //khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("Student of Univercity:");
            StudentUniversity sv2 = new StudentUniversity("Thanh", 1999, 7, 8 , 8, 7);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2 .Average());
        }
    }
}