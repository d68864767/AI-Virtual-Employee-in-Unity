using System;

namespace WarehouseAI
{
    public class Item
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public Item(string name, int quantity)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(name));
            }

            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be less than zero.", nameof(quantity));
            }

            Name = name;
            Quantity = quantity;
        }

        public void AddQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity to add cannot be less than zero.", nameof(quantity));
            }

            Quantity += quantity;
        }

        public void RemoveQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity to remove cannot be less than zero.", nameof(quantity));
            }

            Quantity = Math.Max(0, Quantity - quantity);
        }
    }
}
