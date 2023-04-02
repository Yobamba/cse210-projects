public class Customer 
{
    private Address _customerAddress = new Address();
    private string _customerName;

    public Customer(string customerName, Address customerAddress) 
    {
        _customerAddress = customerAddress;
        _customerName = customerName;
    }

    // public Customer(List<Product> prodList, Customer customer) 
    // {
    //     _prodList = prodList;
    //     _customer = customer;
    // }

    public Customer() 
    {

    }

    public string GetCustomerName() 
    {
        return _customerName;
    }

    public string GetCustomerCountry() 
    {
        return _customerAddress.GetCountry();
    }

    public string GetCustomerAddress() 
    {
        return _customerAddress.GetFullAddress();
    }
    
    

}