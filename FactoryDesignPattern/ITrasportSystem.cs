namespace FactoryDesignPattern
{
    interface ITrasportSystem
    {
        void PrintType();
        string Mode { get; set; }
    }
}
