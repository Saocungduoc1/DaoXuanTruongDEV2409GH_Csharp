using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set;}
        private float studAvgMark;
        public float StudAvgMark
        {
            get { return studAvgMark; }
        }
        //MẢNG LƯU ĐIỂM
        private int[] MarkList = new int[3];

        //phương thức in thông tin
        public void Print()
        {
            Console.WriteLine($"ID: {StudID}, Name: {StudName}, Gender: {StudGender}, Age: {StudAge}, Class: {StudClass}, Avg Mark: {StudAvgMark}");
        }

        //indexxer để truy cập và gán điểm chi mảng marklisst
        public int this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value;}
    }

        //phương thức tính điểm trung bình
        public void CalAvg()
        {
            //kiểm tra xem mảng có rỗng hoặc chưa được khởi tạo đầy đủ
            /* if (MarkList == null || MarkList.Length == 0 || MarkList.All(x => x == 0))
             {
                 Console.WriteLine("Error: Marklist is either empty or contains invalid values."); ;
             }
             else 
             {
                 //sử dụng Average() của LINQ để tính điểm trung bình nếu hợp lệ
                 studAvgMark = (float)MarkList.Average();
             }*/
            studAvgMark = (MarkList[0] + MarkList[1] + MarkList[2]) / 3;
        }
    }
}
