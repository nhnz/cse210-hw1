//Contains a list of products and a customer. Can calculate the total cost of the order. 
//return a string for the packing label. 
//return a string for the shipping label.
//The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
//A packing label should list the name and product id of each product in the order.
//A shipping label should list the name and address of the customer

using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    //Add products to a product list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //total price
    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in _products)
            {
                total += product.GetTotalPrice();
            }
            //shipping costs
            total += _customer.InUSA()? 5m : 35m;
            return total;
    }
    //create packaging label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetProductDetails() +"\n";
        }

        return label;
    }
    
    // shipping labels
    public string GetShippingLabel()
    {
        return$"Shipping Label:\n{_customer.CustomerDetails()}";
    }

}