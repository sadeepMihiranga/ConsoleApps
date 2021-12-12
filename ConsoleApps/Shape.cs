using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Shape
    {
        public readonly double pi = 3.14;

        public double calculateArea(Int32 chapeChoice)
        {
            AreaAndPerimeterCalculator calculator = new AreaAndPerimeterCalculator();

            switch (chapeChoice)
            {
                case 1:
                    double radius = calculator.askRadiusOfCircle();
                    return pi * radius * radius;

                case 2:
                    /** 0 index is width, 1 - index is height */
                    double[] parameters = calculator.askWidthAndHeigthOfRect();
                    return (parameters[0] * parameters[1]) / 2;
                
                case 3:
                    double side = calculator.askSideOfSqure();
                    return side * side;

                default:
                    Console.WriteLine("Invalid Shape Input.");
                    break;
            }

            return 0;
        }

        public double calculatePerimeter(Int32 chapeChoice)
        {
            AreaAndPerimeterCalculator calculator = new AreaAndPerimeterCalculator();

            switch (chapeChoice)
            {
                case 1:
                    double radius = calculator.askRadiusOfCircle();
                    return 2 * pi * radius;

                case 2:
                    /** 0 index is width, 1 - index is height */
                    double[] parameters = calculator.askWidthAndHeigthOfRect();
                    return 2 * (parameters[0] + parameters[1]);

                case 3:
                    double side = calculator.askSideOfSqure();
                    return 4 * side;

                default:
                    Console.WriteLine("Invalid Shape Input.");
                    break;
            }

            return 0;
        }
    }
}
