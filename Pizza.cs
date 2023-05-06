public abstract class Pizza
{
    public string Name { get; protected set; }
    public List<string> Ingredients { get; protected set; }

    public Pizza()
    {
        Ingredients = new List<string>();
    }

    public abstract void Prepare();

    public void Bake()
    {
        Debug.Log($"Baking {Name} pizza...");
    }

    public void Cut()
    {
        Debug.Log($"Cutting {Name} pizza...");
    }

    public void Box()
    {
        Debug.Log($"Boxing {Name} pizza...");
    }
}
