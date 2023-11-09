using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task_Simple_Inventory_Management_System
{
    public class Product
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Product(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

    }
}
