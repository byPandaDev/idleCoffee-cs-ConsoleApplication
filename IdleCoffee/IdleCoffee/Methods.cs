using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IdleCoffeeGame;
using idleCoffeeGameData;

namespace IdleCoffeeMethods
{
    public static class Methods
    {
        static string gameName = "idleCoffee";
        static string gameVersion = "1.0.0";
        static string developer = "byPandaDev";

        static int tableWidth = 75;

        public static void HomeScreen()
        {
            ConsoleKeyInfo button;
            Console.Clear();
            // Set the text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Set Title and print the Game Name
            Console.Title = gameName + " | v" + gameVersion;
            Console.WriteLine("██╗██████╗ ██╗     ███████╗ ██████╗ ██████╗ ███████╗███████╗███████╗███████╗");
            Console.WriteLine("██║██╔══██╗██║     ██╔════╝██╔════╝██╔═══██╗██╔════╝██╔════╝██╔════╝██╔════╝");
            Console.WriteLine("██║██║  ██║██║     █████╗  ██║     ██║   ██║█████╗  █████╗  █████╗  █████╗  ");
            Console.WriteLine("██║██║  ██║██║     ██╔══╝  ██║     ██║   ██║██╔══╝  ██╔══╝  ██╔══╝  ██╔══╝  ");
            Console.WriteLine("██║██████╔╝███████╗███████╗╚██████╗╚██████╔╝██║     ██║     ███████╗███████╗");
            Console.WriteLine("╚═╝╚═════╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝     ╚══════╝╚══════╝");
            Console.ForegroundColor = ConsoleColor.Gray;
            // Game Info
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("Game: " + gameName);
            Console.WriteLine("Version: " + gameVersion);
            Console.WriteLine("Developer: " + developer);
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            // Selection Menu
            Console.WriteLine("\n1. Start Game");
            Console.WriteLine("2. Introduction");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\nPress one of the printed numbers on your keyboard to continue");
            // Read The Pressed Key
            button = Console.ReadKey();

            switch (button.Key)
            {
                case ConsoleKey.D1:
                {
                    //Start New Game
                    GameScreen();
                    break;
                }
                case ConsoleKey.D2:
                {
                    // Introduction to the Game
                    Introduction();
                    break;
                }
                case ConsoleKey.D3:
                {
                    //exit Game
                    Environment.Exit(0);
                    break;
                }
                default:
                    // If Wrong Button was pressed
                    HomeScreen();
                    break;

            }
        }

        public static void GameScreen()
        {
            Console.Title = "Home | idleCoffee";
            ConsoleKeyInfo button;
            Console.Clear();
            // Display Selection Options
            Console.WriteLine(">> Selection Menu");
            Console.WriteLine("\n1. Storage");
            Console.WriteLine("2. Shop");
            Console.WriteLine("3. Farming");
            Console.WriteLine("4. Help");
            Console.WriteLine("5. Home");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\nPress one of the printed numbers on your keyboard to continue");

            button = Console.ReadKey();

            switch (button.Key)
            {
                case ConsoleKey.D1:
                    {
                        //Storage
                        Game.Storage();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        //Shop
                        Game.Shop();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        //Farming
                        Game.Farming();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        //Help Menu
                        Introduction();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        //exit Game
                        HomeScreen();
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        //exit Game
                        Environment.Exit(0);
                        break;
                    }
                default:
                    // If Wrong Button was pressed
                    GameScreen();
                    break;

            }
        }

        public static void Introduction()
        {
            // Clear Console, set Title
            Console.Clear();
            Console.Title = "Introduction | idleCofee";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("██╗███╗   ██╗████████╗██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗██╗ ██████╗ ███╗   ██╗");
            Console.WriteLine("██║████╗  ██║╚══██╔══╝██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝██║██╔═══██╗████╗  ██║");
            Console.WriteLine("██║██╔██╗ ██║   ██║   ██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║   ██║██║   ██║██╔██╗ ██║");
            Console.WriteLine("██║██║╚██╗██║   ██║   ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║   ██║██║   ██║██║╚██╗██║");
            Console.WriteLine("██║██║ ╚████║   ██║   ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║   ██║╚██████╔╝██║ ╚████║");
            Console.WriteLine("╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝\n");
            Console.ForegroundColor = ConsoleColor.White;
            //Introduction Text
            Console.WriteLine("Hey,\nWelcome to idleCoffee. IdleCoffee is a simple idle game where you can buy products,\nfarm money and grow your own buisness.");
            Console.WriteLine("\nIt was just a little project to learn the basics of C# and how to work with files to save data.\nSo please don't be disappointed, if you beat the game fast\n\n");

            //Help
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">Storage:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In Storage you can see all products you currently own,\nsee how much your salary is and how much money you have\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">Shop:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In the Shop you can see all available products, how much they cost, how much salary you get from it.\nYou can buy new products by typing their name.\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">Farming:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In Farming you can earn money to buy new products.\nEvery 2.5 seconds the shown salary will add to you bank account");
            
            //Exit introduction
            Console.WriteLine("\n>>Press ENTER key to exit");
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.Enter) HomeScreen();
            else Introduction();

        }

        public static bool BuyItem(int index)
        {
            List<string> list = new List<string>();
            list.Clear();
            // Get Products from File
            string[] products = GameData.getProducts();
            // save products in extra variable
            string[] allprd = products;
            // Get Storage Products
            string[] storageProducts = GameData.getStorageProducts();
            // Get Account Balance
            int accountBalance = GameData.getAccountBalance();
            int shopProductsLength = products.Length; // Save storage length
            string[] prices = { };
            // Renive all ';' from the array
            string prd = string.Join(" ", products);
            products = prd.Split(';');
            prd = string.Join(" ", products);
            products = prd.Split(' ');

            for (int i = 0; i <= shopProductsLength - 1; i++)
            {
                // Add every second element(price) to the list
                int second = 3 * i + 1;
                list.Add(products[second]);
            }
            // Convert list to array
            prices = list.ToArray();
            // Check if Storagelength is 0 or storage wont contains product
            if (storageProducts.Length == 0 || !storageProducts.Contains(allprd[index]))
            {
                // Check accountbalance is lower than price
                if (accountBalance < int.Parse(prices[index])) return false;
                // If not add Product to storage and write to file
                File.AppendAllText("./data/storage.txt", allprd[index] + Environment.NewLine);
                // Update account balance by -productprice
                updateAccountBalance(int.Parse(prices[index]), false);
                return true;
            }
            else return false;

        }

        public static int updateAccountBalance(int number, bool boolean)
        {
            // Get Account Balance
            int accountBalance = GameData.getAccountBalance();
            // If bool true add money to account balance, else remove
            if (boolean) accountBalance += number;
            else accountBalance -= number;
            // Save new account balance to file and return it
            File.WriteAllText("./data/balance.txt", accountBalance.ToString(), Encoding.UTF8);
            accountBalance = GameData.getAccountBalance();
            return int.Parse(accountBalance.ToString());

        }

        // CREATE TABLE
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
