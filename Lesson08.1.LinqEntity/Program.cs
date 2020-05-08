using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._1.LinqEntity
{
    /// <summary>
    /// Linq to Entity
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListEmployee = new List<Employee>
            {
               new Employee(){ID=100,Name="Hoang ha",Age=20},
               new Employee(){ID=102,Name="Hoang Anh",Age=25},
               new Employee(){ID=104,Name="Hoang Em",Age=22},
               new Employee(){ID=105,Name="Hoang Chu",Age=32},
               new Employee(){ID=107,Name="Hoang Chi",Age=40},
               new Employee(){ID=108,Name="Hoang Ong",Age=90}
            };

            Console.WriteLine("Danh sach nhan vien");
            foreach (var item in ListEmployee)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //Liệt kê nhân viên có tuổi lớn hơn 30
            Console.WriteLine("Danh sach nhan vien co tuoi >30");
            var lst = ListEmployee.Where(e => e.Age > 30);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // Sắp xếp nhân viên theo tuổi giảm dần
            Console.WriteLine(" Sắp xếp nhân viên theo tuổi giảm dần");
            lst = ListEmployee.OrderByDescending(x => x.Age);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // Lọc những nhân viên có tên kết thúc  bằng h
            Console.WriteLine("Lọc những nhân viên có tên kết thúc  bằng h");
            lst = ListEmployee.Where(x => x.Name.EndsWith("h"));
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // lấy ra 3 bản ghi đầu tiên lớn nhất theo tuổi
            lst = ListEmployee.OrderByDescending(x => x.Age).Take(3);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            lst = ListEmployee.OrderByDescending(x => x.Age).Skip(3).Take(2);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        // properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("\t{0,-10}{1,-20}{2,10}", ID, Name, Age);
        }
    }
}
