namespace FoodBankInventory;

public class FoodItem
{
    private string _name;
    private string _category;
    private int _quantity;
    private string _expirationDate;

    public FoodItem(string name, string category, int quantity, string expirationDate)
    {
        _name = name;
        _category = category;
        _quantity = quantity;
        _expirationDate = expirationDate;
    }
    
    public string GetName()
    {
        return _name;
    }

    public string GetCategory()
    {
        return _category;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetExpirationDate()
    {
        return _expirationDate;
    }
}
