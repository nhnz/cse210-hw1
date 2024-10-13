using System;

class Program
{
    static void Main(string[] args)
    {
        //The program simulates an online ordering system, 
        //allowing the creation of orders with products. 
        //It calculates total costs, generates packing and shipping labels
        //Classes Customer, Address, Product, Order

//      +----------------------------------+
//      |            Customer              | Store customer details and check if the customer is in USA
//      +----------------------------------+
//      | -Name: string                    |
//      | -Address: Address                |
//      +----------------------------------+
//      | -CustomerDetails(): string       | Customer details 
//      | -InUSA(): bool                   | Check if the customer resides in USA
//      +----------------------------------+
//                      |
//      +----------------------------------+
//      |             Address              | Store address and check if it is USA
//      +----------------------------------+
//      | -Street: string                  |
//      | -City: string                    |
//      | -state: string                   |
//      | -country: string                 |
//      +----------------------------------+
//      | -IsInUSA(): bool                 | Check if address is in USA
//      | -GetFullAddress(): string        | Store address   
//      +----------------------------------+
//                      |  
//      +----------------------------------+
//      |             Product              | Store product details and calculate total cost.
//      +----------------------------------+
//      | -Name: string                    | 
//      | -Product: string                 |
//      | -Price: decimal                  |
//      | -Quantity: int                   | 
//      +----------------------------------+
//      | -GetTotalPrice(): decimal        | Show total price
//      | -GetProductDetails(): string     |    
//      +----------------------------------+
//                      |
//      +----------------------------------+
//      |              Order               | Manage products, calculate total price, and generate labels.
//      +----------------------------------+
//      | -Products: List<Product>         |          
//      | -customer: Customer              |
//      +----------------------------------+
//      | -AddProduct(Product)             |
//      | -CalculateTotal(): decimal       |    
//      | -GetPackingLabel(): string       | 
//      | -GetShippingLabel(): string      |
//      +----------------------------------+

    }
}