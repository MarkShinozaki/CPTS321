using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem
{
   
    /// <summary>
    /// Product is a class that represents a product in a store
    /// by defining a Product class, i've created instances of it to 
    /// represent different items in the store 
    /// </summary>
    class Product
    {
        public char Type { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }





}
