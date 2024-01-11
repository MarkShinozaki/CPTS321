using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using StoreApp;

namespace StoreManagmentSystem
{
    class Store
    {
        /// <summary>
        /// creates a public field named Inventory inside of the store class
        /// which is a List of Product objects
        /// 
        /// - A List is a data structure that allows you to store and manipulate
        /// a collection of objects
        /// </summary>
        public List<Product> Inventory = new List<Product>();

        /// <summary>
        /// CreateProduct, is a method of the store class and it is used to create 
        /// a new Product object and add it to the Inventory list 
        /// 
        /// - It takes three parameters, type, id, description 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        public void CreateProduct(char type, int id, string description)
        {
            Product newProduct = new Product();
            newProduct.Type = type;
            newProduct.ID = id;
            newProduct.Description = description;
            newProduct.Quantity = (type == 'p') ? 0 : int.MaxValue;
            Inventory.Add(newProduct);
        }

        
        /// <summary>
        /// SearchProduct method, is a memeber of the Store class and it is used
        /// to Search Inventory list for products that match specified query 
        /// </summary>
        /// <param name="query"></param>
        public void SearchProduct(string query)
        {
            string[] tokens = query.Split(' ');

            bool isAndSearch = true;
            if (tokens.Length > 0)
            {
                int spaceCount = tokens.Length - 1;
                if (spaceCount > 1)
                {
                    Console.WriteLine("Search query contains multiple tokens. " +
                        "\nWould you like to search for products that match all tokens (enter 'and') or products that match at least one token (enter 'or')?");
                    string searchTypeInput = Console.ReadLine();
                    if (searchTypeInput.ToLower() == "or")
                    {
                        isAndSearch = false;
                    }
                }
            }

            List<Product> matchedProducts = new List<Product>();

            foreach (Product product in Inventory)
            {
                bool isMatch = false;


                foreach (string token in tokens)
                {
                    string lowerCaseToken = token.ToLower();
                    if (product.ID.ToString().ToLower().Contains(lowerCaseToken) || product.Description.ToLower().Contains(lowerCaseToken))
                    {
                        isMatch = true;
                        if (isAndSearch == false)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (isAndSearch == true)
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }

                if (isMatch)
                {
                    matchedProducts.Add(product);
                }
            }

            foreach (Product matchedProduct in matchedProducts)
            {
                Console.WriteLine("\nProduct ID: " + matchedProduct.ID);
                Console.WriteLine("Description: " + matchedProduct.Description);
                Console.WriteLine("Quantity: " + matchedProduct.Quantity);
                Console.WriteLine("----------------");
            }
        }



        public List<Product> GetLowStockProducts(int threshold)
        {
            List<Product> lowStockProducts = new List<Product>();

            foreach (Product product in Inventory)
            {
                if (product.Quantity <= threshold)
                {
                    lowStockProducts.Add(product);
                }
            }

            if (lowStockProducts.Count == 0)
            {
                Console.WriteLine("No low stock products found.");
            }

            return lowStockProducts;
        }


        public void RestockProduct(int threshold)
        {
            List<Product> lowProducts = new List<Product>();
            foreach (Product product in Inventory)
            {
                if (product.Type == 'p' && product.Quantity < threshold)
                {
                    lowProducts.Add(product);
                }
            }

            Console.WriteLine("\nLow Stock Products:");
            foreach (Product product in lowProducts)
            {
                Console.WriteLine("\nProduct ID: " + product.ID);
                Console.WriteLine("Description: " + product.Description);
                Console.WriteLine("Quantity: " + product.Quantity);
            }

            Console.WriteLine("\nDo you want to restock all products? (yes/no)");
            string input = Console.ReadLine();
            if (input == "yes" || input == "y")
            {
                foreach (Product product in lowProducts)
                {
                    Console.WriteLine("\nRestocking Product ID " + product.ID);
                    Console.WriteLine("\nCurrent Quantity: " + product.Quantity);
                    Console.WriteLine("\nRestock Amount for (" + product.Description + ") ?");
                    int restockQuantity = int.Parse(Console.ReadLine());
                    product.Quantity += restockQuantity;
                    Console.WriteLine("\nPurchase successful!");
                    Console.WriteLine("\nUpdated Quantity: " + product.Quantity);
                    Console.WriteLine("\n------------------------");

                }
            }
            else if (input == "no" || input == "n")
            {
                Console.WriteLine("\nWould you like to:");
                Console.WriteLine("\n(1) Do you want to restock each product individually");
                Console.WriteLine("\n(2) Change threshold");
                Console.WriteLine("\n(3) Return to Menu");
                string choice1 = Console.ReadLine();
                switch (choice1)
                {
                    case "1":
                        foreach (Product product in lowProducts)
                        {
                            Console.WriteLine("\nRestock Product ID " + product.ID + "? (yes/no)");
                            string restockInput = Console.ReadLine();
                            if (restockInput == "yes")
                            {
                                Console.WriteLine("\nCurrent Quantity: " + product.Quantity);
                                Console.WriteLine("\nQuantity of " + product.Description + "'s you want to restock?");
                                int restockQuantity = int.Parse(Console.ReadLine());
                                product.Quantity += restockQuantity;
                                Console.WriteLine("\nPurchase successful!");
                                Console.WriteLine("\nUpdated Quantity: " + product.Quantity);
                            }
                        }

                        break;

                    case "2":
                        Console.WriteLine("\nEnter new threshold:");
                        int newThreshold = int.Parse(Console.ReadLine());
                        RestockProduct(newThreshold);
                        break;

                    default:
                        break;



                   
                }
                


            }
        }
    }
}
