using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.SummaryOOPCollections
{
    /// <summary>
    /// Lớp base class
    /// </summary>
    class NhanVien
    {
        
        // Properties
        public int ID { get; set; }
        public string HoTen { get; set; }
        public double LuongCB { get; set; }
        public float HeSoLuong { get; set; }
        // Constructor
        public NhanVien()
        {
        }

        public NhanVien(int iD, string hoTen, double luongCB, float heSoLuong)
        {
            ID = iD;
            HoTen = hoTen;
            LuongCB = luongCB;
            HeSoLuong = heSoLuong;
        }
        public NhanVien(int iD, string hoTen, double luongCB)
        {
            ID = iD;
            HoTen = hoTen;
            LuongCB = luongCB;
        }
        // Method
        public virtual void ShowInfo()
        {
            Console.Write("{0,-5} {1,-20} {2, 15} {3,5} {4, 15}", 
                ID,HoTen,LuongCB,HeSoLuong, string.Format("{0:#,##0.00}",TinhLuong()));
        }
        public virtual double TinhLuong()
        {
            return LuongCB * HeSoLuong;
        }
        // Override
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-20} {2, 15} {3,5} {4, 15}",
                ID, HoTen, LuongCB, HeSoLuong, string.Format("{0:#,##0.00}", TinhLuong()));
        }

    }
}
