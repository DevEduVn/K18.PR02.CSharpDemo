using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.SummaryOOPCollections
{
    /// <summary>
    /// Nhân viên chính thức của công ty /  kế thừa từ lớp NhanVien
    /// Bổ sung thêm các thuộc tính: PhuCap, Thuong
    /// 10'
    /// </summary>
    class NhanVienCoHuu:NhanVien
    {
        // Properties
        public double PhuCap { get; set; }
        public double Thuong { get; set; }
        public double BHXH { get; set; }
        // Constructor 
        public NhanVienCoHuu() : base()
        {
        }

        public NhanVienCoHuu(int iD, string hoTen, double luongCB, float heSoLuong, double phuCap, double thuong, double bHXH)
            : base(iD, hoTen,luongCB,heSoLuong)
        {
            PhuCap = phuCap;
            Thuong = thuong;
            BHXH = bHXH;
        }

        // method
        public override void ShowInfo()
        {
            Console.Write("{0,-5} {1,-20} {2, 15} {3,5} {4,10} {5,10} {6,10} {7, 15}",
               ID, HoTen, LuongCB, HeSoLuong, PhuCap, Thuong, BHXH, string.Format("{0:#,##0.00}", TinhLuong()),
               string.Format("{0:#,##0.00}", ThucNhan()));
          
        }
        public new double TinhLuong()
        {
            return LuongCB * HeSoLuong +PhuCap + Thuong + BHXH;
        }

        public double ThucNhan()
        {
            return LuongCB * HeSoLuong + PhuCap + Thuong - BHXH ;
        }
    }
}
