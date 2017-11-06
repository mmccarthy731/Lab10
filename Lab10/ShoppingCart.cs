using System;
using System.Collections;

namespace Lab10
{
    class ShoppingCart
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Miles { get; set; }

        public ShoppingCart(string make, string model, int year, double price, double miles)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Miles = miles;
        }

        public ShoppingCart(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        // Override of the ToString method for ShoppingCart
        public override string ToString()
        {
            return $"{Make,-15}{Model,-20}{Year,-5}{Price,15:C}{Miles,20:N0}";
        }

        // Method that displays the cart when the user is done shopping
        public static void DisplayCart(ArrayList cart)
        {
            double total = 0.0;
            Console.WriteLine("\nYour Cart:");
            Console.WriteLine($"{"Make",-15}{"Model",-20}{"Year",-5}{"Price",15}{"Miles",20}");
            Console.WriteLine("===========================================================================");
            foreach (ShoppingCart car in cart)
            {
                Console.WriteLine(car.ToString());
                double price = car.Price; // Gets the price of the current vehicle
                total += price; // Calculates the total price, adding each vehicle price
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine($"{"Your total: ",43}{total,12:C}");
            double tax = total * 0.06; // Calculate salex tax
            double grandTotal = total + tax; // Calculate total price
            Console.WriteLine($"{"Tax: ",43}{tax,12:C}\n{"Amount due: ",43}{grandTotal,12:C}\n");
        }
    }
}
