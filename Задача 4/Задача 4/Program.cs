using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double  f, z, a = 0 ,  b = 1 , i = 22;
            double x = i;
            f = 2 * Math.Sin(Math.Abs(2 * x)) * Math.Cos(2 * x) - 11.6 * Math.Sin(x / 0.4 - 1);
            for (x = i; x <= i + 8; x++);
            {
                a += f;

            }
            Console.WriteLine("a=" +a);
            for (x = i; x <= i + 5; x++);
            {
                b *= f;
            }
            Console.WriteLine("b=" + b);
            z = Math.Log(Math.Abs(a + 4 * b));
            Console.WriteLine("z=" + z);
            
        }
    }
}
