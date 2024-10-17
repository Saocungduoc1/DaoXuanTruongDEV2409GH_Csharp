using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.id = 1;
            e.name = "test";
            e.salarylevel = 50;
            e.basicSalary = 300;
            e.Display();
            double Income = e.GetInCome();
            Console.WriteLine("Thu nhập:{0}",Income);
            Console.ReadKey();
        }
    }
}