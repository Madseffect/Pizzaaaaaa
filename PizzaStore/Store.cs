using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Store
    {
        //metoden start som kaldes i Program.cs
        public void Start()
        {
            //Pizza klassen findes kun som et blueprint. Det blueprint beder vi computeren om at lave en rigtig pizza ud af:
            Pizza pizza1 = new Pizza("Pepperoni pizza", true,100);
            Pizza pizza2 = new Pizza("Kebab pizza", true,95);
            Pizza pizza3 = new Pizza("Salat pizza", false,200);

            //Customer klassen findes kun som et blueprint. Det blueprint beder vi computeren om at lave en rigtig Customer ud af:

            Customer Customer1 = new Customer("Tobias N", "lalavej 2, 2630 t-town", 12345678);
            Customer Customer2 = new Customer("Mads K", "lalavej 4, 2630 t-town", 23456789);
            Customer Customer3 = new Customer("Lol McFaceson", "lalavej 6, 2630 t-town", 34567890);

            //Creating Order objekt
            Order order1 = new Order(pizza1, Customer1,CalculateTotalPrice(pizza1.Price));

            Console.WriteLine(  order1.ToString());
        }
        public double CalculateTotalPrice(double price)
        {
            double pizzaPrice = price;
            double tax = 1.25;
            int deliveryCost = 40;
            return pizzaPrice * tax + deliveryCost;
        }
    }
}
