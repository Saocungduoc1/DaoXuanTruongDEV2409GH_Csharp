using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Hashtable studentTable = new Hashtable(); //lưu sinh viên
            int option;

            do
            {
                Console.WriteLine("===============================");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Thêm mới sinh viên.");
                Console.WriteLine("2. Hiển thị danh sách sinh viên.");
                Console.WriteLine("3. Tính điểm trung bình.");
                Console.WriteLine("4. Thoát.");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        InsertStudent(studentTable);
                        break;
                    case 2:
                        DisplayStudents(studentTable);
                        break;
                    case 3:
                        CalculateAvgMarks(studentTable);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (option != 4);
        }

        //hàm thêm sinh viên
        static void InsertStudent(Hashtable studentTable)
        {
            Student student = new Student();
            Console.Write("Mã sinh viên: ");
            student.StudID = int.Parse(Console.ReadLine());

            Console.Write("Tên sinh viên: ");
            student.StudName = Console.ReadLine();

            Console.Write("Giới tính: ");
            student.StudGender = Console.ReadLine();

            Console.Write("Tuổi: ");
            student.StudAge = int.Parse(Console.ReadLine());

            Console.Write("Lớp: ");
            student.StudClass = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Môn thứ {i + 1}: ");
                student[i] = int.Parse(Console.ReadLine()) ;
            }

            student.CalAvg(); // tính điểm trung bình
            studentTable.Add(student.StudID, student); 
        }

        static void DisplayStudents(Hashtable studentTable)
        {
            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.Print();
            }
        }

        static void CalculateAvgMarks(Hashtable studentTable)
        {
            foreach (Student student in studentTable.Values)
            {
                Console.WriteLine("Mark: {0:N2}", student.StudAvgMark);
                Console.WriteLine();
            }
        }
    }
}