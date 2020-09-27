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

        public string PizzaSize()
        {
                string[] sizeOfPie = new string[3];
            sizeOfPie[0] = "Large";
            sizeOfPie[1] = "Larger";
            sizeOfPie[2] = "Largest";
            if (Console.ReadLine() == sizeOfPie[0])
                {
                Console.WriteLine($"You have ordered a {sizeOfPie[0]} pizza");
            }
            else if (Console.ReadLine() == sizeOfPie[1])
            {
                Console.WriteLine($"You have ordered a {sizeOfPie[1]} pizza!");
            }
            else
            {
                Console.WriteLine($"You ordered a {sizeOfPie[2]} pizza pie! Mamma mia!");
            }
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
