using System.Runtime.CompilerServices;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductDetails(){
        return $"{_name}, {_productId}, {_price}, {_quantity}";
    }

    public decimal ProductPrice(){
        return _price * _quantity;
    }
}