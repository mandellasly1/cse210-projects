using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Yenagoa Road", "Yenagoa", "Bayelsa", "Nigeria");
        Address address2 = new Address("456 Amarata Road", "Yenagoa", "Bayelsa", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("Chioma Okafor", address1);
        Customer customer2 = new Customer("Emeka Nwosu", address2);

        // Create products
        Product product1 = new Product("Laptop", 101, 500000, 1);
        Product product2 = new Product("Mouse", 102, 5000, 2);
        Product product3 = new Product("Keyboard", 103, 15000, 1);
        Product product4 = new Product("Monitor", 104, 80000, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product2);

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ₦{order1.GetTotalCost():F2}\n");

        // Display Order 2
        Console.WriteLine("========== ORDER 2 ==========\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ₦{order2.GetTotalCost():F2}\n");
    }
}