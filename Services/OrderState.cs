using BlazingPizza.Models;

namespace BlazingPizza.Services;

/// <summary>Stores the current visitor's customized pizzas during their session.</summary>
public sealed class OrderState
{
    private readonly List<OrderItem> _items = [];

    public IReadOnlyList<OrderItem> Items => _items;
    public int ItemCount => _items.Count;
    public decimal Total => _items.Sum(item => item.Price);

    public void Add(PizzaSpecial pizza, string size, IEnumerable<string> toppings, decimal price)
    {
        _items.Add(new OrderItem(
            Guid.NewGuid(),
            pizza.Name,
            size,
            toppings.ToArray(),
            price));
    }

    public void Remove(Guid itemId)
    {
        var item = _items.FirstOrDefault(candidate => candidate.Id == itemId);
        if (item is not null)
        {
            _items.Remove(item);
        }
    }

    public void Clear() => _items.Clear();
}
