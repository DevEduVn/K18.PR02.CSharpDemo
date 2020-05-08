using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._0.LinqDemo
{
    /// <summary>
    /// Linq to Object 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] Thu = 
                { "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Chu nhat" };

            Console.WriteLine("Cac thu trong tuan");
            foreach (var item in Thu)
            {
                Console.WriteLine(item);
            }

            
            Console.ReadLine();
            // Sử dụng linq để đọc các thứ trong tuần
            IEnumerable<string> lst = from x in Thu
                                      select x;
            Console.WriteLine("Cac thu trong tuan Linq");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //Sư dụng linq để sắp xếp
            lst = from x in Thu
                  orderby x ascending
                  select x;
            Console.WriteLine("Cac thu trong tuan Linq =>Sắp xếp");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            // Điều kiện (lọc)
            lst = from y in Thu
                  where y.Contains("t")
                  select y;
            Console.WriteLine("Cac thu trong tuan Linq =>loc du lieu co chua ky tu t");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // linq extension
           
            Console.WriteLine("Cac thu trong tuan Linq =>loc du lieu co chua ky tu B");
            lst = Thu.Where(x => x.Contains("B"));
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
