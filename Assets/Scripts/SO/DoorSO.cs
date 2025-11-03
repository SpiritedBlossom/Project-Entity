using UnityEngine;

[CreateAssetMenu(fileName = "DoorSO", menuName = "Scriptable Objects/DoorSO")]
public class DoorSO : ScriptableObject
{
    //door identifier to match with corresponding key identifier
    public int identifier;
}
