using System;

namespace ConsoleApps
{
    class Program
    {
        public void addition(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Addition of {0} , {1} = {2}", n1, n2, result);
        }

        public void subtraction(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Subtraction of {0} , {1} = {2}", n1, n2, result);
        }

        public void multiplication(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Times of {0} , {1} = {2}", n1, n2, result);
        }

        public void division(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Division of {0} , {1} = {2}", n1, n2, result);
        }
        static void Main(string[] args)
        {
            Boolean repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome To Menu Driven Calculator");
                Console.WriteLine("=========================================");
                Console.WriteLine("1.Addition\n2.Subtraction\n3.Division\n4.Multiplication\n5.Exit");
                Console.WriteLine("Enter Your choice : ");
                Int32 choice = Convert.ToInt32(Console.ReadLine());


                Program obj1 = new Program();

                if (choice == 1)
                {
                    Console.WriteLine("Enter Number 1 : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2 : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    obj1.addition(num1, num2);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter Number 1 : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2 : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    obj1.subtraction(num1, num2);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter Number 1 : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2 : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    obj1.division(num1, num2);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter Number 1 : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2 : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    obj1.multiplication(num1, num2);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("************* End *************");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }

            }
            Console.ReadKey();
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
    }
}
