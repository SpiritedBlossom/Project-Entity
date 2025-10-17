using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemSO", menuName = "Inventory/InventoryItemSO")]
public abstract class InventoryItemSO : ScriptableObject
{
    public string flavourText;
    public string itemName;
    public int sellValue;
    public abstract InventoryItemData CreateRuntimeData();

}

public abstract class InventoryItemData
{
     public InventoryItemSO config;
    public int qty;
}

public class ConsumableInventoryItemData: InventoryItemData
{
    [SerializeReference, InlineProperty, HideLabel]
    public ConsumableBehavior behavior;
    public int sellPrice;
    public string itemName;
    public string flavorText;

    public ConsumableInventoryItemData(ConsumableInventoryItemSO config_)
    {
        config = config_;
        behavior = config_.behavior;
        sellPrice = config.sellValue;
        itemName = config.itemName;
        flavorText = config.flavourText;
        qty = 1;
    }

}

public class QuestInventoryItemData : InventoryItemData
{
    public int sellPrice;
    public string itemName;
    public string flavorText;

    public QuestInventoryItemData(QuestInventoryItemSO config_)
    {
        config = config_;
        sellPrice = config.sellValue;
        itemName = config.itemName;
        flavorText = config.flavourText;
        qty = 1;

    }
}

