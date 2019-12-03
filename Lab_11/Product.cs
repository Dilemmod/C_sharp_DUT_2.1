using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Product
    {
        public bool tekenSizes { get; set; }
        public bool cutOff { get; set; }
        public bool sharpened { get; set; }
        public bool cutThreat { get; set; }
        public bool drilled { get; set; }
        public bool painted { get; set; }
        public bool tested { get; set; }
        public bool packed { get; set; }
        public Product()
        {
            tekenSizes = false;
            cutOff = false;
            sharpened = false;
            cutThreat = false;
            drilled = false;
            painted = false;
            tested = false;
            packed = false;
        }
        public void OutputInfo()
        {
            Console.WriteLine($" Status of product:\nTeken sizes = {tekenSizes}; Cut off = {cutOff}; Sharpened = {sharpened}; Cut threat = {cutThreat};Drilled ={drilled}; Painted = {painted}; Tested = {tested}; Packed = {packed}.");
        }
       
    }
}
