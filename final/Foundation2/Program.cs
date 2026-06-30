using System;

class Program
{
    static void Main(string[] args)
    {
        Address firstAddress = new Address("The Swamp", "Everglades", "Florida", "USA");

        Customer firstCostumer = new Customer("Shrek", firstAddress);

        Product fisrtProduct = new Product("Xbox 360", 123, 12, 5);

        Address secondAddress = new Address("Bruce Wayne's Manor", "Gotham City", "New Jersey", "USA");
        Customer secondCostumer = new Customer("Batman", secondAddress);
        Product secondProduct = new Product("Black Tights", 456, 5, 3);

        // Create orders
        Order order1 = new Order(firstCostumer);
        order1.AddProduct(fisrtProduct);

        Order order2 = new Order(secondCostumer);
        order2.AddProduct(secondProduct);


        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");

    }
}