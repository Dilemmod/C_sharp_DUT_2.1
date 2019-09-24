using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab_5
            //Варіант_17
            //17. Дана квадратна матриця порядку M. Дзеркально відобразити її
            // елементи відносно 1) горизонтальної осі симетрії; 2) вертикальної
            // осі симетрії; 3) головної діагоналі; 4) побічної діагоналі матриці.
            //int  tmp = 0;
            Random r = new Random();


            Console.Write("Enter size masiv M "); int size = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[size, size];

            Console.WriteLine(mas.Length);
            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = r.Next(10);
                    Console.Write(" " + mas[i, j]);
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < (size / 2); i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        tmp = mas[i, j];
            //        mas[i, j] = mas[(size - i - 1), j];
            //        mas[(size - i - 1), j] = tmp;
            //    }
            //}

            //Console.WriteLine("Зеркальная матрица");
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write("{0} ", mas[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
