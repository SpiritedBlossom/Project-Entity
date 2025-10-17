using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory:MonoBehaviour
{
    Dictionary<InventoryItemSO, InventoryItemData> inventory = new();
    Dictionary<ConsumableInventoryItemSO,ConsumableInventoryItemData> consumables = new();
    Dictionary<QuestInventoryItemSO, QuestInventoryItemData> questItems = new();

    public void AddItem(InventoryItemSO item)
    {
        if (inventory.TryGetValue(item, out var entry))
        {
            // entry.runtime already exists, just update the quantity
            entry.qty++;
        }
        else
        {
            // Create new runtime data and add to inventory
            var runtime = item.CreateRuntimeData();
            inventory[item] = runtime;
        }
    }


    public void UseItem(ConsumableInventoryItemData item)
    {
        item.behavior.Consume();
        inventory.TryGetValue(item.config, out var entry);
        entry.qty -= 1;
        inventory[item.config] = entry;
        if (entry.qty <= 0)
        {
            inventory.Remove(item.config);
        }
    }

    public void SortInventory()
    {
        foreach(var kvp in inventory)
        {
            var item = kvp.Key;
            var runtime = kvp.Value;
            int quantity = kvp.Value.qty; 
            switch (item)
            {
                case ConsumableInventoryItemSO c:
                    consumables[c] = (ConsumableInventoryItemData)kvp.Value;
                    break;
                case QuestInventoryItemSO q:
                    questItems[q] = (QuestInventoryItemData)kvp.Value;
                    break;
                default:
                    break;
            }

        }
    }
}
