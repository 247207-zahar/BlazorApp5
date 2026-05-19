namespace BlazorApp5.Models;
public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Cuisine { get; set; } = "";
    public string Emoji { get; set; } = "🍽️";
    public string Address { get; set; } = "";
    public double Rating { get; set; }
    public int DeliveryTimeMinutes { get; set; }
    public decimal DeliveryFee { get; set; }
    public bool IsOpen { get; set; } = true;

    public List<MenuItem> MenuItems { get; set; } = new();
}