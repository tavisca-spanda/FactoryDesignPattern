using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class ShipCreator : TransportSystemCreator
    {
        public override ITransportSystem CreateTransportSystem()
        {
            return new Ship
            {
                Mode = "Water"
            };
        }
    }
}
