//Contains the name, product id, price, and quantity of each product.
//The total cost of this product is computed by multiplying the price per unit and the quantity. 
//(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)

public class Product
{
    private string  _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price*_quantity;
    }

    public string GetProductDetails()
    {
        return$"Name: {_name}\nProductId: {_productId}\nPrice: {_price}\nQuantity: {_quantity}\n";
        
    }
}