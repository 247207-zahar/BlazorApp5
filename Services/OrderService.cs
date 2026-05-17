using BlazorApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5.Services
{
    public class OrderService
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1001;

        public IReadOnlyList<Order> Orders => _orders.AsReadOnly();
        public event Action? OnChange;

        // Is method ko Async banaya taaki Checkout.razor ke 'await' se match kare
        public async Task PlaceOrderAsync(Order order)
        {
            // ID aur initial setup
            order.Id = _nextId++;

            // _orders list mein add karein
            _orders.Insert(0, order);

            NotifyChange();

            // Background mein progress simulate karein
            _ = SimulateProgress(order);

            await Task.CompletedTask;
        }

        // Admin panel se order status update karne ke liye method
        public async Task UpdateStatusAsync(int orderId, string newStatus)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                order.Status = newStatus;
                NotifyChange();
            }
            await Task.CompletedTask;
        }

        // Dashboard ke liye method (Jo pichle errors mein missing tha)
        public async Task<List<Order>> GetCustomerOrdersAsync(int customerId)
        {
            await Task.Delay(100); // Fake delay
            return _orders.Where(o => o.CustomerId == customerId).ToList();
        }

        public Order? GetOrder(int id) =>
            _orders.FirstOrDefault(o => o.Id == id);

        private async Task SimulateProgress(Order order)
        {
            await Task.Delay(6000);
            order.Status = "On the Way";
            NotifyChange();

            await Task.Delay(10000);
            order.Status = "Delivered";
            NotifyChange();
        }

        private void NotifyChange() => OnChange?.Invoke();
    }
}