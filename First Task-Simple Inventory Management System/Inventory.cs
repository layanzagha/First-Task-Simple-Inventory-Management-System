﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                foreach (Product product in productsList)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("Products List Is Empty");
            }
        }
        public void DeleteProductByName(string productName)
        {
            if (productsList.Count > 0)
            {
                Product? deletedPro = null;
                foreach (Product product in productsList)
                {
                    if (product.Name == productName)
                        deletedPro = product;

                }
                if (deletedPro != null)
                {
                    productsList.Remove(deletedPro);
                    Console.WriteLine($"{deletedPro.Name} removed from the inventory.");
                }
                else
                {
                    Console.WriteLine($"{productName} not found in the inventory.");
                }
            }
            else
            {
                Console.WriteLine("Products List Is Empty");
            }
        }

        public void SearchProductByName(string productName)
        {
            if (productsList.Count > 0)
            {
                foreach (Product product in productsList)
                {
                    if (product.Name == productName)
                    {
                        Console.WriteLine($"Product Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
                    }
                    else
                    {
                        Console.WriteLine($"{productName} not found in the inventory.");
                    }

                }
            }
            else
            {
                Console.WriteLine("Products List Is Empty");
            }

        }

        public void EditProductByName(string productName , Product newProduct)
        {
            Product? oldProducted = null;
            if (productsList.Count > 0)
            {
                foreach (Product product in productsList)
                {
                    if (product.Name == productName)
                        oldProducted = product;
                }
                if (oldProducted != null)
                {
                    oldProducted.Name = newProduct.Name;
                    oldProducted.Price = newProduct.Price;
                    oldProducted.Quantity = newProduct.Quantity;
                    Console.WriteLine($"{productName} has been edited");
                }
                else
                {
                    Console.WriteLine($"{productName} not found in the inventory.");
                }
            }
            else
            {
                Console.WriteLine("Products List Is Empty");
            }

        }
        public void Exit()
        {
            Environment.Exit(0);
        }

    }
}
