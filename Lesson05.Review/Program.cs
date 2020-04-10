using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng từ lớp Category
            Category cat = new Category();

            // Thực hiện gọi phương thức showInfor
            cat.ShowInfor();

            // Truy xuất đến thuộc tính
            cat.ID = 100;
            cat.Name = "Corona";

            cat.ShowInfor();

            Console.ReadKey();
        }
    }

    class Category
    {
        // Field: [Các trường lưu trữ dữ liệu của đối tượng]
        private int _id;
        private string _Name;

        // Properties: [Các thuộc tính  của đối tượng]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        // Method: [Các hoạt động của đối tượng]
        public void ShowInfor()
        {
            Console.WriteLine("ID \t:" + ID);
            Console.WriteLine("Name\t:" + Name);
            Console.WriteLine("____________________________");

        }
    }
}
