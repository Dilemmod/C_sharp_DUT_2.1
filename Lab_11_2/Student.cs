using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return "Name: " + firstName + "\nLast name: " + lastName + "\nAge: " + age;
        }

        public static bool AgeCheck(Student st)
        {
            return (st.age >= 18 ? true : false);
        }
        public static bool FirstNameCheck(Student st)
        {
            return (st.firstName.IndexOf("A") == 0 ? true : false);
        }
        public static bool LastNameCheck(Student st)
        {
            return (st.lastName.Length > 3 ? true : false);
        }
    }
}
