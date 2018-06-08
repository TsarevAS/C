using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа___3
{
    class DecCounter
    {
        int CurrentSt;
        int Upper;
        int Bottom;

        public DecCounter()
        {
            this.CurrentSt = 0x5;
            this.Bottom = 0x2;
            this.Upper = 0x11;
        }
        public DecCounter(int x, int MinValue, int MaxValue)
        {
            int T = Math.Min(MinValue, MaxValue);
            if (T != MinValue)
            {
                MaxValue = MinValue;
                MinValue = T;
            }
            if (x < MinValue || x > MaxValue)
            {
                this.CurrentSt = MinValue;
            }
            else
            {
                this.CurrentSt = x;
            }
            this.Bottom = MinValue;
            this.Upper = MaxValue;
        }
        public int State
        {
            get
            {
                return this.CurrentSt;
            }
        }
        public void Increase()
        {
            this.CurrentSt++;
            if (this.CurrentSt > this.Upper)
            {
                throw new Exception("Выход за верхнее значение");
            }
        }
        public void Decrease()
        {
            this.CurrentSt--;
            if (this.CurrentSt < this.Bottom)
            {
                throw new Exception("Выход за нижнее значение");
            }
        }
        class Program
        {
            static void Main()
            {
                var Counter = new DecCounter(0x5, 0x3, 0x2);
                
                for (int i = 0; i < 14; i++)
                {
                    try
                    {
                        Counter.Increase();
                        Console.WriteLine("0x{0:X}", Counter.State);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Exception: {0}", e.Message));
                        break;
                    }
                }
                for (int i = 0; i < 14; i++)
                {
                    try
                    {
                        Counter.Decrease();
                        Console.WriteLine("0x{0:X}", Counter.State);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Exception: {0}", e.Message));
                        break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
