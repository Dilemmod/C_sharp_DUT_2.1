using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public delegate void DelegateConveyer();
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Conveyer exConv = new Conveyer();
            DelegateConveyer conveyer = exConv.TekeSizes();
        }
    }
}
