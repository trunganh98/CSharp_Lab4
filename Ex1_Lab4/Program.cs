using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atomic Infomation\n ====================\n");
            Atom a = new Atom();
            a.creatAtom();
            a.GetFullInfor();
            Console.ReadLine();
        }
    }
}
