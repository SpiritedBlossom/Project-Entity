using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "ConsumableInventoryItemSO", menuName = "Inventory/ConsumableInventoryItemSO")]
public class ConsumableInventoryItemSO : InventoryItemSO
{
    [SerializeReference, InlineProperty, HideLabel]
    public ConsumableBehavior behavior;
    public override InventoryItemData CreateRuntimeData()
    {
        return new ConsumableInventoryItemData(this);
    }
}
