using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your symbols = ");
            string symbols = Console.ReadLine();
            //Перевірка чи symmbols число
            int integerDigit, temp;
            double doubleDigit;
            bool isNum = Int32.TryParse(symbols, out integerDigit);
            bool isDouble = Double.TryParse(symbols, out doubleDigit);
            if (isNum)
            {
                //Перетворення str в int
                integerDigit = Convert.ToInt32(symbols);
                while (integerDigit > 0)
                {
                    temp = integerDigit % 10;
                    Console.Write(temp);
                    integerDigit /= 10;
                }
            }
            else if (!isNum && isDouble)
            {
                //Перетворення str в float
                doubleDigit = Convert.ToDouble(symbols);
                Console.WriteLine("IS Double");

                double dCopy = doubleDigit;
                while (dCopy > 1)
                {
                    temp = (int)dCopy % 10;
                    Console.Write(temp);
                    dCopy /= 10;
                }
                Console.WriteLine();
                dCopy = doubleDigit;
                dCopy %= 1;
                Console.WriteLine(dCopy);
                string dCopyStr = Convert.ToString(doubleDigit);
                char[] charArray = dCopyStr.ToCharArray();
                Console.WriteLine(charArray);
                string reverse = String.Empty;
                for (int i = charArray.Length - 1; i > -1; i--)
                {
                    reverse += charArray[i];
                }
                Console.Write(",");

            }
            else
            {
                Console.WriteLine("String ");
                Console.WriteLine(new string(symbols.Reverse().ToArray()));
            }
            Console.ReadKey();
            
           
        }
        
    }
}
