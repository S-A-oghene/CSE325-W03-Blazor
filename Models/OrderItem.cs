namespace BlazingPizza.Models;

/// <summary>A customized pizza saved in the current visitor's order.</summary>
public sealed record OrderItem(
    Guid Id,
    string PizzaName,
    string Size,
    string[] Toppings,
    decimal Price);
