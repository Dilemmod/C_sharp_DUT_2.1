using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Backwards
    {
        public Backwards (string userS)
        {
            char magicSymbol = (userS.IndexOf("!") != -1 ? '!' : (userS.IndexOf(".") != -1 ? '.' :(userS.IndexOf(",") != -1 ?',':' ')));
            Console.Write(magicSymbol == ' ' ? Flip(ref userS) : Flip(userS, magicSymbol));
        }
        private string Flip(string userS, char magicSymbol)
        {
            string[] partsUserS = userS.Split(new char[] { magicSymbol });
            for(int i = 0; i < partsUserS.Length; i++)
            {
                partsUserS[i] = Flip(ref partsUserS[i]);
            }
            return String.Join($"{magicSymbol}",partsUserS);
        }
        private string Flip(ref string userS)
        {
            char[] charArray = userS.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic symbols = \n ! , .");
            Console.Write("Enter your symbols = ");
            Backwards usersSymbol = new Backwards(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
