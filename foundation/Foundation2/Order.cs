using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (!_customer.IsFromUSA())
        {
            totalCost += 35;
        }
        else
        {
            totalCost += 5;
        }
        return totalCost;
    }

    public void DisplayOrderDetails()
    {
        _customer.Display();
        foreach (Product product in _products)
        {
            product.Display();
        }
        Console.WriteLine($"Total Cost: {CalculateTotalCost()}");
        DisplayPackingLabel();
        DisplayShippingLabel();
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetPackingLabel());
        } 
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        _customer.Display();
    }
}