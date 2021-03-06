﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Pizza
    {
        public Pizza()
        {
            Price = 20;
            YesDelivery = false;
        }

        public int Price { get; set; }

        public bool YesDelivery { get; set; }

        public string Size { get; set; }

        public int Topping { get; set; }

        public int PopsAdded { get; set; }

        public void SetPizzaSize(string pizzaSize)
        {
            switch (pizzaSize)
            {
                case "1":
                    Console.WriteLine("You chose a large pizza.");
                    Size = "Large";
                    break;
                case "2":
                    Console.WriteLine("You chose a larger pizza.");
                    Size = "Larger";
                    Price += 2;
                    break;
                case "3":
                    Console.WriteLine("You chose a largest pizza! Mamma mia!");
                    Size = "Largest";
                    Price += 4;
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
        public int OrderToppings()
        {
            return Topping;
        }

        public int TotalPops()
        {
            return PopsAdded;
        }
        public void SetDelivery()
        {
            Console.WriteLine("Would you like this delivered? Please enter y for yes or n for no.");
            string deliveryChoice = Console.ReadLine();
            if (deliveryChoice == "y")
            {
                YesDelivery = true;
                Console.WriteLine("Ok, this will be for delivery!");
            }
        }

        public void AddPop()
        {
            Price += 2;
            PopsAdded += 1;
        }

        public void Toppings()
        {
            Price += 4;
            Topping += 1;
        }
    }
}
