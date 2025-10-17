using UnityEngine;

[CreateAssetMenu(fileName = "QuestInventoryItemSO", menuName = "Inventory/QuestInventoryItemSO")]
public class QuestInventoryItemSO : InventoryItemSO
{
    public QuestSO associatedQuest;

    public override InventoryItemData CreateRuntimeData()
    {
        return new QuestInventoryItemData(this);
        
    }
}
