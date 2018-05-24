using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3_if_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую букву названия реки");
            char k = char.Parse(Console.ReadLine());
            if (k =='a')
                Console.WriteLine("Страна, где протекает река - Россия");
            else if ( k=='b')
                Console.WriteLine("Страна, где протекает река - США");
            else if (k=='c')
                Console.WriteLine("Страна, где протекает река - Индия");
            else if (k=='d')
                Console.WriteLine("Страна, где протекает река - Китай");
            else
                Console.WriteLine("Ошибка");

        }
    }
}
