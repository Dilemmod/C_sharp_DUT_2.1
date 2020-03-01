using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        public delegate void DelegateConveyer(Product prod);
        static void Main(string[] args)
        {
            // 1.
            Product prod = new Product();
            prod.OutputInfo();
            Conveyer exConv = new Conveyer();
            DelegateConveyer conveyer = exConv.TekeSizes;
            conveyer += exConv.CutOff;
            conveyer += exConv.Sharpen;
            conveyer += exConv.CutThrean;
            conveyer += exConv.Drillen;
            conveyer += exConv.Painten;
            conveyer += exConv.Protest;
            conveyer += exConv.Packen;
            conveyer(prod);
            prod.OutputInfo();
            Console.ReadKey();
        }
    }
}
