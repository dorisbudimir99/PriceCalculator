using System;

namespace PriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter the Product Name");
                string productName = Console.ReadLine();

                Console.WriteLine("Enter the price of the product");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the quantity of product");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the tax rate");
                double tax = double.Parse(Console.ReadLine());

                double total = price * quantity * (1 + tax);


                Console.Write($"Product Name: {productName} \nCost of Product: ${price} \nProduct Quantity: {quantity} \nTotal Price with Tax ${total}");
                while (true)
                {
                    Console.WriteLine("\nWould you like to enter another product?");
                    string answer = Console.ReadLine();

                    if (answer == "yes" || answer == "y")
                    {
                        Console.WriteLine("Enter your next product");
                        break;
                    }

                    else if (answer == "no" || answer == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                    else
                    {
                        Console.WriteLine("Invalid input. Try again");
                    }

                }
            }
        }
    }
}
