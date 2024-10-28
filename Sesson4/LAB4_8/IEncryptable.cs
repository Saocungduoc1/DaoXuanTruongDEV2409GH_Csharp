using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_8
{
    internal interface IEncryptable
    {
        string Encrypt();//phương thức mã hóa
        string Decrypt();//phương thức giải 
    }
}
