using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 6
            // Варіант 6.
            // Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
            // заповнити його з клавіатури. Порахувати кількість 1 і 0.
            // Скопіювати отриманий ліст в масив.
            List<int> oneOrZero = new List<int>();
            ConsoleKeyInfo exit;
            int zeros = 0, units = 0;
            Console.WriteLine("Enter 0 or 1 : ");
            Console.WriteLine("Enter ENTER key for exit ");
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
            Console.WriteLine();


            Console.WriteLine("The array to which was copied list = ");
            int[] copyList = oneOrZero.ToArray();
            for (int i = 0; i < copyList.Length; i++)
            {
                Console.Write(copyList[i] +" ");
            }

            Console.WriteLine();
            Console.WriteLine("Number of units = " + units);
            Console.WriteLine("Number of zeros = " + zeros);

            Console.ReadKey();
        }
    }
}
