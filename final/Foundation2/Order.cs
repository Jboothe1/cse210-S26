public class Order 
{

    private List<Product> _products;
    private Customer _customer;


    public Order (Customer costumer){
        _customer = costumer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalProductPrice = 0;
        foreach (var product in _products)
        {
            totalProductPrice += product.ProductPrice();
        }

        decimal shippingCost = _customer.IsUSA() ? 5 : 35;

        return totalProductPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for {_customer.GetCustomerDetails()}:\n";
        foreach (var product in _products)
        {
            packingLabel += product.GetProductDetails() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label for {_customer.GetCustomerDetails()}";
    }
}