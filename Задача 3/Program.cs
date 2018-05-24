using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите первую букву названия реки");
            char k = char.Parse(Console.ReadLine());
            switch (k )
            {
                case  'a':
                    Console.WriteLine("Страна,в которой протекает река - Россия");
                    break;
                case 'b':
                    Console.WriteLine("Страна,в которой протекает река - США");
                    break;
                case  'c':
                    Console.WriteLine("Страна,в которой протекает река - Индия");
                    break;
                case  'd':
                    Console.WriteLine("Страна,в которой протекает река - Китай");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
