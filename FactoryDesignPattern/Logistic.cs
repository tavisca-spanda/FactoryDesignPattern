using System;

namespace FactoryDesignPattern
{
    class Logistic
    {
        private ITrasportSystem TrasportSystem;
        public Logistic(ITrasportSystem tSystem)
        {
            TrasportSystem = tSystem;
            
        }
        public void StateTransportMethod()
        {
            TrasportSystem.PrintType();
        }
    }
}
