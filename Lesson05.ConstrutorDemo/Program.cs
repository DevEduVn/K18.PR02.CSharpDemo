using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.ConstrutorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng nhân viên (Sử dụng hàm tạo không tham số)
            Employees emp = new Employees();
            emp.DisplayInfo();

            // Khởi tạo đối tượng nhân viên (Sử dụng hàm tạo có tham số)
            emp = new Employees(1010, "Chung Trinhj", 12345);
            emp.DisplayInfo();

            Console.ReadKey();
        }
    }

    // Create class Employee
    class Employees
    {
        // Thuộc tính động (ID, Name, Salary)
        public int ID { get; set; }
        public string  Name { get; set; }
        public double Salary { get; set; }
        // Constructor - non parameter
        public Employees() { }
        // Constructor parameter
        public Employees(int ID, string Name, double _Salary)
        {
            this.ID = ID;
            this.Name = Name;
            Salary = _Salary;
        }

        // Method: DisplayInfo()
        public void DisplayInfo()
        {
            Console.WriteLine("\t ID \t:"+ID);
            Console.WriteLine("\t Name \t:" + Name);
            Console.WriteLine("\t Salary\t:" + Salary);
        }
    }
}
