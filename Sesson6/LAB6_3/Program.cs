namespace LAB6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo và khởi tạo danh sách sinh viên sử dụng list generic
            List<Student> list = new List<Student>()
            {
                new Student{Id="S10",FirstName="Nguyen Thu",LastName="Phuong",Avg=9.5},
                new Student{Id="S11",FirstName="Tran Thi",LastName="Trang",Avg=9},
                new Student{Id="S12",FirstName="Nguyen Van",LastName="Phuc",Avg=5},
                new Student{Id="S13",FirstName="Pham Thi",LastName="Mai",Avg=7.5},
                new Student{Id="S14",FirstName="Tran Phuong",LastName="Thao",Avg=4.5},
                new Student{Id="S15",FirstName="Dang Thi",LastName="Tuyet",Avg=8.5},
                new Student{Id="S16",FirstName="Vu Mai",LastName="Anh",Avg=9.5},
            };
            //in ra danh sách sinh viên
            Console.Write("Danh sach sinh vien: ");
            foreach (var st in list)
            {
                Console.Write(st);
            }
            //tìm sinh viên có điểm trung bình cai nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if(st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }
            //in kết quả
            Console.Write("\nSinh vien co diem cao nhat la:");
            Console.Write(stmax);
        }
    }
}