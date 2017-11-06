using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab10
{
    class Inventory
    {
        // Code that displays dealer inventory
        public static void DisplayInventory(List<string> keys, ArrayList vehicles)
        {
            Console.WriteLine($"{"Key",-5}{"Make",-15}{"Model",-20}{"Year",-5}{"Price",15}{"Miles",20}");
            Console.WriteLine("================================================================================");
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i] is UsedCars)
                {
                    Console.WriteLine($"{keys[i],-5}" + vehicles[i].ToString());
                }
                else
                {
                    Console.WriteLine($"{keys[i],-5}" + vehicles[i].ToString());
                }
            }
            Console.WriteLine("================================================================================");
        }

        // Code that removes the key and vehicle after the user adds it to their cart
        public static void RemoveCar(List<string> keys, ArrayList vehicles, int index)
        {
            keys.RemoveAt(index);
            vehicles.RemoveAt(index);
        }
    }
}
