using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        // Add shipping cost
        if (_customer.LivesInNigeria())
        {
            total += 5; // Shipping cost for Nigeria
        }
        else
        {
            total += 35; // International shipping cost
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "=== PACKING LABEL ===\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "=== SHIPPING LABEL ===\n";
        label += $"Customer: {_customer.Name}\n";
        label += $"Address:\n{_customer.Address.Display()}\n";
        return label;
    }
}