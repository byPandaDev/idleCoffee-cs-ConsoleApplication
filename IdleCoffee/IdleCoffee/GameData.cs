using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace idleCoffeeGameData
{
    public class GameData
    {
        // Set Path and Products
        static string dataPath = "./data/";
        static string[] allproducts = { "Coffee;100;5", "Cocoa;250;15", "Donut;500;30", "Cake;1000;75", "Tea;2500;125", "Limonade;4000;250", "Croissant;6000;375", "Pretzel;10000;500" };

        public static string[] getProducts()
        {
            /// Check if all files exists and everything is setup correctly /// 
            // Check If Dir exist
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath); // Create Dir if not exist
            }
            // Check if products file exist
            if (!File.Exists(dataPath + "products.txt"))
            {
                File.WriteAllLines(dataPath + "products.txt", allproducts, Encoding.UTF8); // If not, create and write data
            }
            string[] productdata = File.ReadAllLines(dataPath + "products.txt", Encoding.UTF8); // Read File
            // Check if lines length is equal to allproducts array length
            if (productdata.Length != allproducts.Length)
            {
                // If not clear and set new
                File.WriteAllText(dataPath + "products.txt", String.Empty);
                File.WriteAllLines(dataPath + "products.txt", allproducts, Encoding.UTF8);
                productdata = File.ReadAllLines(dataPath + "products.txt", Encoding.UTF8);
            }
            foreach (string product in productdata)
            {
                // Check if the lines exist in allproducts array
                if(!allproducts.Contains(product))
                {
                    // If not clear and set new
                    File.WriteAllText(dataPath + "products.txt", String.Empty);
                    File.WriteAllLines(dataPath + "products.txt", allproducts, Encoding.UTF8);
                    productdata = File.ReadAllLines(dataPath + "products.txt", Encoding.UTF8);
                }
            }

            return productdata;
            
        }

        public static string[] getStorageProducts()
        {
            /// Check if all files exists and everything is setup correctly /// 
            // Check If Dir exist
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath); // Create Dir if not exist
            }
            // Check if products file exist
            if (!File.Exists(dataPath + "storage.txt"))
            {
                File.WriteAllText(dataPath + "storage.txt", "", Encoding.UTF8); // If not, create and write data
            }
            string[] productdata = File.ReadAllLines(dataPath + "storage.txt", Encoding.UTF8); // Read File
            if(productdata.Length==0) return productdata;
            // variables
            List<string> list = new List<string>();
            // Clear the product variabels
            list.Clear();
            // Get Products from File
            int productsLength = productdata.Length;
            // Remove the ';'
            // Check if lines length is equal to allproducts array length
            for (int i = 0; i < productsLength; i++)
            {
                if (allproducts.Contains(productdata[i]))
                {
                    list.Add(productdata[i]);
                }
            }
            productdata = list.ToArray();
            File.WriteAllText(dataPath + "storage.txt", String.Empty);
            File.WriteAllLines(dataPath + "storage.txt", productdata, Encoding.UTF8);
            return productdata;
        }

        public static int getAccountBalance()
        {
            /// Check if all files exists and everything is setup correctly /// 
            // Check If Dir exist
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath); // Create Dir if not exist
            }
            // Check if products file exist
            if (!File.Exists(dataPath + "balance.txt"))
            {
                File.WriteAllText(dataPath + "balance.txt", "100", Encoding.UTF8); // If not, create and write data
            }
            string[] balance = File.ReadAllLines(dataPath + "balance.txt", Encoding.UTF8); // Read File
            int[] accountbalance = {};
            try
            {
                // Try parse balance to int
                accountbalance = Array.ConvertAll(balance, b => int.Parse(b));
            }
            catch
            {
                // if not rewrite file
                File.WriteAllText(dataPath + "balance.txt", String.Empty);
                File.WriteAllText(dataPath + "balance.txt", "100", Encoding.UTF8);
                balance = File.ReadAllLines(dataPath + "balance.txt", Encoding.UTF8);
                accountbalance = Array.ConvertAll(balance, b => int.Parse(b));
            }
            // Check if lines length is equal to allproducts array length
            if (balance.Length != 1)
            {
                // If not clear and set new
                File.WriteAllText(dataPath + "balance.txt", String.Empty);
                File.WriteAllText(dataPath + "balance.txt", "100", Encoding.UTF8);
                balance = File.ReadAllLines(dataPath + "balance.txt", Encoding.UTF8);
                accountbalance = Array.ConvertAll(balance, b => int.Parse(b));
            }
            // Save account balance in int and return it
            string output = "";
            int bal;
            foreach (int num in accountbalance)
            {
                output += num.ToString();
            }
            bal = int.Parse(output);

            return bal;
        }
        
    }
}
