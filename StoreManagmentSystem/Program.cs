// Mark Shinozaki
// FINAL EXAM
// Store Managment System 

using System;
using StoreManagmentSystem;

namespace StoreApp
{

    class Program
    { 
        static void Main(string[] args)
        {
            
            Store store = new Store(); // creates a new instance
                                       // of the Store class and assigns it to a 
                                       // variable named store

            while (true)
            {
                Console.WriteLine("\n-----Welcome to the Store Management System!-----\n"); // Menu 
                Console.WriteLine("\n\t1. Create A Product ");
                Console.WriteLine("\n\t2. Search For A Product ");
                Console.WriteLine("\n\t3. Restock Products ");
                Console.WriteLine("\n\t4. Quit ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    ///<summary>
                    ///This part is where you enter each of the necessary 
                    ///product details
                    /// </summary>
                    /// 
                    case "1":
                        Console.WriteLine("\nEnter product type (p/e):");
                        Console.WriteLine("\t(p/physical) (e/electonic)");

                        char type = char.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product ID:");
                        Console.WriteLine("\t(ex. 0123 / 1111)");

                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product description:");
                        Console.WriteLine("\t(ex. Backpack/e-Book)");

                        string description = Console.ReadLine();
                        store.CreateProduct(type, id, description);
                        Console.WriteLine("\nProduct created successfully!\n");

                        ///<summary>
                        ///This loop was an extra additive because having to go 
                        ///back to menu to enter each product is time consuming 
                        /// </summary>
                        Console.WriteLine("Would you like to add another product (y or n)?");
                        string input = Console.ReadLine().ToLower();
                        if (input == "y")
                        {
                            do
                            {
                                Console.WriteLine("\nEnter product type (p/e):");
                                Console.WriteLine("\t(p/physical) (e/electonic)");

                                char type2 = char.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter product ID:");
                                Console.WriteLine("\t(ex. 0123 / 1111)");

                                int id2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nEnter product description:");
                                Console.WriteLine("\t(ex. Backpack/e-Book)");

                                string description2 = Console.ReadLine();
                                //Product product = new Product(type, id, description);
                                store.CreateProduct(type2, id2, description2);

                                Console.WriteLine("Would you like to add another product (y or n)?");
                                string input2 = Console.ReadLine().ToLower();

                                if (input2 == "y")
                                {
                                    input = "y";
                                }
                                else
                                {
                                    break;
                                }
                            }
                            while (input != "n");
                                
                      
                        }
                        else
                        {
                            break;
                        }
                        break;

                    ///<summary>
                    ///Searching products, if space is entered then every product is shown
                    ///Uses ID value and description 
                    /// </summary>
                    case "2":
                        Console.WriteLine("\nEnter search query:");
                        string query = Console.ReadLine();
                        store.SearchProduct(query);
                        break;
                    
                    ///<summary>
                    /// This calls restock and intitally asks for the 1st search
                    /// parameter in the 2 step process which is by current product quantity
                    /// </summary>
                
                    case "3":
                        Console.WriteLine("Enter restock threshold:");
                        int threshold = int.Parse(Console.ReadLine());
                        store.RestockProduct(threshold);
                        break;

                        // exits the program 
                    case "4":
                        Console.WriteLine("Exiting Program...");
                        return;

                        // case for invalid input
                    default:
                        Console.WriteLine("INVALID choice");
                        break;


                }

            }

        }
    
    
    }






























}


