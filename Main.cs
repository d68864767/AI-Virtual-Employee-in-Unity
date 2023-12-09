using System;
using UnityEngine;
using WarehouseAI;

public class Main : MonoBehaviour
{
    private UnityInterface unityInterface;

    void Start()
    {
        unityInterface = new UnityInterface();

        // Adding items to the warehouse
        unityInterface.AddItem(1, "Laptop", 10);
        unityInterface.AddItem(1, "Mobile", 20);
        unityInterface.AddItem(2, "T-Shirt", 15);

        // Removing items from the warehouse
        unityInterface.RemoveItem(1, "Laptop", 5);

        // Getting item count
        int laptopCount = unityInterface.GetItemCount(1, "Laptop");
        Debug.Log($"Laptop Count: {laptopCount}");

        // Getting all items in a section
        var itemsInSection1 = unityInterface.GetAllItemsInSection(1);
        foreach (var item in itemsInSection1)
        {
            Debug.Log($"Item: {item.Item1}, Quantity: {item.Item2}");
        }
    }
}
