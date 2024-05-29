public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipcode;
    public Address(string streetAddress, string city, string state, int zipcode){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    public string GetAddress(){
        return $"\n{_streetAddress}\n{_city}, {_state}\n{_zipcode}";
    }
}