using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Hoang", "Nam", "HN", 12, 123.111);

            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }
}
