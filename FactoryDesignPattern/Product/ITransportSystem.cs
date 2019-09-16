namespace FactoryDesignPattern
{
    interface ITransportSystem
    {
        void PrintType();
        string Mode { get; set; }
    }
}
