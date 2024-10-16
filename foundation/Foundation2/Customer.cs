using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Customer: {_name}");
        _address.Display();
    }

    public bool IsFromUSA()
    {
        return _address.IsFromUSA();
    }
}