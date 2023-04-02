public class Order 
{
    private List<Product> _prodList = new List<Product>();
    private Customer _customer = new Customer();

    private string _shippingLabel;
    
    

    public Order(Customer customer, List<Product> productList) 
    {
        _customer = customer;
        _prodList = productList;
        _shippingLabel = "Ship to: " + _customer.GetCustomerName() + " at " + customer.GetCustomerAddress();

    }

    public List<Product> GetProductList() 
    {
        return _prodList;
    }

    public string ShowPackagingLabels(List<Product> produtos) 
    {
        string packagingLabels = produtos[0].ShowPackingLabel();
        for (int i = 1; i < produtos.Count; i++) 
        {
            packagingLabels = packagingLabels + ", " + "\n" + produtos[i].ShowPackingLabel();
        }
        Console.WriteLine("Packaging Labels: ");
        
        return packagingLabels;
    }

    public Customer GetCustomer() 
    {
        return _customer;
    }

    
    public string CalculateOrderCost(List<Product> listOfProducts) 
    {
        float cost = 0;

        if (_customer.GetCustomerCountry() == "USA") 
                      
        {
            cost = cost + 5;
        }

        else 
        {
            cost = cost + 35;
        }

        Console.WriteLine($"Testing CalculateOrderCost: {_customer.GetCustomerCountry()}" );
        
        // for (int i = 0; i < listOfProducts.Count; i++) 
        // {
        //     if (listOfProducts[i].)
        //     _customer
        //     cost = cost + listOfProducts[i].GetPrice() * listOfProducts[i].GetQuantity();
           
            
            
        // }
        for (int j = 0; j < listOfProducts.Count; j++) 
        {
         
            cost = cost + listOfProducts[j].GetPrice() * listOfProducts[j].GetQuantity();
            
            
            
        }
        return $"Total cost: $  {cost}";
    }

    public string GetShippingLabel() 
    {
        Console.WriteLine();
        Console.WriteLine("Shipping Labels: ");
        return _shippingLabel;
    }

}