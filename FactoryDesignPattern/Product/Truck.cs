using System;

namespace FactoryDesignPattern
{
    class Truck : ITransportSystem
    {
        public string Mode { get ; set; }

        public void PrintType()
        {
            Console.WriteLine("Truck is on" + " " +Mode);
        }
    }
}
