// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.ComponentModel.Design;
// for the list<object> later
using FoodBankInventory; 

Console.WriteLine("Welcome to the food bank inventory system!");

List<object> foodItems= new List<object>();
    // create an array-like object that can store a dynamic number of objects:

int loopConstant = 0;
while (loopConstant == 0)
{
    // main menu
    Console.WriteLine("");
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Add Food Item");
    Console.WriteLine("2. Delete Food Item");
    Console.WriteLine("3. View Food Items");
    Console.WriteLine("4. Exit the program");
    Console.WriteLine("Type a number 1-4 to select: ");
    int choice = int.Parse(Console.ReadLine());
    
    if (choice == 1)
        // add food items
    {
        Console.WriteLine("");
        Console.WriteLine("Enter the name of the food item you'd like to add: ");
        string foodName = Console.ReadLine();
            // prompts user for name of food and saves it in a variable (continues down the line)

        Console.WriteLine("");
        Console.WriteLine("Enter a category for the food item (e.g. Dairy, Produce): ");
        string foodCategory = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("What is the quantity of this food item? Enter a number: ");
        int foodQuantity = int.Parse(Console.ReadLine());
        if (foodQuantity > 0)
            // error handling to make sure the user inputs a valid quantity greater than 0.
        {
            Console.WriteLine("");
            Console.WriteLine("Enter the expiration date (MM/DD/YYYY): ");
            string expirationDate = Console.ReadLine();

            foodItems.Add(new FoodItem(foodName, foodCategory, foodQuantity, expirationDate));
            // this is where the code will enter the information into a new FoodItem class object
            // (within parentheses), and also add it to the list foodItems.

            Console.WriteLine("");
            Console.WriteLine($"Food item '{foodName}' was added to the database.");
        }
        else 
        {
            Console.WriteLine("Quantity must be a whole number greater than 1.");
        }
    }

    else if (choice == 2)
        // delete food items
    {
        if (foodItems.Count > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("List of current food items:");
            int itemCounter = 1;
            foreach (FoodItem foodItem in foodItems)
                // loops through each item in the list of items
            {
                Console.WriteLine($"{itemCounter}:  {foodItem.GetName()}");
                itemCounter++;
            }

            Console.WriteLine($"Enter the number of the item you'd like to delete (1-{itemCounter - 1}):");
            int foodToDelete = int.Parse(Console.ReadLine());
                // prompts the user to enter the number of the food they'd like to delete
            if (foodToDelete > 0 && foodToDelete <= foodItems.Count)
                // error handling to see if the number is in the correct range
            {
                foodItems.RemoveAt(foodToDelete - 1); 
                    // finds the index of the item that you want to delete
                Console.WriteLine("");
                Console.WriteLine("Successfully deleted.");
            }
            else
            {
                Console.WriteLine("Error: Please select a valid option.");
            }
        }
        else
        {
            Console.WriteLine("No items in system to delete!");
        }
    }

    else if (choice == 3)
        // view food items
    {
        int itemCounter = 1;
        if (foodItems.Count > 0)
            // checks if there are even items in the system to view
        {
            foreach (FoodItem foodItem in foodItems)
                // loops through each item in the foodItems list and prints out all attributes using the
                // built-in Get methods
            {
                Console.WriteLine("");
                Console.WriteLine($"Item {itemCounter}:");
                Console.WriteLine($"Name: {foodItem.GetName()}");
                Console.WriteLine($"Category: {foodItem.GetCategory()}");
                Console.WriteLine($"Quantity: {foodItem.GetQuantity()}");
                Console.WriteLine($"Expiration Date: {foodItem.GetExpirationDate()}");
                itemCounter++;
            }
        }
        else
        {
            Console.WriteLine("No items in system to view!");
        }
    }

    else if (choice == 4)
        // to exit the system
    {
        loopConstant = 1;
        Console.WriteLine("Exiting the program...");
    }

    else
        // error handling for invalid inputs not 1-4 on the main menu
    {
        Console.WriteLine("Error: Please select a valid option (numbers 1-4).");
    }
}