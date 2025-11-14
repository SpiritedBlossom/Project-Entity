using UnityEngine;

public class WeaponData
{
    //Allows us to store SO data during runtime
    //Can then serialize data and modify it w/o modifying existing SO files
    public float damage;
    public int ammoCapacity;
    public string weaponName;
    public float range;

    public void InitializeWeaponData(WeaponSO weapon)
    {
        //data from SO, assign accordingly
        damage = weapon.damage;
        ammoCapacity = weapon.ammoCapacity;
        weaponName = weapon.weaponName;
        range = weapon.range;
    }
}
