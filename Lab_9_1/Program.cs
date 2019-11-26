using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_1
{
    class Program
    {
        abstract class Triangle
        {
            public string color { get; set; }
            public int side1 { get; set; }
            public int side2 { get; set; }
            public int angle { get; set; }
            public string name { get; set; }
            public string type { get; set; }

            protected string[] colors = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Violet" };
            protected Random random = new Random();
            public abstract double Perimeter();
            public abstract double Square();
            public override string ToString()
            {
                    return ("Type = "+type+"| Side1 = " + side1 + "| Side2 = " + side2 + "| Angle = " + angle + "| Color = " + color + "| Name = " + this.name + "\nPerimeter = " + Perimeter() + "| Square = " + Square());
            }
            protected void RandomValues()
            {
                string[] nameArray = new string[] {"d3","H1","u2","ka","s8","q0","b2","iq","ter","p"};
                name = nameArray[random.Next(0, nameArray.Length - 1)];
                side1 = random.Next(0, 10);
                side2 = random.Next(0, 10);
                angle = random.Next(0, 180);
                color = colors[random.Next(0, colors.Length - 1)];
            }


        }
        class EqTriangle : Triangle
        {
            public EqTriangle()
            {
                RandomValues();
                side2 = side1;
                type = "Equilateral triangle";
                Perimeter();
                Square();
            }
            public EqTriangle(string name)
            {
                RandomValues();
                type = "Equilateral triangle";
                this.name = name;
                Perimeter();
                Square();
            }
            public EqTriangle(string name, int side1)
            {
                RandomValues();
                type = "Equilateral triangle";
                this.name = name;
                this.side1 = side1;
                Perimeter();
                Square();
            }
            public EqTriangle(string name, int side1,string color)
            {
                RandomValues();
                type = "Equilateral triangle";
                this.name = name;
                this.side1 = side1;
                this.color = color;
                Perimeter();
                Square();
            }
            public override double Perimeter()
            {
                return 3 * side1;
            }
            public override double Square()
            {
                return (0.5 * side1 * ((Math.Sqrt(3) / 2) * side1));
            }

        }
        class IsTriangle : Triangle
        {
            public IsTriangle()
            {
                RandomValues();
                type = "Isosceles triangle";
                Perimeter();
                Square();
            }
            public IsTriangle(string name)
            {
                RandomValues();
                type = "Isosceles triangle";
                this.name = name;
                Perimeter();
                Square();
            }
            public IsTriangle(string name, int side1)
            {
                RandomValues();
                type = "Isosceles triangle";
                this.name = name;
                this.side1 = side1;
                Perimeter();
                Square();
            }
            public IsTriangle(string name, int side1, int side2)
            {
                RandomValues();
                type = "Isosceles triangle";
                this.name = name;
                this.side1 = side1;
                this.side2 = side2;
                Perimeter();
                Square();
            }
            public IsTriangle(string name, int side1, int side2, string color)
            {
                RandomValues();
                type = "Isosceles triangle";
                this.name = name;
                this.side1 = side1;
                this.side2 = side2;
                this.color = color;
                Perimeter();
                Square();
            }
            public override double Perimeter()
            {
                return ((side1*2)+side2);
            }
            public override double Square()
            {
                double h = Math.Sqrt(Math.Pow(side1, 2)-(Math.Pow(side2, 2)/4));
                return (0.5 * side2 * h);
            }
        }
        class RectTriangle : Triangle
        {
            public RectTriangle()
            {
                RandomValues();
                type = "Rect triangle";
                Perimeter();
                Square();
            }
            public RectTriangle(string name)
            {
                RandomValues();
                type = "Rect triangle";
                this.name = name;
                Perimeter();
                Square();
            }
            public RectTriangle(string name, int side1)
            {
                RandomValues();
                type = "Rect triangle";
                this.name = name;
                this.side1 = side1;
                Perimeter();
                Square();
            }
            public RectTriangle(string name, int side1, int side2)
            {
                RandomValues();
                type = "Rect triangle";
                this.name = name;
                this.side1 = side1;
                this.side2 = side2;
                Perimeter();
                Square();
            }
            public RectTriangle(string name, int side1, int side2, string color)
            {
                RandomValues();
                type = "Rect triangle";
                this.name = name;
                this.side1 = side1;
                this.side2 = side2;
                this.color = color;
                Perimeter();
                Square();
            }
            public override double Perimeter()
            {
                double length3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
                return (side1 + side2 + length3);
            }
            public override double Square()
            {
                return ((side1*side2)/2);
            }
        }
        class Picture
        {
            List<Triangle> picture = new List<Triangle>();
            private void GetChoice()
            {
                ConsoleKeyInfo userAction;
                Console.WriteLine("If you went to add a triangle press A\nIf you went to delete a triangle pres D");
                userAction = Console.ReadKey(true);
                switch (userAction.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine();
                        AddTraingle();
                        break;
                    case ConsoleKey.D:
                        DeleteTraingle();
                        break;
                }
            }
            public Picture()
            {
                picture.Add(new EqTriangle() { name = "E1", side1 = 6, side2 = 6 });
                picture.Add(new IsTriangle() { side1 = 31, side2 = 2, color = "red" });
                picture.Add(new RectTriangle() { name = "Re3", side1 = 19 });
                GetPicture();
            }
            public Picture(int length)
            {
                GetPicture();
            }
            public void GetPicture()
            {
                Console.WriteLine();
                int i = 0;
                foreach (Triangle uc in picture)
                {
                    Console.WriteLine("Index: " + (i++)+"\t");
                    Console.WriteLine(uc);
                }
            }
            public void AddTraingle()
            {
                picture.Add(new EqTriangle() { name = "E1", side1 = 6, side2 = 6 });
            }
            public void DeleteTraingle()
            {

            }
        }
        static void Main(string[] args)
        {
            new Picture();
            Console.ReadKey();
        }
    }
}
