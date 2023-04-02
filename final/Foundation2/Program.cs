using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your name? ");
        string clientName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What's your street address? ");
        string clientStreet = Console.ReadLine();
        Console.WriteLine();
        Console.Write("City? ");
        string clientCity = Console.ReadLine();
        Console.WriteLine();
        Console.Write("State? ");
        string clientState = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Country? ");
        string clientCountry = Console.ReadLine();
        Console.WriteLine();

        Address clientAddress = new Address(clientStreet, clientCity, clientState, clientCountry);
        Customer client = new Customer(clientName, clientAddress);

        List<Product> AddProducts() 
        {
            bool done = false;
            List<Product> prodList = new List<Product>();
            while (done == false) 
            {
                Console.Write("Enter the product's name: ");
                string productName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the product's ID: ");
                string productID = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the products price: ");
                string productPrice = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter the quantity: ");
                string productQuantity = Console.ReadLine();
                Console.WriteLine();

                Product product = new Product(productName, productID, float.Parse(productPrice), float.Parse(productQuantity));
                
                if (prodList.Count > 2) 
                {
                    done = true;
                }

                Console.Write("Would you like to add another product? (y/n)");
                string response = Console.ReadLine();

                if (response != "y") 
                {
                    done = true;
                }
                prodList.Add(product);
                
            } 

            return prodList;
        }
        
        
        List<Product> returnedProductList = new List<Product>();
        returnedProductList = AddProducts();
        Order order = new Order(client, returnedProductList);
       
        Console.Write(order.ShowPackagingLabels(order.GetProductList()));
        Console.WriteLine();
        Console.Write(order.GetShippingLabel());
        Console.WriteLine();
        Console.Write(order.CalculateOrderCost(returnedProductList));

    }
}