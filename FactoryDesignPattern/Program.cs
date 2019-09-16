using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            string input= Console.ReadLine();

            string tMethod = Enum.GetName(typeof(TransportSystem), Int32.Parse(input));

            LogisticDecision logisticDecision = new LogisticDecision();
            ITrasportSystem trasportSystem = logisticDecision.CreateLogistic(tMethod);

            Logistic logistic = new Logistic(trasportSystem);
            
            logistic.StateTransportMethod();

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
