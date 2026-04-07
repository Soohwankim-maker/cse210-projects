using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Doe", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Book", "B1", 10, 2));
        order1.AddProduct(new Product("Pen", "P1", 2, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        // Order 2 (International)
        Address addr2 = new Address("456 Street", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "L1", 800, 1));
        order2.AddProduct(new Product("Mouse", "M1", 25, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

        Console.WriteLine(order1.GetOrderSummary());
    }
}