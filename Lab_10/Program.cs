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
            Console.Write("User array of one zero list ");
            Console.Write(" ");
            ozExemp.OutputList();
            Console.WriteLine();
            Console.Write("Elements with an even index ");
            Console.Write(" ");
            ozExemp.EvenOdd();
            Console.ReadKey();
        }
    }
}
