using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class TruckCreator : TransportSystemCreator
    {
        public override ITransportSystem CreateTransportSystem()
        {
            return new Truck
            {
                Mode = "Road"
            };
        }
    }
}
