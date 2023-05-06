public class MargheritaPizza : Pizza
{
    public MargheritaPizza()
    {
        Name = "Margherita";
        Ingredients.AddRange(new[] { "Tomato Sauce", "Mozzarella Cheese", "Basil" });
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {Name} pizza with {string.Join(", ", Ingredients)}...");
    }
}

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni";
        Ingredients.AddRange(new[] { "Tomato Sauce", "Mozzarella Cheese", "Pepperoni" });
    }

    public override void Prepare()
    {
        Debug.Log($"Preparing {Name} pizza with {string.Join(", ", Ingredients)}...");
    }
}
