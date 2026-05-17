using BlazorApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BlazorApp5.Services
{
    public class CartService
    {
        // Dictionary use kar rahe hain: Key = MenuItem, Value = Quantity (int)
        private readonly Dictionary<MenuItem, int> _items = new();
        public event Action? OnCartChanged;

        // Menu.razor ke loop ke liye items return karega
        public Dictionary<MenuItem, int> GetItems() => _items;

        // Total quantity count karne ke liye
        public int ItemCount => _items.Values.Sum();

        // Total price calculate karne ke liye (Price * Quantity)
        public decimal Total => _items.Sum(entry => entry.Key.Price * entry.Value);
