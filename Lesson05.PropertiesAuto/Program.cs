using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.PropertiesAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng Product
            Product p = new Product();

            // Giá giá trị cho các thuộc tính
            Console.Write("Input ID =");
            p.ID = int.Parse(Console.ReadLine());
            Console.Write("Input name=");
            p.Name = Console.ReadLine();
            Console.Write("Input quantity=");
            p.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Input price=");
            p.Price = double.Parse(Console.ReadLine());

            // Xuất thông tin
            Console.WriteLine("\t ID\t:" + p.ID);
            Console.WriteLine("\t Name\t:" + p.Name);
            Console.WriteLine("\t Qty\t:" + p.Quantity);
            Console.WriteLine("\t Price\t:" + p.Price);

            Console.ReadKey();
        }
    }

    // Class Production
    class Product
    {
        // Tạo thuộc tính tự động cho đối tượng
        public int ID { get; set; } // Thuộc tính đọc / ghi
        public string Name { get; set; } // Thuộc tính đọc / ghi
        public int Quantity { get; set; } // Thuộc tính đọc / ghi
        public double Price { get; set; } // Thuộc tính đọc / ghi

        //public int Quantity { private get; set; } // Thuộc tính chỉ ghi
        //public double Price { get; private set; } // Thuộc tính chỉ đọc

    }
}
