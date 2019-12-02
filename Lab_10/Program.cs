using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Створити розширяючий метод для масиву цілих чисел, який спочатку виводить елементи з парними індексами а потім з непарними.
            OZClass ozExemp = new OZClass();
            ozExemp.EnterData();
            ozExemp.EvenOdd();
            Console.ReadKey();
        }
    }
}
