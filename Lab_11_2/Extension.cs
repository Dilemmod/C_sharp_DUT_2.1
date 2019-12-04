using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> listSt)
        {

            StudentPredicateDelegate sDeleg1 = Student.AgeCheck;
            StudentPredicateDelegate sDeleg2 = Student.FirstNameCheck;
            StudentPredicateDelegate sDeleg3 = Student.LastNameCheck;

            List<Student> sortListSt = new List<Student>();
            for (int i = 0; i < listSt.Count; i++)
            {
                if (sDeleg1(listSt[i]) && sDeleg2(listSt[i]) && sDeleg3(listSt[i]))
                {
                    sortListSt.Add(listSt[i]);
                }
                //sortListSt.Add(sDeleg1(listSt[i])? listSt[i]:null);
            }

            return sortListSt;
        }
        public static void GetInfo(this List<Student> sortListS)
        {
            int i = 0;
            foreach (Student uc in sortListS)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(uc);
                Console.WriteLine();
            }
        }

    }
}
