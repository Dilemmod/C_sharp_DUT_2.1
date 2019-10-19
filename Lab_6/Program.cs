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
            int i = 5;
            Console.WriteLine("++i = " + (++i));//6
            Console.WriteLine("i++ = " + (i++));//7
            Console.WriteLine("++i = " + (++i));//7
            Console.WriteLine("++i = " + (++i));//8
            Console.WriteLine("--i = " + (i--));//7
            Console.WriteLine("++i = " + (++i));//8

            Console.ReadKey();
        }
    }
}
