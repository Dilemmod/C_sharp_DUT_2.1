using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class OZClass
    {
        List<int> oneOrZero = new List<int>();
        public int Count;
        public void EnterData()
        {
            ConsoleKeyInfo exit;
            int zeros = 0, units = 0;
            Console.WriteLine("Enter 0 or 1 : ");
            Console.WriteLine("Enter ENTER key for exit ");
            Console.Write(" ");
            do
            {
                exit = Console.ReadKey(true);
                switch (exit.Key)
                {
                    case ConsoleKey.D0:
                        zeros++;
                        oneOrZero.Add(0);
                        Console.Write("0 ");
                        break;
                    case ConsoleKey.D1:
                        units++;
                        oneOrZero.Add(1);
                        Console.Write("1 ");
                        break;
                }
            } while (exit.Key != ConsoleKey.Enter);
            Count = oneOrZero.Count;
            Console.WriteLine();
            Console.WriteLine("Number of units = " + units);
            Console.WriteLine("Number of zeros = " + zeros);
        }
        public void OutputList()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.Write(oneOrZero[i] +" ");
            }
        }
        public void OutputNumberEven(int index)
        {
            Console.Write(oneOrZero[index]+" - ");
        }
        public void OutputNumberOdd(int index)
        {
            Console.Write(" - "+ oneOrZero[index]);
        }
    }
}
