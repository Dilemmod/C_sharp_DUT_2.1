using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Conveyer
    {
        Product prod = new Product();
        public void TekeSizes()
        {
            prod.tekenSizes = true;
        }
        public void CutOff()
        {
            prod.cutOff = true;
        }
        public void Sharpen()
        {
            prod.sharpened = true;
        }
        public void CutThrean()
        {
            prod.cutThreat = true;
        }
        public void Drillen()
        {
            prod.drilled = true;
        }
        public void Painten()
        {
            prod.painted = true;
        }
        public void Protest()
        {
            prod.tested = true;
        }
        public void Packen()
        {
            prod.painted = true;
        }


    }
}
