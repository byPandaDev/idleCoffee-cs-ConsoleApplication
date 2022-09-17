using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using idleCoffeeGameData;
using IdleCoffeeMethods;

namespace IdleCoffeeGame
{
    public class Game
    {

        public static void Shop()
        {
            Console.Title = "Shop | idleCoffee";
            Console.Clear();
            // variables
            string[] productname = {};
            List<string> list = new List<string>();
            string input;
            // Clear the product variabels
            list.Clear();
            Array.Clear(productname, 0, productname.Length);

            // Get Products from File
            string[] products = GameData.getProducts();
            string[] test = products;
            string[] storageProducts = GameData.getStorageProducts();
            int productsLength = products.Length;
            // Remove the ';'
            string prd = string.Join(" ", products);
            products = prd.Split(';');
            prd = string.Join(" ", products);
            products = prd.Split(' ');

            // Create Table
            Methods.PrintLine();
            Methods.PrintRow("Product", "Price", "Earn", "Owned");
            Methods.PrintLine();
            // Print all Products
            for (int i = 0; i <= productsLength - 1; i++)
            {
                // Create Row 
                int first = 3 * i;
                int second = 3 * i + 1;
                int third = 3 * i + 2;
                Methods.PrintRow(products[first], products[second], products[third], storageProducts.Contains(test[i]).ToString());
                // Add product to list
                list.Add(products[first].ToLower().ToString());
            }
            // Add list do product array
            productname = list.ToArray();
            Methods.PrintLine();
            Console.WriteLine("\nYour Account Balance: " + GameData.getAccountBalance());
            // Get The input
            Console.WriteLine("\n>> Enter a Product to buy or back to go back");
            input = Console.ReadLine().ToLower();
            // Go back if input is back/exit
            if (input == "back" ||input == "exit") Methods.GameScreen();

            if (Array.Exists(productname, el => el == input))
            {
                //Add Product to Storage
                bool x = Methods.BuyItem(Array.IndexOf(productname, input));
                if (x)
                {
                    Console.WriteLine("\nYou successfully bought: " + input);
                    Thread.Sleep(2000);
                    Shop();
                }
                else
                {
                    Console.WriteLine("You already own this Product or you have not enough money");
                    Thread.Sleep(2000);
                    Shop();
                }
            }
            else
            {
                Shop();
            }



            Console.ReadKey();

        }

        public static void Storage()
        {
            Console.Title = "Storage | idleCoffee";
            Console.Clear();
            string[] storageProducts = GameData.getStorageProducts();
            int productsLength = storageProducts.Length;
            int salary = 0;
            // Remove the ';'
            string prd = string.Join(" ", storageProducts);
            storageProducts = prd.Split(';');
            prd = string.Join(" ", storageProducts);
            storageProducts = prd.Split(' ');

            // Create Table
            Methods.PrintLine();
            Methods.PrintRow("Product", "Price", "Earn");
            Methods.PrintLine();
            // Print all Products
            for (int i = 0; i <= productsLength - 1; i++)
            {
                // Create Row 
                int first = 3 * i;
                int second = 3 * i + 1;
                int third = 3 * i + 2;
                Methods.PrintRow(storageProducts[first], storageProducts[second], storageProducts[third]);
                salary += int.Parse(storageProducts[third]);
            }
            Methods.PrintLine();
            Console.WriteLine(">>Salary: " + salary);
            Console.WriteLine(">>Account Balance: " + GameData.getAccountBalance());
            Console.WriteLine("\nType back to go back");
            string input = Console.ReadLine();
            if (input == "exit" || input == "back") Methods.GameScreen();
            Storage();
        }

        public static void Farming()
        {
            Console.Title = "Farming | idleCoffee";
            Console.Clear();
            // get content from files
            int accountBalance = GameData.getAccountBalance();
            string[] storageProducts = GameData.getStorageProducts();
            // save product length
            int productsLength = storageProducts.Length;
            int salary = 0;
            // Remove the ';'
            string prd = string.Join(" ", storageProducts);
            storageProducts = prd.Split(';');
            prd = string.Join(" ", storageProducts);
            storageProducts = prd.Split(' ');
            for (int i = 0; i <= productsLength - 1; i++)
            {
                // add up all storageproduct salarys to one
                int third = 3 * i + 2;
                salary += int.Parse(storageProducts[third]);
            }
            do
            {
                // Generate new Money, while enter isn't pressed, else open GameScreen
                while(!Console.KeyAvailable) 
                {
                    Console.Clear();
                    Console.WriteLine("Salary: " + salary);
                    Console.WriteLine(">>Account Balance: " + Methods.updateAccountBalance(salary, true));
                    Console.WriteLine("\nPress Enter key to exit farming");
                    Thread.Sleep(2500);
                }
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Methods.GameScreen();
        }


    }
}
