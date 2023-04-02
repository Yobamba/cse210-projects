public class Product 
{
    private string _prodName;
    private string _prodID;
    private float _price;
    private float _quantity;
    private string _packagingLabel;

    public Product(string prodName, string prodID, float price, float quantity) 
    {
        _prodName = prodName;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
        _packagingLabel = "Product Name: " + prodName + "; " + "Product ID: " + prodID + "; Price " + "$"  + price + "; Quantity:" + " " + quantity;

    } 

    public float GetPrice() 
    {
        return _price;
    }

    public float GetQuantity() 
    {
        return _quantity;
    }

    // public string ToString() 
    // {

    // }
      

    public string ShowPackingLabel() 
    {
        return _packagingLabel;
    }

    public float CalculatePrice() 
    {
        float priceToPay = _price * _quantity;
        return priceToPay;
    }

}