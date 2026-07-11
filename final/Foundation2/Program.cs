using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Program class creates sample customers, addresses, products, and orders.
        It displays packing labels, shipping labels, and total costs for the Encapsulation
        final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Input
            // No user input is required for this project.

        // Process
            // Create Address, Customer, Product, and Order class instances.

        // Output
            // Display packing labels, shipping labels, and total order costs.

        JlbRunOrderProgram();
    }

    // Project Input functions that call Support Functions
    // No input functions are needed because the assignment allows sample data to be created in Program.cs.

    // Project Process functions that call Class
    public static void JlbRunOrderProgram()
    {
        Address jlbFirstAddress = new Address("The Swamp", "Everglades", "Florida", "USA");
        Customer jlbFirstCustomer = new Customer("Shrek", jlbFirstAddress);

        Product jlbFirstProduct = new Product("Xbox 360", 123, 12, 5);
        Product jlbSecondProduct = new Product("Waffles", 124, 4, 3);

        Address jlbSecondAddress = new Address("Bruce Wayne's Manor", "Gotham City", "New Jersey", "USA");
        Customer jlbSecondCustomer = new Customer("Batman", jlbSecondAddress);

        Product jlbThirdProduct = new Product("Black Tights", 456, 5, 3);
        Product jlbFourthProduct = new Product("Grappling Hook", 457, 20, 2);

        Order jlbOrder1 = new Order(jlbFirstCustomer);
        jlbOrder1.JlbAddProduct(jlbFirstProduct);
        jlbOrder1.JlbAddProduct(jlbSecondProduct);

        Order jlbOrder2 = new Order(jlbSecondCustomer);
        jlbOrder2.JlbAddProduct(jlbThirdProduct);
        jlbOrder2.JlbAddProduct(jlbFourthProduct);

        JlbDisplayOrder("Order 1:", jlbOrder1);
        JlbDisplayOrder("Order 2:", jlbOrder2);
    }

    // Project Output functions that call Support Functions
    public static void JlbDisplayOrder(string jlbOrderTitle, Order jlbOrder)
    {
        JlbPrint(jlbOrderTitle);
        JlbPrint(jlbOrder.JlbGetPackingLabel());
        JlbPrint(jlbOrder.JlbGetShippingLabel());
        JlbPrint($"Total Cost: {jlbOrder.JlbCalculateTotalCost():C}");
        JlbPrint("");
    }

    public static void JlbPrint(string jlbText)
    {
        Console.WriteLine(jlbText);
    }
}