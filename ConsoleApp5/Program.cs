using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cc, cn, BMI;
            Console.WriteLine("Nhap chieu cao cc = ");
            cc= float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang cn = ");
            cn= float.Parse(Console.ReadLine());
            BMI = cn / (cc * cc);
            if (BMI < 15)
                Console.WriteLine("Than hinh qua gay");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Than hinh hoi gay");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Than hinh binh thuong");
            else
                Console.WriteLine("Than hinh beo");
            Console.ReadLine();

                    }
    }
}
