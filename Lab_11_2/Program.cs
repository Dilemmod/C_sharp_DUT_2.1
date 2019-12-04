using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    delegate bool StudentPredicateDelegate(Student st);
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStud = new List<Student>();
            listStud.Add(new Student() { age = 19, firstName = "Andrew", lastName = "Jeckson" });
            listStud.Add(new Student() { age = 21, firstName = "Gleb", lastName = "Dior" });
            listStud.Add(new Student() { age = 24, firstName = "Alex", lastName = "De" });
            listStud.Add(new Student() { age = 19, firstName = "Andrew", lastName = "Jeckson" });
            listStud.Add(new Student() { age = 16, firstName = "Ana", lastName = "Polena" });
            listStud.Add(new Student() { age = 18, firstName = "Pol", lastName = "Jeckson" });
            listStud.Add(new Student() { age = 32, firstName = "Vasiliy", lastName = "Liter" });
            listStud.Add(new Student() { age = 21, firstName = "Alex", lastName = "Polena" });
            listStud.Add(new Student() { age = 20, firstName = "Anton", lastName = "Dilembor" });
            listStud.Add(new Student() { age = 17, firstName = "Alexey", lastName = "Piterson" });


            List<Student> sortListS = listStud.FindStudent();

            Console.WriteLine();
            int i = 0;
            foreach (Student uc in sortListS)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(uc);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
