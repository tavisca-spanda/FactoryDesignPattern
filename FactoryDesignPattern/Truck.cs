using System;

namespace FactoryDesignPattern
{
    class Truck : ITrasportSystem
    {
        public string Mode { get ; set; }

        public void PrintType()
        {
            Console.WriteLine("Truck is on" + " " +Mode);
        }
    }
}
