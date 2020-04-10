using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng của lớp
            Student stud = new Student();

            // Truy xuất đến các thuộc tính của đối tượng
            stud.ID = 1012;
            stud.Name = "Dang Quang Nam";
            stud.Mark1 = 10;
            stud.Mark2 = 9;
            stud.Mark3 = 9.5F;

            // Truy cập gọi phương thức
            stud.DisplayInfor();

            // Gọi phương thức trả về giá trị
            float avg = stud.AverageMark();
            Console.WriteLine("Average:" + avg);

            Console.WriteLine("Tổng cộng: " + stud.Add(100, 200));

            // Phương thức không có giá trị trả về xác định
            stud.Add(100, 200, 300);

            Console.ReadKey();
        }
    }

    // Create class Student
    class Student
    {
        // Thuộc tính tự động
        public int ID { get; set; }
        public string Name { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public float Mark3 { get; set; }

        // Tạo các phương thức của lớp Student
        // Phương thức không có tham số, không trả về giá trị xác định
        public void DisplayInfor()
        {
            Console.WriteLine("{0,-5} {1,-15} {2,5} {3,5} {4,5}",
                                ID, Name, Mark1, Mark2, Mark3);
        }
        // Phương thức: -> Trả về giá trị cụ thể / -> Không tham số
        public float AverageMark()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }
        // Phương thức : Có tham số đầu vào
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
        }
    }
}
