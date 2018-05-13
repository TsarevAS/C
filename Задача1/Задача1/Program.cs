using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, S;
            Console.WriteLine("Введите первый катет");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу");
            double c = double.Parse(Console.ReadLine());
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            Console.WriteLine("второй катет = " + b);
            S = 0.5 * (a * b);
            Console.WriteLine("площадь прямоугольного треугольника =" + S);
        }
    }
}
