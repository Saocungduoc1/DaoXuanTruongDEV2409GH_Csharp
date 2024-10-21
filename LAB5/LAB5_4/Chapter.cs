using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_4
{
    internal class Chapter
    {
        private string name;
        private string content;
        //constructor không tham số
        public Chapter() 
        {
            name = "";
            content = "";
        }
        //constructor có tham số
        public Chapter (string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        //định nghĩa các thuộc tính
        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        //ghi đè phương thức tostring
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
