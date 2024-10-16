using System.ComponentModel.DataAnnotations;

namespace LAB3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.FirstName = "Nguyen Thi";
            ct1.LastName = "Hoa";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0333333333";
            ct1.Email = "hoahoet@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5,"Nguyen Thi", "Trang", "Tuyen Quang", "0325654125", "trangnguyenthi11@gmail.com");
            //hiển thị thông tin ct1,ct2
            ct1.Display();
            ct2.Display();
        }
    }
}