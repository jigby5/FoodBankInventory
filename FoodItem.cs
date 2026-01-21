namespace FoodBankInventory;

public class FoodItem
{
    // creates variables visible to the entire class
    private string _name;
    private string _category;
    private int _quantity;
    private string _expirationDate;

    public FoodItem(string name, string category, int quantity, string expirationDate)
    {
        // loads the object parameters into the variables
        _name = name;
        _category = category;
        _quantity = quantity;
        _expirationDate = expirationDate;
    }
    
    public string GetName()
        // generic methods that return the class variables stored
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
