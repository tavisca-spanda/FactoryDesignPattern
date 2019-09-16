using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            string input= Console.ReadLine();

            string tMethod = Enum.GetName(typeof(TransportSystemEnum), Int32.Parse(input));

            Logistic logistic = new Logistic();

            logistic.Initialize(tMethod);

            Console.ReadKey();

        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Enter corresponding number");
            Console.WriteLine("1. Truck");
            Console.WriteLine("2. Ship");
        }
    }
}
