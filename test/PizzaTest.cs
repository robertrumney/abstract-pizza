using UnityEngine;

public class PizzaTest : MonoBehaviour
{
    private void Start()
    {
        PizzaStore pizzaStore = new PizzaStore();

        Pizza margheritaPizza = pizzaStore.OrderPizza("Margherita");
        Debug.Log($"Ordered a {margheritaPizza.Name} pizza");

        Pizza pepperoniPizza = pizzaStore.OrderPizza("Pepperoni");
        Debug.Log($"Ordered a {pepperoniPizza.Name} pizza");
    }
}
