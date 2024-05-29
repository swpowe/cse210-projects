using System;

class Program
{
    static void Main(string[] args)
    {
        // Once you have created these classes, write a program that creates at least two orders with a 2 - 3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

        List<Product> order1Products = new();
        Product p1 = new("Clap On", 123, 3.25, 3);
        Product p2 = new("USB Cable", 456, 12.00, 2);
        Product p3 = new("Hat", 789, 3.00, 1);

        order1Products.Add(p1);
        order1Products.Add(p2);
        order1Products.Add(p3);

        List<Product> order2Products = new();
        Product p4 = new("Socks", 101112, 8.00, 3);
        Product p5 = new("Pillow", 131415, 6.00, 2);
        Product p6 = new("Poster", 161718, 3.00, 5);

        order2Products.Add(p4);
        order2Products.Add(p5);
        order2Products.Add(p6);

        Customer c1 = new("Customer One");
        c1.SetAddress("123 Smart Street", "Baldwin", "MO", "USA");

        Order o1 = new(c1, order1Products);

        Customer c2 = new("Customer Two");
        c2.SetAddress("45 Window Ln", "Boxing", "Kent", "GB");

        Order o2 = new(c2, order2Products);

        // packing label
        Console.WriteLine("-Order #1------------------------------------");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o1.GetPackingLabel());

        // shipping label
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o1.GetShippingLabel());

        // total price of order
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${o1.GetTotalPrice()}");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("-Order #2------------------------------------");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o2.GetPackingLabel());

        // shipping label
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o2.GetShippingLabel());

        // total price of order
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${o2.GetTotalPrice()}");
        Console.WriteLine("---------------------------------------------");
    }
}