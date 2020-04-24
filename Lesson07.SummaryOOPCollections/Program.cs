using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.SummaryOOPCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng
            NhanVien nv = new NhanVien(); // Sử dụng constructor không tham số
            // Truy xuất đến thuộc tính
            nv.ID = 101;
            nv.HoTen = "Donal Chung Trinhj";
            nv.LuongCB = 1000000F;
            nv.HeSoLuong = 3.5F;

            // Truy xuất đến phương thức
            nv.ShowInfo(); // Gọi phương thức hiển thị
            Console.WriteLine();
            Console.WriteLine(nv.ToString());

            Console.ReadLine();

            Console.WriteLine("===== Nhân viên cộng tác ===============");
            NhanVienCongTac obj = new NhanVienCongTac(112, "Donal Ngoc Hung", 1500, 50);
            obj.ShowInfo();

            Console.WriteLine("\n" + obj.ToString());

            Console.ReadLine();

            Console.WriteLine("===== Nhân viên cơ hữu ===============");
            NhanVienCoHuu objNVCH = new NhanVienCoHuu(113, "Nguyen Dang Phong", 5000000, 3.5f, 3000000, 1000000, 500000);
            objNVCH.ShowInfo();

            Console.ReadLine();

        }
    }
}
