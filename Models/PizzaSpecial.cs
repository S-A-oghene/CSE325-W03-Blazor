namespace BlazingPizza.Models;

/// <summary>A pizza offered on the Blazing Pizza menu.</summary>
public sealed record PizzaSpecial(
    int Id,
    string Name,
    string Description,
    decimal BasePrice,
    string Emoji,
    string[] Toppings);
