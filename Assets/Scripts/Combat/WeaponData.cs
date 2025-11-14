using UnityEngine;

public class WeaponData
{
    public float damage;
    public int ammoCapacity;
    public string weaponName;
    public float range;

    public void InitializeWeaponData(WeaponSO weapon)
    {
        //data from SO, assign it
        damage = weapon.damage;
        ammoCapacity = weapon.ammoCapacity;
        weaponName = weapon.weaponName;
        range = weapon.range;
    }
}
