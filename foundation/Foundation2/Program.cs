using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation #2: Encapsulation with Online Ordering");
        Console.WriteLine("");

        Customer customer1 = new Customer("Ericson Suarez", new Address("Winston", "Cedar City", "Utah", "USA"));
        Customer customer2 = new Customer("Louie Gualingco", new Address("Brgy. Bata", "Bacolod City", "Negros Occidental", "Philippines"));

        Product product1 = new Product("PVC", 111111, 55, 5);
        Product product2 = new Product("showerhead", 222222, 55.55, 10);

        Product product3 = new Product("widespread bath faucet", 333333, 100, 2);
        Product product4 = new Product("acrylic bathtub", 444444, 150, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1: ");
        order1.DisplayOrderDetails();

        Console.WriteLine("\nOrder 2:");
        order2.DisplayOrderDetails();
    }
}