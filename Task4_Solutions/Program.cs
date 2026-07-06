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
        }

        public static void PrintWelcome(string name)
        {
            // Function of task 1:
            Console.WriteLine($"Welcome, "+name+" we are glad to have you here.");
        }
    }
}
