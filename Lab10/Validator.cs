using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab10
{
    class Validator
    {
        //Method to validate user input for vehicle selection
        public static int ValidateInput(List<string> keys, ArrayList vehicles)
        {
            string input = null;
            bool valid = false;
            while (!valid)
            {
                Inventory.DisplayInventory(keys, vehicles);
                Console.Write("\nPlease enter the three-digit vehicle key for the vehicle you would like (enter \"END\" to proceed to checkout): ");
                input = Console.ReadLine();
                if (input.ToUpper() == "END")
                {
                    return -1; //In main, if index is -1, exit while loop
                }
                else if (input.Length != 3 || !keys.Contains(input.ToUpper())) //Tests if key entered is part of List<string> keys
                {
                    Console.WriteLine("\nInvalid input: key not found. Please try again.\n");
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            int index = keys.IndexOf(input.ToUpper()); //Get index value of key from List<string> keys
            return index;
        }
    }
}
