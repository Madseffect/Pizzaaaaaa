using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Order
    {
        //Order indeholder to klasser istedet for string,int eller bools, så en order har en pizza og en customer. Man kan også lave en List<Pizza> så den kan have flere pizzaer. Se udkommenterede property Pizzas
        public Pizza Pizza { get; set; }
        public Customer Customer { get; set; }
        public double TotalPrice { get; set; }

        public Order(Pizza pizza, Customer customer, double totalPrice)
        {
            Pizza = pizza;
            Customer = customer;
            TotalPrice = totalPrice;
        }

        //public List<Pizza> Pizzas { get; set; }



        public override string ToString()
        {
            return String.Format(Customer.ToString()+ Environment.NewLine+Pizza.ToString()+Environment.NewLine+TotalPrice);
        }

       
    }
}
