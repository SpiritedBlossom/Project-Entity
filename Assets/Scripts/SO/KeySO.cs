using UnityEngine;

[CreateAssetMenu(fileName = "KeySO", menuName = "Scriptable Objects/KeySO")]
public class KeySO : ScriptableObject
{
    //key identifier to match with corresponding door identifier
    public int identifier;
}
