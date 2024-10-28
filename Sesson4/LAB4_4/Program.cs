namespace LAB4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bach khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            IPerson student = new Student()
            {
                Id = "S10",
                Name = "ASC",
                Age = 20
            };
            //Hiểm thị dữ liệu
            student.Display(student);
        }
    }
}