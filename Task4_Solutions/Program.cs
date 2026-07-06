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
    }
}

