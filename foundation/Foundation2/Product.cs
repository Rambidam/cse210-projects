using System;

public class Product
{
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, int productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {_productName}, ID: {_productID}, Price: {_price}, quantity: {_quantity}");
    }

    public string GetPackingLabel()
    {
        return $"Name: {_productName}, Product ID: {_productID}";
    }
}