using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_5
{
    internal class Employee
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salarylevel { get; set; }
        public double basicSalary { get; set; }

        public double GetInCome()
        {
            double InCome = (salarylevel + basicSalary);
            return InCome;
        }
        public void Display()
        {
            Console.WriteLine("Dinh danh" + id);
            Console.WriteLine("Ten" + name);
            Console.WriteLine("Nam sinh" + yearOfBirth);
            Console.WriteLine("Luong co ban" + basicSalary);
        }
    }
}
