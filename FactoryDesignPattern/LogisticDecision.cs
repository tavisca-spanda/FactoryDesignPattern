namespace FactoryDesignPattern
{
    class LogisticDecision
    {
        private ITrasportSystem TrasportSystem;
        
        public ITrasportSystem CreateLogistic(string tSystem)
        {
            if (tSystem == "Truck")
            {
                TrasportSystem = new Truck()
                {
                    Mode = "Road"
                };

            }

            if (tSystem == "Ship")
            {
                TrasportSystem = new Ship()
                {
                    Mode = "Water"
                };

            }

            return TrasportSystem;
        }
    }
}
