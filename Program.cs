using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();

            Console.WriteLine("Welcome to the pizza pie!");

            bool makingOrder = true;
            while (makingOrder)
            {


                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Choose pizza size - they're all large!");
                Console.WriteLine("2. Want the works? Add extra toppings for $4.");
                Console.WriteLine("3. Is this for delivery?");
                Console.WriteLine("4. When do you want your order ready?");
                Console.WriteLine("5. Thirsty? Add a pop for $2!");
                Console.WriteLine("6. Check order details.");
                Console.WriteLine("7. Confirm your order here!");
                Console.WriteLine("8. Exit and order burgers.");

                var pizzaChoice = Console.ReadLine();

                switch (pizzaChoice)
                {

                    case "1":
                        Console.WriteLine("What size pizza would you like? Please enter the number 1. Large, 2. Larger or 3. Largest?");
                        pizza.PizzaSize();
                break;

                    case "2":
                        pizza.Toppings();
                Console.WriteLine("I'll add pepperoni, extra cheese and pineapple to your pizza. That'll add $4 to your order.");
                break;

                    case "3":
                        pizza.IsDelivery();
                        break;

                    case "4":

                        break;

                    case "5":
                        pizza.AddPop();
                Console.WriteLine("An ice cold soda is tasty with a hot pizza pie! That'll be an extra $2.");
                break;

                    case "6":
                        int currentPrice = pizza.OrderDetails();
                Console.WriteLine($"Your order will cost {currentPrice:C2}");
                break;

                    case "7":
                        int finalPrice = pizza.OrderDetails();
                        string finalPizzaSize = pizza.PizzaSize();
                Console.WriteLine($"That will be {finalPrice:C2}, see you soon!");
                makingOrder = false;
                break;

                    case "8":
                        Console.WriteLine("I didn't feel like doing work anyway. Bye.");
                makingOrder = false;
                break;

                default:
                        Console.WriteLine("That doesn't compute, my friend! Pick another option!");
                break; 
                }
            }
        }
                }
            
            }
