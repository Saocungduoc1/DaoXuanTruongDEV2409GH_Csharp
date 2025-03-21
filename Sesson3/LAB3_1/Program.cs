﻿namespace LAB3_1
{
    internal class Program
    {
        /// <summary>
        /// minh họa việc khởi tạo đối tượng, truy cập các trường và phuong thức
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // tạo đối tượng car
            Car myCar = new Car();
            //gán giá trị cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 2002;

            //hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Thong tin chi tiet:");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " + myCar.year);
            //gọi các phương thức
            myCar.Start();
            myCar.Stop();
        }
    }
}