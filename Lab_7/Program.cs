using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your symbols");
            string str = Console.ReadLine();
            //Перевірка чи str число
            int num, user;
            float f;
            bool isNum = Int32.TryParse(str, out num);
            bool isFloat = float.TryParse(str, out f);
            Console.WriteLine(isFloat);
            if (isNum)
            { 
                //Перетворення str в int
                user = Convert.ToInt32(str);
                for (; user > 0; user /= 10)
                {
                    num = user % 10;
                    Console.Write(num);
                }
            }
            else if(!isNum && isFloat)
            {
                //Перетворення str в float
                f = float.Parse(str);
                Console.WriteLine("IS float");
            }
            else
            {
                Console.WriteLine("str");
                Console.WriteLine(new string(str.Reverse().ToArray()));
            }
            Console.ReadKey();
        }
    }
}
