using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of phone: ");

            Phone p = new IPhone(Console.ReadLine());
            p.getName();
            Console.ReadKey();
        }
    }
    class Phone
    {
        protected string phoneName;
        protected string phoneVersion;
        public void getName()
        {
            Console.WriteLine("Name of Phone: " + phoneName);
            Console.WriteLine("Version of Phone: " + phoneVersion);
        }
        public Phone(string nameOfPhone)
        {
            this.phoneName = nameOfPhone;
        }
    }
    class DiskPhone: Phone
    {
        public DiskPhone(string nameOfPhone):base(nameOfPhone)
        {
            phoneName = "Disk Phone";
        }
    }
    class ButtonPhone : DiskPhone
    {
        public ButtonPhone(string phoneName) : base(phoneName)
        {
            phoneVersion = "Button Phone";
        }
    }
    class MobileBlackScreenPhone : ButtonPhone
    {
        public MobileBlackScreenPhone(string phoneName) : base(phoneName)
        {
            phoneVersion = "Mobile black screen phone";
        }
    }
    class MobileColoredScreenPhone : MobileBlackScreenPhone
    {
        public MobileColoredScreenPhone(string phoneName) : base(phoneName)
        {
            phoneVersion = "Mobile colored screen phone";
        }
    }
    class IPhone : MobileColoredScreenPhone
    {
        public IPhone(string phoneName) : base(phoneName)
        {
            phoneVersion = "IPone";
        }
    }
    class GoogleGlass : IPhone
    {
        public GoogleGlass(string phoneName) : base(phoneName)
        {
            phoneVersion = "Google glass";
        }
    }
}


