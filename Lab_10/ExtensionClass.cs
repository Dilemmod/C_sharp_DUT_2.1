using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    static class ExtensionClass
    {
        public static void EvenOdd(this OZClass exemplar)
        {
            Console.Write("User array of one zero list ");
            Console.Write(" ");
            exemplar.OutputList();
            Console.WriteLine();
            Console.Write("Elements with an even index ");
            Console.Write(" ");
            for(int i = 0;i< exemplar.Count; i++)
            {
                if (i % 2 == 0) exemplar.OutputNumberEven(i);
            }
            Console.WriteLine();
            Console.Write("Elements with an odd index: ");
            for (int i = 0; i < exemplar.Count; i++)
            {
                if (i % 2 != 0) exemplar.OutputNumberOdd(i);
            }

        }
    }
}
