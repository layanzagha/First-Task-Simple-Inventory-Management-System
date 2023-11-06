using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task_Simple_Inventory_Management_System
{
    public class Inventory
    {
       public static List<Product> productsList = new List<Product>();

        public void AddProduct(Product myProduct)
        {
            productsList.Add(myProduct);
       
        }

        public void ViewAllProducts()
        {
            if (productsList.Count > 0)
            {
                foreach (Product product in Inventory.productsList)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("Product List Is Empty");
            }
            }
        }

    }