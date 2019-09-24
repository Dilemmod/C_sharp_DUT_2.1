using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
         
        static void Main(string[] args)
        {

            //Lab_4
            //Варіант_17
            //Дано дійсне число R і масив розміру N. Знайти елемент масиву, який найближчий (найдальший) від даного числа.
            Console.Write("Enter size masiv N "); int size = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[size];
            Console.Write("Enter the digit R "); double r = Convert.ToDouble(Console.ReadLine());
            double temp = 0, m = double.MaxValue;

            for (int i = 0; i < mas.Length; i++) 
            {
                Console.Write("Enter [" + (i + 1) + "] element ");
                mas[i] = Convert.ToDouble(Console.ReadLine());
                double a = Math.Abs(Math.Abs(mas[i]) - Math.Abs(r));

                if (a < m)
                {
                    temp = mas[i];
                    m = a;
                }
            }
            Console.WriteLine("The closest number to R: " + temp);
            Console.ReadKey();


        }
    }
    
}
