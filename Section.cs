using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseAI
{
    public class Section
    {
        public int ID { get; private set; }
        private Dictionary<string, Item> items;

        public Section(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Section ID cannot be less than 1.", nameof(id));
            }

            ID = id;
            items = new Dictionary<string, Item>();
        }

        public void AddItem(string itemName, int quantity)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity cannot be less than 1.", nameof(quantity));
            }

            if (items.ContainsKey(itemName))
            {
                items[itemName].AddQuantity(quantity);
            }
            else
            {
                items[itemName] = new Item(itemName, quantity);
            }
        }

        public void RemoveItem(string itemName, int quantity)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity cannot be less than 1.", nameof(quantity));
            }

            if (items.ContainsKey(itemName))
            {
                items[itemName].RemoveQuantity(quantity);

                if (items[itemName].Quantity == 0)
                {
                    items.Remove(itemName);
                }
            }
        }

        public int GetItemCount(string itemName)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            return items.ContainsKey(itemName) ? items[itemName].Quantity : 0;
        }

        public List<Tuple<string, int>> GetAllItemsInSection()
        {
            return items.Values
                .Select(item => new Tuple<string, int>(item.Name, item.Quantity))
                .OrderBy(tuple => tuple.Item1)
                .ToList();
        }
    }
}
