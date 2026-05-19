namespace BlazorApp5.Models;

public class CartItem
{
    public MenuItem Item { get; set; } = new();
    public int Quantity { get; set; }
    public decimal Total => Item.Price * Quantity;
} 