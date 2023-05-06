public class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        switch (type)
        {
            case "Margherita":
                pizza = new MargheritaPizza();
                break;
            case "Pepperoni":
                pizza = new PepperoniPizza();
                break;
            default:
                throw new ArgumentException($"Invalid pizza type: {type}");
        }

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
