using System;

public class Address
{
    private string _stressAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string stressAddress, string city, string stateOrProvince, string country)
    {
        _stressAddress = stressAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public void Display()
    {
        Console.WriteLine($"Address: {_stressAddress}, {_city}, {_stateOrProvince}, {_country}");
    }

    public bool IsFromUSA()
    {
        return _country.ToLower() == "usa";
    }
}