using BlazingPizza.Models;

namespace BlazingPizza.Services;

/// <summary>Provides the menu data used by the Blazing Pizza pages.</summary>
public sealed class PizzaCatalog
{
    public IReadOnlyList<PizzaSpecial> Pizzas { get; } =
    [
        new(1, "Margherita", "Tomatensaus, mozzarella en verse basilicum.", 9.50m, "🍅",
            ["Mozzarella", "Tomaat", "Verse basilicum"]),
        new(2, "Pepperoni", "Een klassieker met pepperoni en mozzarella.", 12.50m, "🍕",
            ["Mozzarella", "Pepperoni", "Tomatensaus"]),
        new(3, "BBQ Chicken", "Kip, rode ui, mozzarella en barbecuesaus.", 13.75m, "🍗",
            ["Kip", "Rode ui", "Mozzarella", "Barbecuesaus"]),
        new(4, "Quattro Formaggi", "Een rijke combinatie van vier kazen.", 12.00m, "🧀",
            ["Mozzarella", "Gorgonzola", "Parmezaan", "Geitenkaas"]),
        new(5, "Veggie Supreme", "Paprika, champignons, olijven en rode ui.", 11.50m, "🫑",
            ["Paprika", "Champignons", "Olijven", "Rode ui"]),
        new(6, "Spicy Salami", "Pittige salami, jalapeño en mozzarella.", 13.00m, "🌶️",
            ["Pittige salami", "Jalapeño", "Mozzarella"])
    ];

    public PizzaSpecial? FindById(int id) => Pizzas.FirstOrDefault(pizza => pizza.Id == id);
}
