using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tạo namespace kinh doanh
namespace Business
{
    //lớp ở nhà
    public class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }
    //tạo namespace con đại lí lồng bên trong namespace kinh doanh
    namespace Dealership
    {
        //tạo lớp xe
        public class car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; }
        }
    }
}