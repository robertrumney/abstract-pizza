# Unity C# Pizza Store Example

This repository contains a simple Unity C# script demonstrating the use of a `PizzaStore` class to order different types of pizzas. The `PizzaTest` script is a Unity MonoBehaviour that showcases how to create instances of various pizza types using the `PizzaStore` class and display the ordered pizza names in the console.

## Overview

The `PizzaTest` script, when attached to a GameObject in a Unity scene, creates a `PizzaStore` object and uses it to order two different types of pizzas: Margherita and Pepperoni. The script then logs the names of the ordered pizzas in the console.

```csharp
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
```
