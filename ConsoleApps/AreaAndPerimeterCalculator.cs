using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class AreaAndPerimeterCalculator
    {
        private static Int32 showShapesMenu()
        {
            Console.WriteLine("\nShapes List");
            Console.WriteLine("=========================================");
            Console.WriteLine("1.Circle\n2.Triangle\n3.Square");
            Console.WriteLine("Enter Shape choice : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static Int32 showMainMenu()
        {
            Console.WriteLine("\nArea, Perimiter Calculator");
            Console.WriteLine("=========================================");
            Console.WriteLine("1.Find Area\n2.Find Perimiter\n3.Exit");
            Console.WriteLine("Enter Your choice : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public double askRadiusOfCircle()
        {
            Console.WriteLine("Enter radius of Circle : ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public double[] askWidthAndHeigthOfRect()
        {
            Console.WriteLine("Enter the width of the Triangle : ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the Triangle : ");
            double height = Convert.ToDouble(Console.ReadLine());

            return new double[] { width, height };
        }

        public double askSideOfSqure()
        {
            Console.WriteLine("Enter Side of Square : ");
            return Convert.ToDouble(Console.ReadLine());
        } 

        static void Main(string[] args)
        {
            Boolean repeat = true;
            Int32 chapeChoice, mainMenuChoice;

            while (repeat)
            {
                Shape shape = new Shape();

                mainMenuChoice = showMainMenu();

                switch (mainMenuChoice) 
                {
                    case 1 :                        
                        chapeChoice = showShapesMenu();
                        Console.WriteLine("Area : " + shape.calculateArea(chapeChoice));
                        break;

                    case 2:
                        chapeChoice = showShapesMenu();
                        Console.WriteLine("Perimeter : " + shape.calculatePerimeter(chapeChoice));
                        break;

                    case 3:
                        Console.WriteLine("************* End *************");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
