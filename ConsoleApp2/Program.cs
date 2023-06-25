using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nhap ban kinh R: ");
            R = float.Parse(Console.ReadLine());
            Console.WriteLine("R = " + R);
            C = 2 * pi * R;
            S = pi * R * R;
            Console.WriteLine("Chu vi = {0} ,Dien tich = {1}", C, S);
            Console.ReadKey();

        }
    }
}
