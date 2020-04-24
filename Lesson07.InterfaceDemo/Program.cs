using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection : List
            IList<NhanVien> lst = new List<NhanVien>();
            lst.Add(new NhanVien(1, "Dang quang nam", 1000, 3.5F));

            lst = new List<NhanVien>()
            {
                new NhanVien(1,"Dang Quang Nam",1000,3.5F),
                new NhanVien(2,"Nguyen Dang Phong",1500,3.5F),
                new NhanVien(3,"Tran The Uy",2000,2.5F),
                new NhanVien(4,"Nguyen Hai Duc",1500,2.5F),
                new NhanVien(5,"Nguyen Van Tien",2000,3.5F),
            };

            // In
            foreach (var item in lst)
            {
                item.ShowInfo();
                Console.WriteLine();
            }

            // Sắp xếp
            var lstSort = lst.OrderBy(x => x.TinhLuong());
            Console.WriteLine("===Sap theo tong luong tăng dan");
            foreach (var item in lstSort)
            {
                item.ShowInfo();
                Console.WriteLine();
            }

            lstSort = lst.OrderByDescending(x => x.TinhLuong());
            Console.WriteLine("===Sap theo tong luong giam dan");
            foreach (var item in lstSort)
            {
                item.ShowInfo();
                Console.WriteLine();
            }

            // Tìm kiếm
            Console.Write("Nhap ten nhan vien can tim");
            string name = Console.ReadLine();
            var lstRes = lst.Where(x => x.HoTen.Contains(name));
            Console.WriteLine("=== Ket qua:");
            foreach (var item in lstRes)
            {
                item.ShowInfo();
                Console.WriteLine();
            }
               
            Console.ReadLine();
        }
    }
}
