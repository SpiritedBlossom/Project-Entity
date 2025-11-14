using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public float damage;
    public int ammoCapacity;
    public string weaponName;
    public WeaponType weaponType;
    public float range;
    public GameObject prefab;

    public enum WeaponType
    {
        PISTOL,
        SHOTGUN,
        RIFLE
    }
}
