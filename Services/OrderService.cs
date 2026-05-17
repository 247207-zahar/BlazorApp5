
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
