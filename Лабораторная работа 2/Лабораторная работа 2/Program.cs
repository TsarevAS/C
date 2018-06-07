using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_2
{
    class Program
    {

        static void Main()
        {
            double m = 0;
            double[,] arr2 = new double[4,2] { { 8, 2 }, { 7, 4 }, { 5, 6 }, { 1, 8 } };// Можно ввести массив вида [x,2]
            try
            {
                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    for (int j = i + 1; j < arr2.GetLength(0); j++)
                    {
                        double z = Rasstoyanie.Distance(arr2[i, 0], arr2[i, 1], arr2[j, 0], arr2[j, 1]);
                        Console.WriteLine("Distance between Point1({0},{1}) and Point2({2},{3}) = {4}", arr2[i, 0], arr2[i, 1], arr2[j, 0], arr2[j, 1], z);
                        if (m < z)
                        {
                            m = z;
                        }
                    }
                }
                Console.WriteLine( "The maximum range = {0}", m);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
    class Rasstoyanie
        {
            static public double Distance(Double x1, Double y1, Double x2, Double y2)
            {
                Double dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return (dis);
            }
        }
    }












