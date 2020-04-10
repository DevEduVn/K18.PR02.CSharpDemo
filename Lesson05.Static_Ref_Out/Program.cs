using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.Static_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // gọi thực hiện với biến tĩnh, phương thức tính
            Console.WriteLine("PI: " + Number.PI);
            Console.WriteLine("Name: " + Number.NameCorp);
            //Console.WriteLine("Add: " + Number.Address); => Lỗi
            int a = 150, b = 250;
            Console.WriteLine("Truoc Swap \t: a = {0}; b = {1}", a, b);
            Number.Swap(a, b);
            Console.WriteLine("Truoc Swap \t: a = {0}; b = {1}", a, b);
            Console.WriteLine("==================================");
            // Gọi phương thức tĩnh với tham số ref
            Console.WriteLine("Truoc Swap \t: a = {0}; b = {1}", a, b);
            Number.Swap(ref a, ref b);
            Console.WriteLine("Truoc Swap \t: a = {0}; b = {1}", a, b);

            // Gọi phương thức tĩnh với tham số out
            double ChuVI, BanKinh = 115;
           // Console.WriteLine("Chu vi:" + ChuVI);

            Number.Area(out ChuVI, BanKinh);
            Console.WriteLine("Chu vi:" + ChuVI);

            Console.ReadKey();
        }
    }

    class Number
    {
        // Biến tĩnh - static
        public static double PI = 3.14;
        public static string NameCorp = "HPC_";
        // non - static
        public string Address = "123 My Dinh";

        // static method
        public static void Swap(int a, int b)
        {
            int temp = a; a = b; b = temp;
        }
        // static method / ref
        public static void Swap(ref int a,ref int b)
        {
            int temp = a; a = b; b = temp;
        }

        // static method / out
        public static void Area(out double area, double r)
        {
            area = 2 * PI * r; 
        }
    }
}
