using First_Task_Simple_Inventory_Management_System;

Console.WriteLine("Please Enter The Product Name");
string name = Console.ReadLine();

Console.WriteLine("Please Enter The Product Quantity");
string quantityString = Console.ReadLine();
int quantity = int.Parse(quantityString);

Console.WriteLine("Please Enter The Product Price");
string priceString = Console.ReadLine();
int price = int.Parse(priceString);

Product product = new Product(name, quantity, price);
Inventory inventory = new Inventory();

inventory.AddProduct(product);

inventory.ViewAllProducts();