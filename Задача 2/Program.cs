using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 22, y;
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите d");
            double d = double.Parse(Console.ReadLine());
            if ( Math.Abs(x) < 10 )
            {
             y = Math.Tan(x / i + a) - Math.Log(b * i + 7);
            }
            else
            {
                y = c * Math.Pow(Math.Pow(x, 2) + d * Math.Pow(i, 1.2), 1 / i);
            }
            Console.WriteLine("у =" + y);
                    


        }
    }
}
