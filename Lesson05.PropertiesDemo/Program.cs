using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();
            emp.ID = 1111;
            // emp.Name = "Chung Trinhj"; //=> thuộc tinh chỉ đọc
            emp.Salary = 10000;

            //In
            Console.WriteLine(emp.ID);
            Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.Salary); // Lỗi: thuộc tính chỉ ghi

            Console.ReadKey();
        }
    }

    class Employees
    {
        // Field
        private int _id;
        private string _FullName ="Administrator";
        private double _Salary;

        // Properties (Tạo các thuộc tính)
        public int ID //Thuộc tính đầy đủ
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name //Thuộc tính chỉ đọc
        {
            get { return _FullName; }
        }
        public double Salary //Thuộc tính chỉ ghi
        {
            set { _Salary = value; }
        }

    }
}
