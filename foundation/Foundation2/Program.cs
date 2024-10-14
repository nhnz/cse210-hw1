using System;
using System.Collections.Generic;

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
//      | -name: string                    | 
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

        // Addresses
        Address address1 = new Address("478 Pinedale St","New York","NY","USA");
        Address address2 = new Address("72 Bedford Av","Durban","KZN","RSA");

        //Customers
        Customer customer1 = new Customer("Will Smith", address1);
        Customer customer2 = new Customer("Malcom Louw",address2);

        //Products
        Product product1 = new Product("Tires", "T001", 200.00m, 4);
        Product product2 = new Product("Brake Pads", "B001", 400.00m, 4);
        Product product3 = new Product("Air Filter", "A001", 90.00m, 1);
        Product product4 = new Product("Fuel Filter", "F001", 180.00m, 1);

        //Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);

    }

    static void DisplayOrderDetails(Order order)
    {
       // Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel() + "\n");
        //Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.CalculateTotal():C}");
        Console.WriteLine();
    }
}