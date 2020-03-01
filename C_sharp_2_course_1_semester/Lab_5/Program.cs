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
            Console.Write("Enter size masiv M ");
            Array array = new Array(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The original arrat");
            array.initializationArray();
            Console.WriteLine("Horizontal axis of symmetry");
            array.horizontalMirrorArray();
            Console.WriteLine("Vertical axis of symmetry");
            array.verticalMirorArray();
            Console.WriteLine("Miror array on the main diagonal");
            array.diagonalMirorArray();
            Console.WriteLine("Miror array on the side diagonal");
            array.sideDiagonalArray();
            Console.ReadKey();
        }
    }
    class Array
    {
        private int temp;
        private int size;
        private int[,] mas;
        private int[,] temporary;
        public Array(int size)
        {
            mas = new int[size, size];
            temporary = new int[size,size];
            this.size = size;
        }
        public void getArray()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" " + mas[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void initializationArray()
        {
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temporary[i,j] = r.Next(10);
                    mas[i, j] = temporary[i, j];
                }
            }
            getArray();
        }
        private void reset()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = temporary[i, j];
                }
            }
        }
        public void horizontalMirrorArray()
        {
            reset();
            for (int i = 0; i < (size / 2); i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[(size - i - 1), j];
                    mas[(size - i - 1), j] = temp;
                }
            }
            getArray();
        }
        public void verticalMirorArray()
        {
            reset();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < (size/2); j++)
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[i, (size - j - 1)];
                    mas[i, (size - j - 1)] = temp;
                }
            }
            getArray();
        }
        public void diagonalMirorArray()
        {
            reset();
            for (int i = size-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++) 
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[j, i];
                    mas[j, i] = temp;
                }
            }
            getArray();
        }
        public void sideDiagonalArray()
        {
            reset();
            for (int i = 0; i < (size-1); i++)
            {
                for (int j = 0; j < (size - i -1); j++)
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[(size-1-j),(size -1 - i)];
                    mas[(size - 1 - j),(size - 1 - i)] = temp;
                }
            }
            getArray();
        }
    }
}
    

