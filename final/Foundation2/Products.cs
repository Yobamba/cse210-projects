public class Product 
{
    private string _prodName;
    private string _prodID;
    private float _price;
    private float _quantity;

    public float CalculatePrice() 
    {
        float priceToPay = _price * _quantity;
        return priceToPay;
    }

}