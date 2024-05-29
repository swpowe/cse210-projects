// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;

    }

    public string GetPackingLabel()
    {
        // A packing label should list the name and product id of each product in the order.
        string h1 = "Product Name";
        string h2 = "Product ID";
        string h3 = "Quantity";
        string items = "";
        // Console.WriteLine("----------------");
        // Console.WriteLine($"{h1, 15}{h2, 15}");

        foreach (var item in _products)
        {
            items += $"{item.GetName(), -15}{item.GetProductID(), -15}{item.GetQuantity(), -15}\n";
        }
        // Console.WriteLine("----------------");
        string label = $@"--------------------
{h1, -15}{h2, -15}{h3, -15}
{items}
--------------------";
    return label;
    }

    public string GetShippingLabel()
    {
        return $"--------------------\nShip To:\n{_customer.GetShippingAddress()}\n--------------------";
    }

    // public double GetTotalCost()
    // { // order subtotal

    // }
    public double GetTotalPrice()
    { // order total
      // cost of each item int he products lists
      // plus shipping cost
        double subtotal = 0.00;
        int shipping = 35;

        foreach (var item in _products)
        {
            subtotal += item.GetTotalPrice();
        }

        if (_customer.USA())
        {
            shipping = 5;
        }

        return subtotal + shipping;

    }

}