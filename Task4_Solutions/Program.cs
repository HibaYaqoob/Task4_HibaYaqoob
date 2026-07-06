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


    }
}

