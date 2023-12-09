using System;
using System.Collections.Generic;

namespace WarehouseAI
{
    public class Warehouse
    {
        private Dictionary<int, Section> sections;

        public Warehouse()
        {
            sections = new Dictionary<int, Section>();
        }

        public void AddItem(int sectionID, string itemName, int quantity)
        {
            if (sectionID < 1)
            {
                throw new ArgumentException("Section ID cannot be less than 1.", nameof(sectionID));
            }

            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity cannot be less than 1.", nameof(quantity));
            }

            if (!sections.ContainsKey(sectionID))
            {
                sections[sectionID] = new Section(sectionID);
            }

            sections[sectionID].AddItem(itemName, quantity);
        }

        public void RemoveItem(int sectionID, string itemName, int quantity)
        {
            if (sectionID < 1)
            {
                throw new ArgumentException("Section ID cannot be less than 1.", nameof(sectionID));
            }

            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity cannot be less than 1.", nameof(quantity));
            }

            if (sections.ContainsKey(sectionID))
            {
                sections[sectionID].RemoveItem(itemName, quantity);
            }
        }

        public int GetItemCount(int sectionID, string itemName)
        {
            if (sectionID < 1)
            {
                throw new ArgumentException("Section ID cannot be less than 1.", nameof(sectionID));
            }

            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
            }

            return sections.ContainsKey(sectionID) ? sections[sectionID].GetItemCount(itemName) : 0;
        }

        public List<Tuple<string, int>> GetAllItemsInSection(int sectionID)
        {
            if (sectionID < 1)
            {
                throw new ArgumentException("Section ID cannot be less than 1.", nameof(sectionID));
            }

            return sections.ContainsKey(sectionID) ? sections[sectionID].GetAllItemsInSection() : new List<Tuple<string, int>>();
        }
    }
}
