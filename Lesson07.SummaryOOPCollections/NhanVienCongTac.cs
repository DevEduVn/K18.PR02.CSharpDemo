using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.SummaryOOPCollections
{
    /// <summary>
    /// Nhân viên cộng tác  / thời vụ làm theo giờ
    /// </summary>
    class NhanVienCongTac:NhanVien
    {
        
        // Properties
        public float SoGioLamViec { get; set; }

        // Constructor 
        public NhanVienCongTac():base()
        {
        }

        public NhanVienCongTac(int iD, string hoTen, double luongCB, float soGioLamViec)
            :base(iD,hoTen,luongCB)
        {
            SoGioLamViec = soGioLamViec;
        }

        // method
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("{0,5} {1,15}",SoGioLamViec, string.Format("{0:#,##0.00}", TinhLuong()));
        }
        public new double TinhLuong()
        {
            return LuongCB*SoGioLamViec;
        }
    }
}
