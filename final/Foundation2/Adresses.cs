public class Address 
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Address() 
    {
        
    }

    public Address(string streetAdress, string city, string state, string country) 
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }

    

    public string GetCountry() 
    {
        return _country;
    }

    public string GetFullAddress() 
    {
        return _streetAdress + ", " + _city + ", " + _state + ", " + _country; 
    }
}