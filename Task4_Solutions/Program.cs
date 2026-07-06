using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);

            ////////////////////////////////////////////

            // Task 2 - Square Number Function
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square of " + number + " is: " + result);

            ////////////////////////////////////////////////////////////

            // Task 3 - Celsius to Fahrenheit Function
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);

            ////////////////////////////////////////////////////////////////////

            //Task 4 - Fixed Menu Display Function
            
            DisplayMenu();

            ////////////////////////////////////////////////////////////////////

            //Task 5 - Even or Odd Function
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsEven(num))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            ////////////////////////////////////////////////////////////////////

            // Task 6 - Rectangle Area & Perimeter Functions
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);

            //////////////////////////////////////////////////////////////

            // Task 7 - Grade Letter Function
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            string grade = GetGradeLetter(score);

            Console.WriteLine("Grade: " + grade);

            //////////////////////////////////////////////////////////////

            // Task 8 - Countdown Function

            Console.Write("Enter starting number: ");
            int start = int.Parse(Console.ReadLine());

            Countdown(start);

            ////////////////////////////////////////////////////////////////

            //Task 9 - Overloaded Multiply Function
            int result1 = Multiply(5, 4);
            Console.WriteLine("Multiply(int, int): " + result1);

            double result2 = Multiply(2.5, 4.0);
            Console.WriteLine("Multiply(double, double): " + result2);

            int result3 = Multiply(2, 3, 4);
            Console.WriteLine("Multiply(int, int, int): " + result3);

            //////////////////////////////////////////////////////////

            // Task 10 - Overloaded Area Calculator

            Console.WriteLine("Choose a shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the side of the square: ");
                double side = double.Parse(Console.ReadLine());

                double Area = calculateArea(side);

                Console.WriteLine("Square Area = " + area);
            }
            else if (choice == 2)
            {
                Console.Write("Enter the length: ");
                double Length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                double Width = double.Parse(Console.ReadLine());

                double Area = calculateArea(length, width);

                Console.WriteLine("Rectangle Area = " + area);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }


        }

        // Function of task 1:
        public static void PrintWelcome(string name)
        {
            
            Console.WriteLine($"Welcome, " + name + 
                " we are glad to have you here.");
        }
        
        /// /////////////////////////////////////////////////////////
        
            // Function of task 2:
            public static int Square(int number)
        {
            return number * number;
        }

        /// /////////////////////////////////////////////////////////


        // Function of task 3:
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        /// /////////////////////////////////////////////////////////


        // Function of task 4:
        public static void DisplayMenu()
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
        }

        //////////////////////////////////////////////

        //Function of task 5:
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        ////////////////////////////////////////////////////////////////////

        // Function of task 6:
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        /////////////////////////////////////////////////////////////////////

        // Function of task 7:
        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        ///////////////////////////////////////////////

        // Function of task 8:
        public static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        ///////////////////////////////////////////////////

        // function of task 9:
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        /////////////////////////////////////////////////////////

        // Function of task 10:
        public static double calculateArea(double side)
        {
            return side * side;
        }

        public static double calculateArea(double Length, double Width)
        {
            return Length * Width;
        }

        ///////////////////////////////////////////////////////////////////

        // Function of task 11:

    }
}

