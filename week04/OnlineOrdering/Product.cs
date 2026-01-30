using System;

class Product
{
    private string _name;
    private int _product_id;
    private float _price;
    private int _quantity;

    public Product(string name, int product_id, float price, int quantity)
    {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public string Name => _name;
    public int ProductId => _product_id;
    public float Price => _price;
    public int Quantity => _quantity;

    public float GetTotalPrice()
    {
        return _price * _quantity;
    }
}