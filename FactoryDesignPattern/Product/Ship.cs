using System;

namespace FactoryDesignPattern
{
    class Ship : ITransportSystem
    {
        public string Mode { get; set; }

        public void PrintType()
        {
            Console.WriteLine("Ship is on" + " " + Mode);
        }
    }
}
