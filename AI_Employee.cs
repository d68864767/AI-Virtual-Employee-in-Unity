using System;

namespace WarehouseAI
{
    public class AI_Employee
    {
        private Warehouse warehouse;

        public AI_Employee()
        {
            warehouse = new Warehouse();
        }

        public void AddItem(int sectionID, string itemName, int quantity)
        {
            try
            {
                warehouse.AddItem(sectionID, itemName, quantity);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveItem(int sectionID, string itemName, int quantity)
        {
            try
            {
                warehouse.RemoveItem(sectionID, itemName, quantity);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int GetItemCount(int sectionID, string itemName)
        {
            try
            {
                return warehouse.GetItemCount(sectionID, itemName);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public void GetAllItemsInSection(int sectionID)
        {
            try
            {
                var items = warehouse.GetAllItemsInSection(sectionID);
                foreach (var item in items)
                {
                    Console.WriteLine($"Item: {item.Item1}, Quantity: {item.Item2}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
