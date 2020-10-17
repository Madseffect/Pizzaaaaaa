using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store klassen findes kun som et blueprint. Det blueprint beder vi computeren om at lave en rigtig Store ud af:
            Store store = new Store();
            store.Start();
        }
    }
}
