using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, s, p;
            Console.WriteLine("nhap chieu dai a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap chieu rong b: ");
            b = float.Parse(Console.ReadLine());
            s = a * b;
            p = (a + b) * 2;
            Console.WriteLine("dien tich la {0}, chu vi la {1}", s, p);
            Console.ReadLine();

        }
    }
}
