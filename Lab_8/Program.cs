using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Speed { get; set; }
        public string YearOfGraduation { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + "\nColor: " + Color + "\nSpeed: " + Speed + "\nYear Of Graduation: " + YearOfGraduation + "\n";
        }
    }
    class SheikhGarage
    {
        List<Car> carList = new List<Car>();
        public SheikhGarage()
        {
            carList.Add(new Car() { Name = "Lamborghini Aventador", Color = "Red", Speed = "350", YearOfGraduation = "2011" });
            carList.Add(new Car() { Name = "LaFerrari", Color = "Red", Speed = "350", YearOfGraduation = "2013" });
            carList.Add(new Car() { Name = "Porsche taycan", Color = "White", Speed = "260", YearOfGraduation = "2015" });
            carList.Add(new Car() { Name = "Koenigsegg Agera RS", Color = "Orange", Speed = "460", YearOfGraduation = "2015" });
            carList.Add(new Car() { Name = "Bugatti Veyron Super Sport", Color = "Orange", Speed = "410", YearOfGraduation = "2015" });
            carList.Add(new Car() { Name = "Mclaren F1", Color = "Red", Speed = "390", YearOfGraduation = "1993" });
            getMenu();
        }
        private void carListAdd(string allParameters)
        {
            string[] arrayAllParametrs = allParameters.Split(new char[] { ';' });
            carList.Add(new Car() { Name = arrayAllParametrs[0], Color = arrayAllParametrs[1], Speed = arrayAllParametrs[2], YearOfGraduation = arrayAllParametrs[3] });
        }
        private void getCarList()
        {
            Console.WriteLine();
            int i = 0;
            foreach (Car uc in carList)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(uc);
            }
        }
        private void getMenu()
        {
            ConsoleKeyInfo userAction;
            do
            {
                Console.WriteLine("Press the key to go to the menu");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("If you want to exit press 'Escepe' ");
                Console.WriteLine("If you want to buy a new car press 'B'");
                Console.WriteLine("If you want to remove the car, press 'R");
                Console.WriteLine("If you want to drive a car, press 'D'");
                Console.WriteLine("If you want to see the whole list of cars enter 'A'");
                userAction = Console.ReadKey(true);
                Console.Clear();
                switch (userAction.Key)
                {
                    case ConsoleKey.B:
                        Console.WriteLine("Enter the name of the car, color, speed and year of manufacture through the sign ';' ");
                        Console.WriteLine("Correct entry: ");
                        Console.WriteLine("Name;Color;Speed;Year of Graduation");
                        try
                        {
                            carListAdd(Console.ReadLine());
                            Console.WriteLine("You have successfully bought a car");
                        }
                        catch
                        {
                            Console.WriteLine("Parameters entered incorrectly!");
                        }

                        break;
                    case ConsoleKey.R:
                        getCarList();
                        Console.WriteLine("Enter the number of the car you want to delete");
                        try
                        {
                            carList.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                            Console.WriteLine("You have successfully remove a car");
                        }
                        catch
                        {
                            Console.WriteLine("Parameters entered incorrectly!");
                        }
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("What method do you want to choose a car to ride");
                        Console.WriteLine("If by car number press 'N'");
                        Console.WriteLine("If on parameters press 'O'");
                        ConsoleKeyInfo userChoice = Console.ReadKey(true);
                        switch (userChoice.Key)
                        {
                            case ConsoleKey.N:
                                Console.WriteLine("\t\t\t Enter number of car: ");
                                Console.WriteLine("You chose: \n" + carList[Convert.ToInt32(Console.ReadLine()) - 1]);
                                break;
                            case ConsoleKey.O:
                        //COPY LIST
                                List<Car> copyCarList = new List<Car>(carList);
                                int j;
                                string StrParam;
                                int amountP = 0;
                                do
                                {
                                    Console.WriteLine("\t\t\t\tHow many parameters do you have: ");
                                    amountP = Convert.ToInt32(Console.ReadLine());
                                } while (amountP > 4);
                                for (int i = 0; i < amountP; i++)
                                {
                                    Console.WriteLine("\t\t\tPress on the first letter of the need parameter (N or C or S or Y)");
                                    ConsoleKeyInfo parameter = Console.ReadKey(true);
                                    switch (parameter.Key)
                                    {
                                        case ConsoleKey.N:
                                            Console.WriteLine("\t\t Enter NAME of car");
                                            StrParam = Console.ReadLine();
                                            j = 0;
                                            while (j < copyCarList.Count)
                                            {
                                                if (copyCarList[j].Name != StrParam)
                                                {
                                                    copyCarList.RemoveAt(j);
                                                }
                                                else { j++; }
                                            }
                                            break;
                                        case ConsoleKey.C:
                                            Console.WriteLine("\t\t Enter COLOR of car");
                                            StrParam = Console.ReadLine();
                                            j = 0;
                                            while (j < copyCarList.Count)
                                            {
                                                if (copyCarList[j].Color != StrParam)
                                                {
                                                    copyCarList.RemoveAt(j);
                                                }
                                                else { j++; }
                                            }
                                            break;
                                        case ConsoleKey.S:
                                            Console.WriteLine("\t\t Enter SPEED of car");
                                            StrParam = Console.ReadLine();
                                            j = 0;
                                            while ( j < copyCarList.Count)
                                            {
                                                if (copyCarList[j].Speed != StrParam)
                                                {
                                                    copyCarList.RemoveAt(j);
                                                }
                                                else { j++; }
                                            }
                                            break;
                                        case ConsoleKey.Y:
                                            Console.WriteLine("\t\t Enter YEAR of Graduation car");
                                            StrParam = Console.ReadLine();
                                            j = 0;
                                            while (j < copyCarList.Count)
                                            {
                                                if (copyCarList[j].YearOfGraduation != StrParam)
                                                {
                                                    copyCarList.RemoveAt(j);
                                                }
                                                else { j++; }
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Parameters entered incorrectly!");
                                            getMenu();
                                            break;
                                    }
                                }
                                Console.WriteLine("\t\t\tYou CHOISE: \n");
                                foreach (Car t in copyCarList)
                                {
                                    Console.WriteLine(t);
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.A:
                        getCarList();
                        break;
                }
            } while (userAction.Key != ConsoleKey.Escape);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            new SheikhGarage();
        }
    }
}