using System;
using System.Collections.Generic;
using UnityEngine;
using WarehouseAI;

public class UnityInterface : MonoBehaviour
{
    private AI_Employee aiEmployee;

    void Start()
    {
        aiEmployee = new AI_Employee();
    }

    public void AddItem(int sectionID, string itemName, int quantity)
    {
        aiEmployee.AddItem(sectionID, itemName, quantity);
    }

    public void RemoveItem(int sectionID, string itemName, int quantity)
    {
        aiEmployee.RemoveItem(sectionID, itemName, quantity);
    }

    public int GetItemCount(int sectionID, string itemName)
    {
        return aiEmployee.GetItemCount(sectionID, itemName);
    }

    public List<Tuple<string, int>> GetAllItemsInSection(int sectionID)
    {
        return aiEmployee.GetAllItemsInSection(sectionID);
    }
}
