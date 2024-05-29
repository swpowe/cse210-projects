// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool USA()
    {
        return _address.USA();
    }

    public string GetShippingAddress()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }

    // public void SetAddress(string streetAddress, string city, string state, string country)
    // {
    //     _address.SetAddress(streetAddress, city, state, country);
    // }

    public void SetAddress(string streetAddress, string city, string state, string country)
    {
        Address a = new(streetAddress, city, state, country);
        _address = a;
    }

}