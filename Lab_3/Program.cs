using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab_3 
            //6 Варiант:
            //Перевірити iстинність вислову: "Данне ціле число є непарним тризначним числом
            Console.Write("Введiть цiле число яке є непарним тризначним числом ");
            string str = Console.ReadLine();
            //Перевірка чи str число
            int n;
            bool isNum = int.TryParse(str, out n);//Одразу конвертує

            if (isNum)
            {
                //Перевірка на парність
                if (n % 2 != 0)
                {
                    //Чи є тризначни числом
                    int i = 0;
                    while (n > 0)
                    {
                        i++;
                        n /= 10;
                    }
                    if (i == 3) Console.WriteLine("Данне цiле число є непарним тризначним числом");
                    else Console.WriteLine("Не вiдповiдає умовi");

                }
                else Console.WriteLine("Не вiдповiдає умовi");
            }
            else Console.WriteLine("Не вiдповiдає умовi");
            Console.ReadKey();
        }
    }
}
