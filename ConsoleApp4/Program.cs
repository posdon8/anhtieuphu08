using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,x,y;
            Console.WriteLine("nhap vao tong a= ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao hieu b= ");
            b = float.Parse(Console.ReadLine());
            x = (a + b)/2;
            y = (a - b) / 2;
            Console.WriteLine(" gia tri x la " + x);
            Console.WriteLine(" gia tri y la " + y);
            Console.ReadKey();
        }
    }
}
