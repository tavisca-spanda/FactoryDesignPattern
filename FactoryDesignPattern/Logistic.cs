using System;

namespace FactoryDesignPattern
{
    class Logistic
    {
        private TransportSystemCreator trasportSystemCreator;
        public void Initialize(string tSystem)
        {
            if(tSystem== "Truck")
            {
                trasportSystemCreator = new TruckCreator();

            }

            if (tSystem == "Ship")
            {
                trasportSystemCreator = new ShipCreator();

            }

            trasportSystemCreator.CreateTransportSystem();
            trasportSystemCreator.PrintType();

        }




        
    }
}
