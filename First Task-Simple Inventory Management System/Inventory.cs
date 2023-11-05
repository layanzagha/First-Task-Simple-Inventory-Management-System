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

    }
}
