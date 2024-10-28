using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_8
{
    internal interface IStoreable
    {
        string Data { get; set; }
        void Write(string fileName);
        void Read(string fileName);
    }
}
