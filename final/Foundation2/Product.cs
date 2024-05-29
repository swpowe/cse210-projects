// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
public class Product{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity){
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName(){
        return _name;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public int GetProductID(){
        return _productID;
    }
    public double GetTotalPrice(){
        return _quantity * _price;
    }

}