using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        public static void Arrey(int size1,int size2, int[,] mas)
        {
            Random r = new Random();
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    mas[i, j] = r.Next(10);
                    Console.Write(" " + mas[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Lab_5
            //Варіант_17
            //17. Дана квадратна матриця порядку M. Дзеркально відобразити її
            // елементи відносно 1) горизонтальної осі симетрії; 2) вертикальної
            // осі симетрії; 3) головної діагоналі; 4) побічної діагоналі матриці.
            int  temp = 0;
            Console.Write("Enter size masiv M "); int size = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[size, size];

            Console.WriteLine("The original matrix");

            //Arrey виводить масив
            Arrey(size,size, mas);

            for (int i = 0; i < (size / 2); i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[(size - i - 1), j];
                    mas[(size - i - 1), j] = temp;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Mirror matrix");

            Arrey(size/2,size, mas);

            Console.ReadKey();
        }
    }
}
