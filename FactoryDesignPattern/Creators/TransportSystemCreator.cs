using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    abstract class TransportSystemCreator
    {
        abstract public ITransportSystem CreateTransportSystem();

        public void PrintType()
        {
            ITransportSystem trasportSystem = CreateTransportSystem();

            trasportSystem.PrintType();

        }
    }
}
