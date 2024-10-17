using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_1
{
    internal class Button:Window
    {
        //phương thức khởi tạo
        public Button(int top,int left)
            : base(top,left)//gọi contructor lớp cơ sở
        { 

        }
        //ghi đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0},{1}\n", top, left);
        }
    }
}
