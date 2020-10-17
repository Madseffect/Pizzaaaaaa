using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pizza
    {
        //properties med get og set(skriv prop og tab 2 gange)
        public string PizzaName { get; set; }
        public bool ExtraCheese { get; set; }
        public double Price { get; set; }

        //konstruktør
        public Pizza(string pizzaName, bool extraCheese, double price)
        {
            PizzaName = pizzaName;
            ExtraCheese = extraCheese;
            Price = price;
        }



        //tostring metode override
        public override string ToString()
        {
            return String.Format("Name:{0}, Extra cheese:{1}, Price{2}", PizzaName,  ExtraCheese,Price);
        }

       
    }
}
