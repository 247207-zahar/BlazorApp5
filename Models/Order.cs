namespace BlazorApp5.Models;
public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = "";
    public string Phone { get; set; } = "";
    public string DeliveryAddress { get; set; } = "";
    public string Notes { get; set; } = "";
    public string PaymentMethod { get; set; } = "cash";
    public string RestaurantName { get; set; } = "";
    public string RestaurantEmoji { get; set; } = "🍔";
    public string ItemsSummary { get; set; } = "";
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Placed";
    public DateTime PlacedAt { get; set; } = DateTime.Now;
    public List<OrderItem> Items { get; set; } = new();
}