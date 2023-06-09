# Unity C# Pizza Example: Abstract Classes

This repository contains a simple Unity C# project demonstrating the use of abstract classes with the concept of pizza. The purpose of this educational resource is to help people understand the basics of abstract classes in Unity C# by using pizza examples, recipes, variations, and ingredients.

## Why Abstract Classes?

Abstract classes allow you to define a base class that cannot be instantiated but can be inherited by other classes. They provide a blueprint for creating multiple variations of a class without the need for duplicating code. In this example, we use pizzas to demonstrate how abstract classes can help organize different pizza types and their behavior while reusing common properties and methods from the base class.

## Example Overview

In this example, we have:

1. An abstract base class called `Pizza` that holds common properties and methods for different types of pizzas.
2. Concrete pizza classes (e.g., `MargheritaPizza` and `PepperoniPizza`) that inherit from the abstract `Pizza` class and provide their implementation of the `Prepare()` method.
3. A simple `PizzaStore` class that demonstrates how to create and interact with pizza objects.

## Base Classes Explanation

### Abstract Pizza Class

The `Pizza` class is an abstract base class that represents a generic pizza. It contains common properties and methods that all pizzas share. Concrete pizza classes will inherit from this base class and provide their specific implementations.

```csharp
public abstract class Pizza
{
    public string Name { get; protected set; }
    protected List<string> Ingredients;

    public abstract void Prepare();

    public void Bake()
    {
        // Baking logic
    }

    public void Cut()
    {
        // Cutting logic
    }

    public void Box()
    {
        // Boxing logic
    }
}
```

### Concrete Pizza Classes

Concrete pizza classes, such as MargheritaPizza and PepperoniPizza, inherit from the abstract Pizza class. They provide their specific implementations of the Prepare() method and define their unique ingredients.

```csharp
public class MargheritaPizza : Pizza
{
    public MargheritaPizza()
    {
        Name = "Margherita";
        Ingredients = new List<string> { "Tomato Sauce", "Mozzarella Cheese", "Basil" };
    }

    public override void Prepare()
    {
        // Preparation logic for Margherita pizza
    }
}

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni";
        Ingredients = new List<string> { "Tomato Sauce", "Mozzarella Cheese", "Pepperoni" };
    }

    public override void Prepare()
    {
        // Preparation logic for Pepperoni pizza
    }
}
```

### PizzaStore Class

The PizzaStore class is responsible for creating pizza objects based on the requested type. It has an OrderPizza() method that takes a string representing the pizza type and returns an instance of the corresponding pizza class.

```csharp
public class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        if (type == "Margherita")
        {
            pizza = new MargheritaPizza();
        }
        else if (type == "Pepperoni")
        {
            pizza = new PepperoniPizza();
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
```

## License

This project is licensed under the [MIT License](LICENSE).
