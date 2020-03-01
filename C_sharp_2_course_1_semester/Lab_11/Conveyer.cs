using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Conveyer
    {
        public Conveyer() { }
        public void TekeSizes(Product prod)
        {
            prod.tekenSizes = true;
        }
        public void CutOff(Product prod)
        {
            prod.cutOff = true;
        }
        public void Sharpen(Product prod)
        {
            prod.sharpened = true;
        }
        public void CutThrean(Product prod)
        {
            prod.cutThreat = true;
        }
        public void Drillen(Product prod)
        {
            prod.drilled = true;
        }
        public void Painten(Product prod)
        {
            prod.painted = true;
        }
        public void Protest(Product prod)
        {
            prod.tested = true;
        }
        public void Packen(Product prod)
        {
            prod.painted = true;
        }


    }
}
