using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mike's Auto Shop!\n\n\"Over one boolean served!!\"\n");

            ArrayList cart = new ArrayList();
            ArrayList vehicles = new ArrayList();
            List<string> keys =  new List<string> { "MKZ","MAL", "CIV","AUD","300","LUM","CTC","NEO","MGM","TAU" };

            vehicles.Add(new Cars("Lincoln", "MKZ", 2017, 34550.00));
            vehicles.Add(new Cars("Chevrolet", "Malibu", 2017, 27900.00));
            vehicles.Add(new Cars("Honda", "Civic", 2017, 21095.00));
            vehicles.Add(new Cars("Audi", "A6", 2017, 39995.00));
            vehicles.Add(new Cars("Chrysler", "300", 2017, 30495.00));
            vehicles.Add(new UsedCars("Chevrolet", "Lumina", 1991, 700.00, 175105));
            vehicles.Add(new UsedCars("Chrysler", "Town & Country", 1999, 1450.00, 130432));
            vehicles.Add(new UsedCars("Dodge", "Neon", 2001, 2095.00, 111913));
            vehicles.Add(new UsedCars("Mercury", "Grand Marquis", 1996, 1695.00, 134388));
            vehicles.Add(new UsedCars("Ford", "Taurus", 2004, 2045.00, 120302));

            bool keepShopping = true;
            while (keepShopping)
            {
                int index = Validator.ValidateInput(keys, vehicles);
                if(index == -1) // -1 is return value if user inputs "END", exits the loop
                {
                    keepShopping = false;
                    continue;
                }
                else if (vehicles[index] is UsedCars)
                {
                    BuyUsedCar(keys, vehicles, cart, index);
                }
                else
                {
                    BuyNewCar(keys, vehicles, cart, index);
                }

                if(vehicles.Count == 0) // Code for when there are no cars left in dealer inventory
                {
                    Console.WriteLine("You have purchased our entire inventory! proceed to checkout.\n");
                    keepShopping = false;
                }
            }

            if (cart.Count > 0) // Only display cart if cars have been purchased
            {
                ShoppingCart.DisplayCart(cart);
                Console.WriteLine("\nThank you for shopping with us!");
            }
            else // Message displays if user exits loop without purchasing anything
            {
                Console.WriteLine("\nDidn't see anything you liked, huh? Check back with us soon to see if we have anything new in stock!");
            }
            Console.ReadLine();
        }

        // Method for purchasing a new car
        public static void BuyNewCar(List<string> keys, ArrayList vehicles, ArrayList cart, int index)
        {
            Cars car = (Cars)vehicles[index]; // Gets car at user-specified index
            cart.Add(new ShoppingCart(car.Make, car.Model, car.Year, car.Price)); // Add car to the shopping cart
            if (index % 2 == 0)
            {
                Console.WriteLine($"\nGreat choice! This {car.Model} is the lowest-priced new model in the area, and you can't beat that new car smell!\n");
            }
            else
            {
                Console.WriteLine($"\nCan't beat a new {car.Make}! Everyone is going to be jealous of you when they see you in this {car.Model}!\n");
            }
            Inventory.RemoveCar(keys, vehicles, index); // Call method to remove vehicle from inventory
        }

        // Method for purchasing a used car
        public static void BuyUsedCar(List<string> keys, ArrayList vehicles, ArrayList cart, int index)
        {
            UsedCars car = (UsedCars)vehicles[index]; // Gets car at user-specified index
            cart.Add(new ShoppingCart(car.Make, car.Model, car.Year, car.Price, car.Miles)); // Add car to the shopping cart
            if (index % 2 == 0)
            {
                Console.WriteLine($"\nGood choice! That {car.Model} has some mileage on it, but it is a steal at {car.Price,0:C}!\n");
            }
            else
            {
                Console.WriteLine($"\nYou know a bargian when you see it! This used {car.Model} still runs like it did when she it brand new!\n");
            }
            Inventory.RemoveCar(keys, vehicles, index); // Call method to remove from inventory
        }
    }
}