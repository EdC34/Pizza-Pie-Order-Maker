using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Pizza
    {
        public Pizza()
        {
            Price = 20;
        }
        public int Price { get; set; }

        public int PizzaSize()
        {
            switch (pizzaSize)
            {
                case "1":
                    Console.WriteLine("You chose a large pizza.");
                    break;
                case "2":
                    Console.WriteLine("You chose a larger pizza.");
                    break;
                case "3":
                    Console.WriteLine("You chose a largest pizza! Mamma mia!");
                    break;
                default:
                    Console.WriteLine("Mamma mia! Not an option!");
                    break;
            }
            return;
        }
        public int OrderDetails()
        {
            return Price;
        }
        public int IsDelivery()

        { 
           return 
        }
        public void AddPop()
        {
            Price += 2;
        }
        public void Toppings()
        {
            Price += 4;
        }
    }
}
